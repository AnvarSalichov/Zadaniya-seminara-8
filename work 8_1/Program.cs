// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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

// void SelectionSort(int[,] array)     
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int k = 0; k < array.GetLength(1) - 1; k++)   
//         {
//             for (int j = 0; j < array.GetLength(1) - 1; j++)
//             {
//                 if (array[i, j] < array[i, j + 1])
//                 {
//                     int temp = array[i, j+1];
//                     array[i, j + 1] = array[i, j];
//                     array[i, j] = temp;
//                 }
//             }
//         }
//     }
// }

void SelectionSort(int[,] array)                 
{
    for (int i = 0; i < array.GetLength(0); i++)   // цикл-cчетчик по количеству строк массива
    {
        for (int m = 0; m < array.GetLength(1) - 1; m++)  //цикл-счетчик вдоль строки по количеству столбцов массива, уменьшенному на 1 (из-за int maxPosition = m ) 
        {
        int maxPosition = m;
        for (int n = m + 1; n < array.GetLength(1); n++)   // цикл-счетчик для проверки задаваемого условия по количеству столбцов массива (элементов строки) 
        {
            if(array[i,n] > array[i,maxPosition])    // задаваемое условие (в данном случае сравнение на определение большего значения)
            {
                maxPosition = n;                     // определение индекса  элемента в строке с максимальным значением в проверяемой строке (определение номера его столбца)
            }
        }
        int temporary = array[i,m];          // введение временной переменной для перестановки элементов массива (с внесением в эту переменную элемента строки i с индексом m)
        array[i,m] = array[i,maxPosition];   // перестановка элемента с максимальным значением в строке на начальную позицию m
        array[i,maxPosition] = temporary;   // перестановка элемента из временной переменной на освободившуюся позицию с индексом maxPosition
        }   
    }
}

Console.WriteLine("Массив с рандомными числами: ");
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Отсортированный массив: ");
SelectionSort(matrix);
PrintArray(matrix);