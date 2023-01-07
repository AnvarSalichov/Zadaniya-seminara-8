// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк матрицы №1");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы №1");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк матрицы №2");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы №2");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[rows1, columns1];  
int[,] matrix2 = new int[rows2, columns2];  

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);               //[1;10)
        }
    }
}

void PrintArray(int[,] array)               
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();

if (columns1 != rows2)                       // проверка на возможность умножения матриц
{
    Console.WriteLine("Эти матрицы перемножать нельзя, так как число столбцов матрицы № 1 должно быть равно числу строк матрицы № 2");
    return;
}

Console.WriteLine("Результ перемножения матриц: ");

int [,] matrix3 = new int[rows1, columns2];
{

    for ( int i = 0; i < rows1; i++)
        {
            for ( int j = 0; j < columns2; j++)
            {
                matrix3[i, j] = 0;

                for (int k = 0; k < columns1; k++) //
                {
                    matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
}


PrintArray(matrix3);
Console.WriteLine();