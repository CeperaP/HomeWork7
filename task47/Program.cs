﻿// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.
// ​m = 3, n = 4.
// ​0,5 7 -2 -0,2
// ​1 -3,3 8 -9,9
// ​8 7,8 -7,1 9

double[,]RandomMatrix(int rows,int colums,int leftrange,int rightrange)
{
    double[,]matrix=new double[rows,colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j= 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j]= Convert.ToDouble(new Random().Next(leftrange, rightrange)) / 10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        System.Console.WriteLine();
    }
}

const int ROWS =3;
const int COLUMS =4;
const int LEFT_RANGE =-10;
const int RIGHT_RANGE =10;

double [,]array=RandomMatrix(ROWS,COLUMS,LEFT_RANGE,RIGHT_RANGE);

PrintMatrix(array);