// // Задача 54: Задайте двумерный массив. Напишите программу, 
// // которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 10);
//         }
//     }
//     return matrix;
// }

// void printMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void DescendingSorting(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     int temp = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// int rows = ReadInt("введите количество строк в матрице: ");
// int cols = ReadInt("введите количество столбцов матрицы: ");
// System.Console.WriteLine();
// var myMatrix = GenerateMatrix(rows, cols);
// printMatrix(myMatrix);
// System.Console.WriteLine("Отсортированный по убыванию массив:");
// DescendingSorting(myMatrix);
// printMatrix(myMatrix);

// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// // которая будет находить строку с наименьшей суммой элементов.

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 10);
//         }
//     }
//     return matrix;
// }

// void printMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[] RowSums(int[,] matrix)
// {
//     int[] sums = new int[matrix.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int rowSum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             rowSum += matrix[i, j];
//         }
//         System.Console.WriteLine($"сумма элементов строки {i + 1} равна {rowSum}");
//         sums[i] = rowSum;
//     }
//     return sums;
// }

// void MinRowSum(int[] array)
// {
//     int minSum = array[0];
//     int rowCount = 1;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (minSum > array[i])
//         {
//             minSum = array[i];
//             rowCount = i+1;
//         }
//     }
//     System.Console.WriteLine($"строка {rowCount} содержит наименьшую сумму элементов - {minSum}");
//  }       


// System.Console.WriteLine();
// int rows = ReadInt("введите количество строк в матрице: ");
// int cols = ReadInt("введите количество столбцов матрицы: ");
// System.Console.WriteLine();
// var myMatrix = GenerateMatrix(rows, cols);
// printMatrix(myMatrix);
// System.Console.WriteLine();
// MinRowSum(RowSums(myMatrix));


// Задача 62: Заполните спирально массив.
// 1   2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]} " + "\t");
        }
        Console.WriteLine();
    }
}

int[,] SquareMatrix(int rows, int cols)
{

    int[,] squareMatrix = new int[rows, cols];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
    {
        squareMatrix[i, j] = temp;
        if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
        temp++;
    }
    return squareMatrix;
}
int rows = ReadInt("введите количество строк в матрице: ");
int cols = ReadInt("введите количество столбцов матрицы: ");

var myMatrix = SquareMatrix(rows, cols);
PrintMatrix(myMatrix);