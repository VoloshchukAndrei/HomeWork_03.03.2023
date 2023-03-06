// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите координаты элемента, индекс строки массива (от 0): ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите координаты элемента, индекс столбца массива (от 0): ");
int column = int.Parse(Console.ReadLine());

int rows = 5;
int columns = 5;

int[,] array = GetArray(rows, columns);

PrintArray(array);

Console.WriteLine(); //Отступ

arrayElement(array, row, column, rows, columns);

int[,] GetArray(int M, int N)
{
    int[,] result = new int[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            result[i, j] = new Random().Next(-9, 10);
        }
    }
    return result;
}

void PrintArray(int[,] N)
{
    for (int i = 0; i < N.GetLength(0); i++)
    {
        for (int j = 0; j < N.GetLength(1); j++)
        {
            Console.Write($"{N[i,j]} ");
        }
        Console.WriteLine();
    }
}

void arrayElement(int[,] N, int A, int B, int C, int D)
{
    if (A < C && B < D)
    {
        Console.Write($"Значение заданного элемента: {N[A, B]} ");
    }
    else
    {
        Console.Write($"Введены координаты за пределами массива "); 
    }
}