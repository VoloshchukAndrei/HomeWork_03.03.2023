// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] arrayTwoDim = GetArray(rows, columns);

PrintArrayOne(arrayTwoDim);

double[] arrayOneDim = AverageArithmetic(arrayTwoDim, rows, columns);

PrintArrayTow(arrayOneDim);

int[,] GetArray(int M, int N)
{
    int[,] result = new int[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArrayOne(int[,] N)
{
    for (int i = 0; i < N.GetLength(0); i++)
    {
        for (int j = 0; j < N.GetLength(1); j++)
        {
            Console.Write($"{N[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] AverageArithmetic(int[,] N, int A, int B)
{
    double[] result = new double[B];
    for (int j = 0; j < B; j++)
    {
        double sum = 0;
        for (int i = 0; i < A; i++)
        {
            sum += N[i, j];
        }
        result[j] = sum / A;
    }
    return result;
}

void PrintArrayTow(double[] N)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < N.Length; i++)
    {
        Console.Write($"{N[i]: 0.00}; ");
    }
}