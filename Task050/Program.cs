// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

Console.Clear();

Console.Write("Введите число для поиска в массиве: "); // Поиск по числу
int number = int.Parse(Console.ReadLine());

// Console.Write("Введите координаты элемента, индекс строки массива (от 0): "); // Поиск по индексу
// int row = int.Parse(Console.ReadLine());

// Console.Write("Введите координаты элемента, индекс столбца массива (от 0): ");
// int column = int.Parse(Console.ReadLine());

int rows = 5;
int columns = 5;

int[,] array = GetArray(rows, columns);

PrintArray(array);

Console.WriteLine(); //Отступ

arrayElement(array, number);

// arrayElement(array, row, column, rows, columns); // Поиск по индексу

int[,] GetArray(int M, int N)
{
    int[,] result = new int[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            result[i, j] = new Random().Next(-9, 10); // Диапазон задан функцией
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

// void arrayElement(int[,] N, int A, int B, int C, int D) // Поиск по индексу
// {
//     if (A < C && B < D)
//     {
//         Console.Write($"Значение заданного элемента: {N[A, B]} ");
//     }
//     else
//     {
//         Console.Write($"Введены координаты за пределами массива "); 
//     }
// }

void arrayElement(int[,] N, int A) // Поиск по числу
{
    for (int i = 0; i < N.GetLength(0); i++)
    {
        for (int j = 0; j < N.GetLength(1); j++)
        {
            if (N[i, j] == A)
            {
                Console.Write($"Индекс числа (строка, столбец): {i}, {j} ");
                return;
            }
        }
    }
    Console.Write($"Указанное число отсутствует в массиве ");
}