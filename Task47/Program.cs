//Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите m ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] ourMatrix = GetMatrix(m, n, -100.0, 100.0);
PrintMatrix(ourMatrix);

double[,] GetMatrix(int rowsCount, int columnsCount, double leftRange, double rightRange)
{
    double[,] matrix = new double[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rightRange - leftRange) * rand.NextDouble() + leftRange, 1);
           
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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
