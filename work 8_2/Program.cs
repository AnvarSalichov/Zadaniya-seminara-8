// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];  

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); //[1;10)
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


int SumNum(int[,] array)                 
{
    int rowsMin = 0;
    int sumMin = Int32.MaxValue;
    
    for (int i = 0; i < array.GetLength(0); i++)   // цикл-cчетчик по количеству строк массива
    {  
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if (sum < sumMin) 
        {
            sumMin = sum;
            rowsMin = i;
        }  
    Console.WriteLine("Cумма элементов строки "+i+": "+sum);
    }
return rowsMin;
}

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Номер строки с наименьшей суммой элементов: "+SumNum(matrix));
