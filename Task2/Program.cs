﻿// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.
// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4

int[] array = new int[] {1, 13, 45, 23, 64, 20, 39, 90, 95, 47};
int count = 0;
foreach(int number in array)
{
    if(number % 2 == 0)
        count++;
} 
System.Console.WriteLine(count);