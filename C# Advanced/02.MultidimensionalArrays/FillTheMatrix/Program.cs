namespace FillTheMatrix
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counter = 1;

            switch (symbol)
            {
                case 'a':
                    {
                        for (int cols = 0; cols < n; cols++)
                        {
                            for (int rows = 0; rows < n; rows++)
                            {
                                matrix[rows, cols] = counter++;
                            }
                        }

                        PrintMatrix(matrix, n);
                    }
                    break;
                case 'b':
                    {
                        int currentCounter = 0;

                        for (int cols = 0; cols < n; cols++)
                        {
                            for (int rows = 0; rows < n; rows++)
                            {
                                if (cols % 2 == 0)
                                {
                                    matrix[rows, cols] = counter;
                                    counter++;
                                }
                                else
                                {
                                    matrix[rows, cols] = --counter;
                                }
                            }

                            if (cols % 2 == 0)
                            {
                                currentCounter = counter;
                                currentCounter += n;
                                counter = currentCounter;
                            }
                            else
                            {
                                counter = currentCounter;
                            }
                        }

                        PrintMatrix(matrix, n);
                    }
                    break;
                case 'c':
                    {
                        for (int i = n - 1; i >= 0; i--)
                        {
                            int row = i;
                            int col = 0;
                            do
                            {
                                matrix[row, col] = counter;
                                col++;
                                row++;
                                counter++;
                            } while (row < n);
                        }

                        for (int i = 1; i < n; i++)
                        {
                            int col = i;
                            int row = 0;
                            do
                            {
                                matrix[row, col] = counter;
                                col++;
                                row++;
                                counter++;
                            } while (col < n);
                        }

                        PrintMatrix(matrix, n);
                    }
                    break;
                case 'd':
                    {
                        int leftColumn = 0;
                        int rightColumn = n - 1;
                        int upperRow = 0;
                        int bottomRow = n - 1;
                        int count = 1;
                        do
                        {
                            for (int i = upperRow; i <= bottomRow; i++)
                            {
                                matrix[i, leftColumn] = count;
                                count++;
                            }
                            leftColumn++;

                            for (int i = leftColumn; i <= rightColumn; i++)
                            {
                                matrix[bottomRow, i] = count;
                                count++;
                            }

                            bottomRow--;
                            for (int i = bottomRow; i >= upperRow; i--)
                            {
                                matrix[i, rightColumn] = count;
                                count++;
                            }
                            rightColumn--;
                            for (int i = rightColumn; i >= leftColumn; i--)
                            {
                                matrix[upperRow, i] = count;
                                count++;
                            }
                            upperRow++;
                        } while (count <= n * n);

                        PrintMatrix(matrix, n);
                    }
                    break;
                default:
                    break;
            }
        }

        public static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j != n - 1)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j]);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
