using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace TowerPlacement
{
    class Program
    {
        // описание типа вышки
        class TowerType
        {
            public int Radius;     // в клетках (манхэттен)
            public double Power;   // вклад в покрытие
            public int Cost;       // стоимость

            public TowerType(int r, double p, int c)
            {
                Radius = r;
                Power = p;
                Cost = c;
            }
        }

        // установленная вышка
        class Tower
        {
            public int Row;
            public int Col;
            public TowerType Type;

            public Tower(int r, int c, TowerType t)
            {
                Row = r;
                Col = c;
                Type = t;
            }

            public override string ToString()
            {
                return $"Тип {(Type.Power == 1 ? 1 : 2)}, строка {Row}, столбец {Col}, цена {Type.Cost}";
            }
        }

        static void Main()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string path = "List-Microsoft-Excel-3.xlsx"; // имя вашего файла
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден: " + path);
                return;
            }

            // 1. Чтение матрицы требований из Excel
            double[,] demand = ReadDemandMatrix(path, out int rows, out int cols);

            // 2. Подготовка типов вышек
            var type1 = new TowerType(radius: 2, power: 1.0, cost: 1);
            var type2 = new TowerType(radius: 3, power: 2.0, cost: 2);
            var types = new[] { type2, type1 }; // сначала более «сильная» вышка

            // 3. Инициализация покрытия
            double[,] cover = new double[rows, cols];

            // 4. Список всех допустимых позиций (demand > 0)
            var placements = new List<(int r, int c)>();
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    if (demand[r, c] > 0.0)
                        placements.Add((r, c));

            // 5. Жадное размещение вышек
            const int budgetLimit = 25;
            int currentCost = 0;
            var towers = new List<Tower>();

            while (true)
            {
                // ищем клетку с наибольшим недопокрытием
                double maxDeficit = 0.0;
                int needR = -1, needC = -1;

                for (int r = 0; r < rows; r++)
                    for (int c = 0; c < cols; c++)
                    {
                        double def = demand[r, c] - cover[r, c];
                        if (def > maxDeficit + 1e-9) // небольшой допуск
                        {
                            maxDeficit = def;
                            needR = r;
                            needC = c;
                        }
                    }

                // все клетки удовлетворены
                if (maxDeficit <= 1e-9) break;

                // выбираем лучшую вышку и позицию
                Tower bestTower = null;
                double bestScore = 0.0;

                foreach (var tp in types)
                {
                    if (currentCost + tp.Cost > budgetLimit) continue;

                    foreach (var pos in placements)
                    {
                        int pr = pos.r;
                        int pc = pos.c;

                        double gain = ComputeGain(demand, cover, tp, pr, pc);

                        // коэффициент эффективности: покрытие / стоимость
                        double score = gain / tp.Cost;

                        if (gain > 0 && score > bestScore + 1e-9)
                        {
                            bestScore = score;
                            bestTower = new Tower(pr, pc, tp);
                        }
                    }
                }

                if (bestTower == null)
                {
                    Console.WriteLine("Не удалось улучшить покрытие в рамках бюджета.");
                    break;
                }

                // ставим выбранную вышку
                ApplyTower(cover, bestTower);
                towers.Add(bestTower);
                currentCost += bestTower.Type.Cost;
            }

            // 6. Проверка покрытия
            bool ok = true;
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    if (demand[r, c] > 0 && cover[r, c] + 1e-9 < demand[r
                if (demand[r, c] > 0 && cover[r, c] + 1e-9 < demand[r, c])
                        {
                            ok = false;
                        }
                }

            Console.WriteLine("Результат размещения вышек:");
            Console.WriteLine($"Всего вышек: {towers.Count}");
            Console.WriteLine($"Суммарная стоимость: {currentCost} (лимит {budgetLimit})");
            Console.WriteLine($"Все требования выполнены: {ok}");
            Console.WriteLine();

            int index = 1;
            foreach (var t in towers)
            {
                Console.WriteLine($"{index}. {t}");
                index++;
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        // Чтение матрицы требований из Excel
        static double[,] ReadDemandMatrix(string path, out int rows, out int cols)
        {
            using var package = new ExcelPackage(new FileInfo(path));
            var ws = package.Workbook.Worksheets[0];

            // Определяем прямоугольник с данными
            int maxRow = ws.Dimension.End.Row;
            int maxCol = ws.Dimension.End.Column;

            // Сначала собираем всё во временный список,
            // чтобы отбросить полностью пустые строки/столбцы
            var temp = new List<List<double?>>();

            for (int r = 1; r <= maxRow; r++)
            {
                var rowList = new List<double?>();
                bool any = false;
                for (int c = 1; c <= maxCol; c++)
                {
                    var v = ws.Cells[r, c].Value;
                    if (v == null)
                    {
                        rowList.Add(null);
                        continue;
                    }

                    if (double.TryParse(v.ToString().Replace(',', '.'), System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double d))
                    {
                        rowList.Add(d);
                        any = true;
                    }
                    else
                    {
                        rowList.Add(null);
                    }
                }
                if (any) temp.Add(rowList);
            }

            rows = temp.Count;
            cols = 0;
            foreach (var rList in temp)
                cols = Math.Max(cols, rList.Count);

            var res = new double[rows, cols];

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    if (c < temp[r].Count && temp[r][c].HasValue)
                        res[r, c] = temp[r][c].Value;
                    else
                        res[r, c] = 0.0; // вне города или пусто
                }

            return res;
        }

        // Считаем дополнительное покрытие от возможной вышки
        static double ComputeGain(double[,] demand, double[,] cover, TowerType tp, int pr, int pc)
        {
            int rows = demand.GetLength(0);
            int cols = demand.GetLength(1);
            double gain = 0.0;

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    // манхэттенов радиус
                    int dist = Math.Abs(r - pr) + Math.Abs(c - pc);
                    if (dist <= tp.Radius)
                    {
                        double need = demand[r, c] - cover[r, c];
                        if (need > 0)
                        {
                            gain += Math.Min(need, tp.Power);
                        }
                    }
                }
            return gain;
        }

        // Применяем вышку: обновляем матрицу покрытия
        static void ApplyTower(double[,] cover, Tower tower)
        {
            int rows = cover.GetLength(0);
            int cols = cover.GetLength(1);
            int pr = tower.Row;
            int pc = tower.Col;
            int radius = tower.Type.Radius;
            double power = tower.Type.Power;

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    int dist = Math.Abs(r - pr) + Math.Abs(c - pc);
                    if (dist <= radius)
                    {
                        cover[r, c] += power;
                    }
                }
        }
    }
}
