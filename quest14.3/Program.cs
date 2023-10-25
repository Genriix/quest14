using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы:");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов матрицы:");
            int cols = Convert.ToInt32(Console.ReadLine());

            MyMatrix matrix = new MyMatrix(rows, cols);

            matrix.FillMatrix();

            Console.WriteLine("Исходная матрица:");
            matrix.PrintMatrix();

            Console.WriteLine("Производные матрицы:");
            matrix.PrintDerivedMatrices();

            Console.ReadLine();
        }
    }

    class MyMatrix
    {
        private int[,] matrix;

        public MyMatrix(int rows, int cols)
        {
            matrix = new int[rows, cols];
        }

        public void FillMatrix()
        {
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }
        }

        public void PrintMatrix()
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

        public void PrintDerivedMatrices()
        {
            for (int i = matrix.GetLength(0); i > 0; i--)
            {
                int[,] derivedMatrix = new int[i, i];

                for (int j = 0; j < derivedMatrix.GetLength(0); j++)
                {
                    for (int k = 0; k < derivedMatrix.GetLength(1); k++)
                    {
                        derivedMatrix[j, k] = matrix[j, k];
                    }
                }

                Console.WriteLine($"Матрица порядка {i}:");
                for (int j = 0; j < derivedMatrix.GetLength(0); j++)
                {
                    for (int k = 0; k < derivedMatrix.GetLength(1); k++)
                    {
                        Console.Write(derivedMatrix[j, k] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
