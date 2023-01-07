// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите параметры трехмерного массива");
Console.WriteLine("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число z: ");
int z = Convert.ToInt32(Console.ReadLine());

if ((x * y * z) > 90)                               //Проверка на двузначность для координат (от 10 до 99)
{
    Console.WriteLine("В таком массиве часть элементов будут иметь трехзначные координаты, введите иные параметры");
    return;
}

int[,,] ArrayThree = new int[x, y, z];            // Задаем трехмерный массив
int n = 10;
for (int i = 0; i < ArrayThree.GetLength(0); i++)   // параметр x
{
    for (int j = 0; j < ArrayThree.GetLength(1); j++)    // параметр y
    {
        for (int k = 0; k < ArrayThree.GetLength(2); k++)   // параметр z
        {
            ArrayThree[i, j, k] = n;                       //заполняем элементы массива значениями от 10 (до 99)
            n++;
            Console.Write($"{ArrayThree[i, j, k]}({i},{j},{k}) ");   // Выводим на печать трехмерный массив
        }
    }
}

