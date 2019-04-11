using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    class Program
    {
        int[,] matrix1;
        int[,] matrix2;
        int[,] resultMatrix;

        int m;
        int n;
        int p;
        int[,] dimArr = new int[2, 2];
        
        static void Main(string[] args)
        {
            
        }
        
        public void AssignDimArr()
        {
            dimArr = new int[,] { { m, n }, { n, p } };
        }

        public int [,] GiveMatrix(int a, int b)
        {
            int[,] matrix = new int [a, b];
            return matrix;
        }

        public void InputDim()
        {
            string dim;
            string matrixNum;
            for (int i=0; i<2; i++)
            {
                matrixNum = (i == 0) ? "1" : "2";
                for (int j=0; i<2; i++)
                {
                    dim = (j == 0) ? "rows" : "column";
                    Console.WriteLine("Input the number of " + dim + " of matrix " + matrixNum);
                    dimArr[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void InputEle(int a, int b)
        {
            for (int i = 0; i<a; i++)
            {
                for (int j = 0; j<b; j++)
                {
                    Console.WriteLine("Input the " + i.ToString() + j.ToString() + " element of the matrix");
                }
            }
        }
    }
}
