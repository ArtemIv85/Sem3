﻿// Задание 1. Совместная работа
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

using System.Data;

int[] array = { 1, 3, 4, 8, 3 };
int digit =8;
int result=0;
foreach (int i in array )
    {
        if (i == digit)
        {
            result=1;
        }
    }
if (result == 1)
{
    Console.WriteLine("ДА");
}
else 
{
    Console.WriteLine("Нет");
}

// Задание 2. Работа в сессионных залах
// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]
//*******************************************************************
// int[] array = { 1, 5, -9, 6, -7, 6, -1, -5, 3, 7 };

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = -array[i];
//     Console.Write($"{array[i]} ");
// }
// *******************************************************************

// Задание 3. Совместная работа
// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

// int[] array = { 2, 3, 1, 7, 5, 6, 3 };
// int N = array.Length / 2;
// int[] arrayOut = new int[N];
// for (int i = 0; i < N; i++)
// {
//     arrayOut[i] = array[i] * array[array.Length - 1 - i];
//     Console.Write($"{arrayOut[i]} ");
// }
// ***************************************************************

// Задание 4*. Совместная работа
// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

// int digit=781;
// string str=$"{digit}"; //Переводим число в строку, чтобы узнать разрядность числа
// int bitness=str.Length; // фиксируем рязряд числа для формирования размера массива
//  int[] array = new int[bitness]; //создаем массив с размером bitness
//  for (int i=0; i<bitness;i++)
//  {
//     array[i] = digit%10;  //Записываем в масив остаток от деления на 10
//     digit = digit/10;  // уменьшаем число диелнием на 10
//     Console.Write($"{array[i]} ");  // вывод элемента
//  }
//  ************************************************************