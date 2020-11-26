using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();

            int nrOfRows = 8; //int.Parse(args[0]);
            int nrOfColumns = 10; //int.Parse(args[1]);

            myProgram.Start(nrOfRows, nrOfColumns);
        }

        void Start(int nrOfRows, int nrOfColumns)
        {
            int[,] matrix = new int[nrOfRows, nrOfColumns];
            int min = 1;
            int max = 99;
            int number = 0;

            InitMatrixRandom(matrix, min, max);
            DisplayMatrix(matrix);
            SearchNumber(matrix, number);

            //int inputNumber = SearchNumber("Enter a number (to search for): ");

        }

        void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            min = 1;
            max = 100;
            Random Rnd = new Random();
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    int number = Rnd.Next(min, max);
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

        void SearchNumber(int[,] matrix, int number)
        {
            Position pos;
            pos = new Position();
            pos.row = matrix.GetLength(0);
            pos.column = matrix.GetLength(1);

            Console.Write("\n");
            Console.Write("Enter a number (to search for): ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Number {number} is found at position [{pos.row},{pos.column}]");

            for(int c = 0; c < matrix.GetLength(1); c++)
            {
                if (c == number)
                {
                    pos.row = c;
                    Console.WriteLine($"{pos.row}");
                }
                else
                {
                    Console.WriteLine("het werkt niet!!");
                }
            }
            
            //for (int r = 0; r < matrix.GetLength(0); r++)
            //{
            //    for (int c = 0; c < matrix.GetLength(1); c++)
            //    {
            //        if(matrix[r,c] == number)
            //        {
            //            Console.WriteLine($"HET NUMMER IS GOED");
            //        }
            //        else
            //        {
            //            Console.WriteLine("het werkt niet");
            //        }
            //        break;
            //    }
            //    break;
            //}
        }
    }
}
