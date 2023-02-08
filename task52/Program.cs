// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

        int[,] RandomMassive(int rows, int colums, int leftrange, int rightrange)
        {
            int[,] matrix = new int[rows, colums];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(leftrange, rightrange);
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
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        int ROWS = new Random().Next(4, 11);
        int COLUMS = new Random().Next(4, 11);
        const int LEFT_RANGE = 0;
        const int RIGHT_RANGE = 10;

        int[,] array = RandomMassive(ROWS, COLUMS, LEFT_RANGE, RIGHT_RANGE);
        PrintMatrix(array);

        double GetAverage(int[,] matrix, int J)
        {
            double result = 0;
            double count = 0;
            double Av;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result += matrix[i, J];
                count++;
            }
            Av= result / count;
            return Av;
        }
        double G=0;
        double Fin= GetAverage( array,G);

   
   System.Console.WriteLine();
    
// не соображу,как в конце вывести ((

