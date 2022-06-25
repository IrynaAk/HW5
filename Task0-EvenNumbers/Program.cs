// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using System;
using static System.Console;
Clear();

WriteLine("Please type array's size");
int arrSize = Convert.ToInt32(ReadLine());

int[] myArray = GetArray(arrSize);
WriteLine($"[{String.Join(", ", myArray)}]");
WriteLine();
WriteLine($"Even numbers amount: {EvenNumbers(myArray)}");


int[] GetArray(int size)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int EvenNumbers (int[] arrEven)
{
    int number =0;
    for (int j = 0; j < arrEven.Length; j++)
    {
        if(arrEven[j]%2 == 0){number++;}
    }
    return number;
}
