using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double[] array = new double[n];
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            array[i] = rnd.NextDouble() * 20 - 10; // [-10; 10)        
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        MakeEachSecondAbsolute(array);

        Console.WriteLine("После замены каждого второго элемента на модуль:");
        PrintArray(array);

        double rootOfSumSquares = RootOfSumOfSquares(array);
        Console.WriteLine($"Кв. корень из суммы квадратов элементов: {rootOfSumSquares:F3}");

        Console.Write("Введите целое k для функции sin(kx): ");
        int k = int.Parse(Console.ReadLine());

        double[] sinValues = GetSinArray(array, k);

        Console.WriteLine("Массив значений sin(kx):");
        PrintArray(sinValues);
    }

    static void PrintArray(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]:F3} ");
        }
        Console.WriteLine();
    }

    static void MakeEachSecondAbsolute(double[] arr)
    {
        for (int i = 1; i < arr.Length; i += 2)
        {
            arr[i] = Math.Abs(arr[i]);
        }
    }

    static double RootOfSumOfSquares(double[] arr)
    {
        double sum = 0.0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i] * arr[i];
        }

        return Math.Sqrt(sum);
    }

    static double[] GetSinArray(double[] arr, int k)
    {
        double[] result = new double[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = Math.Sin(k * arr[i]);
        }

        return result;
    }
}