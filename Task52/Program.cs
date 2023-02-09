/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        
            matrix[i,j] = rnd.Next(0, 10);
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
            Console.Write($"{matrix[i,j]} ");
        }

    Console.WriteLine();
    }
}

double[] AverageOfColumn(int[,] matrix)
{
    double[] averageMeanings = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average += matrix[i,j];
        }
        averageMeanings[j] = average / matrix.GetLength(0);
    }
    return averageMeanings;
}

void PrintArr(double[] arr)
{
    for (int i=0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]:f2}; ");
    }
    Console.WriteLine();
}

var m = 3;
var n =4;
int[,] matrix = InitMatrix(m, n);
Console.WriteLine ("Задан массив:");
PrintMatrix(matrix);
double[] averageOfColumns = AverageOfColumn(matrix);
Console.WriteLine("Среднее арифмметическое каждого столбца:");
PrintArr(averageOfColumns);

    
