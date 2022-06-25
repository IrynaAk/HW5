//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


using System;
using static System.Console;
Clear();

WriteLine("Please type array's size:");
int arrSize = Convert.ToInt32(ReadLine());

WriteLine("Please type min value:");
int myArrMinVal = Convert.ToInt32(ReadLine());

WriteLine("Please type max value:");
int myArrMaxVall = Convert.ToInt32(ReadLine());

int[] myArray = GetArray(arrSize, myArrMinVal, myArrMaxVall);
WriteLine($"[{String.Join(", ", myArray)}]");
WriteLine();
WriteLine($"Odd elements sum: {SumElementsOnOddPositions(myArray)}");


int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue+1);
    }
    return result;
}

int SumElementsOnOddPositions(int[] arraySE)
{
    int sum = 0;
    for (int j = 1; j < arraySE.Length; j+=2)
    {
        sum += arraySE[j];
    }
    return sum;
}