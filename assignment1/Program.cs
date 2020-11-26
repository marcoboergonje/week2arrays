using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[1-3] <nrOfRows> <nrOfColumns>");
                return;
            }
   
            int nrOfRows = int.Parse(args[0]);
            int nrOfColumns = int.Parse(args[1]);

            Program myProgram = new Program();
            myProgram.Start(nrOfRows, nrOfColumns);
        }

        void Start(int nrOfRows, int nrOfColumns)
        {
            int[,] matrix = new int[nrOfRows, nrOfColumns];
            //InitMatrix2D(matrix);
            //DisplayMatrix(matrix);
            InitMatrixLinear(matrix);
            DisplayMatrixWithCross(matrix);
        }

        void InitMatrix2D(int[,] matrix)
        {
            int number = 0;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    number++;
                    matrix[r, c] = number;
                }
            }
        }

        void DisplayMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("{0, 3} ", matrix[r, c]);
                }
                Console.WriteLine();
            }
        }

        void InitMatrixLinear(int[,] matrix)
        {
            for (int i = 0; i < (matrix.GetLength(0) * matrix.GetLength(1)); i++)
            {
                matrix[i / matrix.GetLength(1), i % matrix.GetLength(1)] = i + 1;
            }
        }

        void DisplayMatrixWithCross(int[,] matrix)
        {
            int rowCount = 0;
            int colCount = matrix.GetLength(1) - 1;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (c == rowCount && c == colCount)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0, 3} ", matrix[r, c]);
                        Console.ResetColor();
                    }
                    else if (c == rowCount)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0, 3} ", matrix[r, c]);
                        Console.ResetColor();
                    }
                    else if (c == colCount)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write("{0, 3} ", matrix[r, c]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("{0, 3} ", matrix[r, c]);
                    }
                }
                rowCount++;
                colCount--;
                Console.WriteLine();
            }
        }
    }
}
