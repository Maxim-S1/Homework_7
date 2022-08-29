// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Write("Введите число строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение интервала: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение интервала: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, a, b);
PrintMatrix(ourMatrix);

Console.Write("Введите номер строки: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int N = Convert.ToInt32(Console.ReadLine());
NumberSearch(ourMatrix);

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void NumberSearch(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == M && j == N) Console.WriteLine($"Искомое число: {matrix[i, j]}");
        }
    }
   if(M >= matrix.GetLength(0) | M < 0 | N >=  matrix.GetLength(1) | N < 0) 
   Console.WriteLine($"Такого числа в массиве нет");
}