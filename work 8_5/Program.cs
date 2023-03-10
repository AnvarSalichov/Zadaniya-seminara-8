// Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] array = new int[4, 4];          // Задаем матрицу нужной размерности
                                        // Заполняем матрицу числами от 1 до 16 по спирали
int n = 1;
for (int i = 0; i < 4; i++)
{
    array[0, i] = n;
    n++;
}
for (int j = 1; j < 4; j++)
{
    array[j, 3] = n;
    n++;
}
for (int i = 2; i >= 0; i--)
{
    array[3, i] = n;
    n++;
}
for (int j = 2; j > 0; j--)
{
    array[j, 0] = n;
    n++;
}
for (int i = 1; i < 2; i++)
{
    array[1, i] = n;
    n++;
}
for (int j = 1; j <= 2; j++)
{
    array[j, 2] = n;
    n++;
}
array[2, 1] = n;


void PrintMatrix(int[,] arr)               // создаем метод печати массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]+ " ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(array);               // Выводим на печать массив 