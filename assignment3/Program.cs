using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();

            int nrOfRows = 4; //int.Parse(args[0]);
            int nrOfColumns = 7; //int.Parse(args[1]);

            myProgram.Start(nrOfRows, nrOfColumns);
        }

        void Start(int nrOfRows, int nrOfColumns)
        {
            RegularCandies[,] playingField = new RegularCandies[nrOfRows, nrOfColumns];

            InitCandies(playingField);
            DisplayCandies(playingField);
            bool scoreRow = ScoreRowPresent(playingField);
            if(scoreRow == true)
            {
                Console.WriteLine("row score");
            }
            else
            {
                Console.WriteLine("no row score");
            }

            bool scoreCol = ScoreColumnPresent(playingField);
            if (scoreRow == true)
            {
                Console.WriteLine("column score");
            }
            else
            {
                Console.WriteLine("no column score");
            }
        }

        void InitCandies(RegularCandies[,] playingField)
        {
            Random Rnd = new Random();
            for (int r = 0; r < playingField.GetLength(0); r++)
            {
                for (int c = 0; c < playingField.GetLength(1); c++)
                {
                    int number = Rnd.Next(1, Enum.GetValues(typeof(RegularCandies)).Length);
                    playingField[r, c] = (RegularCandies)number;
                }
            }
        }

        void DisplayCandies(RegularCandies[,] playingField)
        {
            for (int r = 0; r < playingField.GetLength(0); r++)
            {
                for (int c = 0; c < playingField.GetLength(1); c++)
                {
                    switch (playingField[r, c])
                    {
                        case RegularCandies.Jellybean:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("# ");
                            Console.ResetColor();
                            break;
                        case RegularCandies.Lozenge:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("# ");
                            Console.ResetColor();
                            break;
                        case RegularCandies.LemonDrop:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("# ");
                            Console.ResetColor();
                            break;
                        case RegularCandies.GumSquare:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("# ");
                            Console.ResetColor();
                            break;
                        case RegularCandies.LollipopHead:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("# ");
                            Console.ResetColor();
                            break;
                        case RegularCandies.JujubeCluster:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("# ");
                            Console.ResetColor();
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
        bool ScoreRowPresent(RegularCandies[,] playingField)
        {
            for (int r = 0; r < playingField.GetLength(0); r++)
            {
                int counter = 1;
                
                for (int c = 0; c < playingField.GetLength(1); c++)
                {
                    if (c != 0)
                    {
                        RegularCandies curCandy = playingField[r, c - 1];
                        
                        if (curCandy == playingField[r, c])
                        {
                            counter++;
                        }
                        else
                        {
                            counter = 1;
                            curCandy = playingField[r, c];
                        }
                    }
                    if (counter >= 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool ScoreColumnPresent(RegularCandies[,] playingField)
        {

        for (int c = 0; c < playingField.GetLength(1); c++)
            {
                int counter1 = 1;
                Console.WriteLine("");

                for (int r = 0; r < playingField.GetLength(0); r++)
                {
                    Console.Write(playingField[r, c]);
                    RegularCandies curCandy = playingField[r, c];

                    if(curCandy == playingField[r, c])
                    {
                        counter1++;
                    }
                    else
                    {
                        counter1 = 1;
                        curCandy = playingField[r, c];
                    }

                    Console.WriteLine(curCandy);
                    Console.WriteLine(counter1++);
                }
            }
            return false;
        }
    }
}
