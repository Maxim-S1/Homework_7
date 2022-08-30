//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.


int[,] ourMatrix = GetMatrix(4, 4, 0, 15);
PrintMatrix(ourMatrix);
Console.WriteLine();
AverageSumNumbersInRows(ourMatrix);

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

double AverageSumNumbersInRows(int[,] matrix)
{
    double Sum = 0;
    double AverageSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
               
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            
            Sum = Sum + matrix[i, j];
            
        }
        
        Console.Write(Math.Round(AverageSum = Sum / 4, 2) + " ");
        Sum = 0;
        
    }
    
    return Sum;

}

