// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание,
//   что такого элемента нет.
// ​Например, задан массив:
// ​1 4 7 2​
// 5 9 2 3​
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

 int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,]RandomMassive(int rows,int colums,int leftrange,int rightrange)
{
    int[,]matrix = new int[rows,colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(leftrange,rightrange); 
        }
    }
    return matrix;
}

void Print(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write( matrix[i,j]+" ");
        }
        Console.WriteLine();
    }

}

int ROWS =new Random().Next(5,11);
int COLUMS =new Random().Next(5,11);
const int LEFT_RANGE =0;
const int RIGHT_RANGE =10;

int[,]array=RandomMassive(ROWS,COLUMS,LEFT_RANGE,RIGHT_RANGE);
Print(array);

int ROW=ReadNumber("Введите строку элемента");
int COLUM=ReadNumber("Введите столбец элемента");
if (ROW>ROWS || ROW<=0|| COLUMS>COLUM || COLUMS<=0)
{
    Console.WriteLine("Такого адреса не существует");
}
else
{
Console.WriteLine("Число под этим адресом");
Console.WriteLine(array[ROW-1,COLUM-1]);
}
