using System;
using System.Threading;

namespace MatrixMultiplication
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] dimArr = GetDim();
            int[,] matrix1 = GetMatrix(dimArr[0], dimArr[1], 1);
            int[,] matrix2 = GetMatrix(dimArr[1], dimArr[2], 2);
            int[,] resultMatrix = Multiply(matrix1, matrix2, dimArr);
            WriteMatrix(resultMatrix);
            Thread.Sleep(10000000);
        }
     
        public static int[] GetDim()
        {
            int[] dimArr = new int[3];
            Console.WriteLine("Input the number of rows of the first matrix");
            dimArr[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the number of columns of the first matrix or rows of second matrix");
            dimArr[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the number of columns of the second matrix");
            dimArr[2] = int.Parse(Console.ReadLine());
            return dimArr;
        }

        public static int[,] GetMatrix(int a, int b, int num)
        {
            int[,] matrix = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine("Input the " + (i+1).ToString() + (j+1).ToString() + " element of matrix" + num.ToString());
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }

        public static int[,] Multiply(int[,] matrix1, int[,] matrix2, int[] dimArr)
        {
            int[,] resultMatrix = new int[dimArr[0], dimArr[2]];
            for (int i = 0; i < dimArr[0]; i++)
            {
                for (int j = 0; j < dimArr[2]; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < dimArr[1]; k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return resultMatrix;
        }

        public static void WriteMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString()+ "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
