﻿// Задания на семинар 5:
// Задача 1: Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите суммы отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.



// Задача 2: Задайте массив из 10 элементов из промежутка [-9, 9] и положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]



// Задача 3: Задайте массив из 8 случайных чисел из промежутка [-9, 9]. Напишите программу получает на вход число и определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да



// Задача 4: Задайте массив из 10 случайных чисел из промежутка [-100, 100]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// *Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10*

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0

// [10, 11, 12, 13, 14] -> 5


//-----------2---------------

// int[] array = new int[10];
// Random Random = new Random();

// Console.WriteLine();
// Console.Write("[");

// for (int i = 0; i < array.Length; i++)
// {

//     array[i] = Random.Next(-9, 9);
//     Console.Write("  " + array[i] + "  ");

// }

// Console.WriteLine("]");
// Console.WriteLine();

// Console.Write("[");

// for (int i = 0; i < array.Length; i++)
// {


//     Console.Write("  " + -1*array[i] + "  ");

// }

// Console.WriteLine("]");
// Console.WriteLine();



//---------------4--------------------


// int[] array = new int[10];
// Random Random = new Random();

// int colElem = 0;

// Console.WriteLine();
// Console.Write("[");

// for (int i = 0; i < array.Length; i++)
// {

//     array[i] = Random.Next(-100, 101);
//     Console.Write("  " + array[i] + "  ");

//     if (array[i] >= 10 && array[i] <= 99)
//     {
//         colElem = colElem + 1;
//     }

// }
// Console.WriteLine("]");
// Console.WriteLine();
// Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99]: {colElem}");





//----------------1-----------------


// int[] array = new int[10];
// Random Random = new Random();

// int polSum = 0;
// int otrSum = 0;

// Console.WriteLine();
// Console.Write("[");

// for (int i = 0; i < array.Length; i++)
// {   
//     if (array[i] <= 8)
//     {
//         array[i] = Random.Next(-9, 9);
//         Console.Write("  " + array[i] + "  ");

//         if (array[i] > 0)  polSum = polSum + array[i];
//         if (array[i] < 0)  otrSum = otrSum + array[i];


//     }
// }
// Console.WriteLine("]");
// Console.WriteLine();
// Console.WriteLine(polSum);
// Console.WriteLine(otrSum);



//----------3---------

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// int[] array = new int[8];
// Random Random = new Random();



// Console.WriteLine();


// for (int i = 0; i < array.Length; i++)
// {   
//     if (array[i] <= 8)
//     {
//         array[i] = Random.Next(-9, 9);
//         Console.Write("  " + array[i] + "  ");

//         if (array[i] == number) Console.WriteLine("Да"); 


//         else Console.WriteLine("Нет");

//     }
// }

// Console.WriteLine();
