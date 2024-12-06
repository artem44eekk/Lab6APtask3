using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6APtask3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rows = 7;
            int cols = 5;

            int[,] matrix = new int[rows, cols];

            FillMatrix(matrix);
            Console.WriteLine("Generated Matrix:");
            PrintMatrix(matrix);

            int minColumnIndex;
            int minElement = FindMinElementByColumn(matrix, out minColumnIndex);

            Console.WriteLine($"\nColumn with the smallest absolute element: {minColumnIndex}");
            Console.WriteLine($"Smallest absolute element: {minElement}");
        }

        static void FillMatrix(int[,] matrix)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-100, 101);
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        static int FindMinElementByColumn(int[,] matrix, out int minColumnIndex)
        {
            int minElement = int.MaxValue;
            minColumnIndex = -1;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (Math.Abs(matrix[i, j]) < Math.Abs(minElement))
                    {
                        minElement = matrix[i, j];
                        minColumnIndex = j;
                    }
                }
            }

            return minElement;
        }
    }
}
