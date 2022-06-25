//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


using System;
using static System.Console;
Clear();

WriteLine("Please type array's size");
int arrSize = Convert.ToInt32(ReadLine());

WriteLine("Please type min value:");
int myArrMinVal = Convert.ToInt32(ReadLine());

WriteLine("Please type max value:");
int myArrMaxVall = Convert.ToInt32(ReadLine());

double[] myArray = GetArray(arrSize, myArrMinVal, myArrMaxVall);

WriteLine($"[{String.Join("; ", myArray)}]");

WriteLine();
WriteLine($"{FindDiff(myArray).ToString("F2")}");

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] result = new double [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }
    return result;
}

double FindDiff (double [] array)

{
    double diff =0;

    double min = 0;
    double max = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j]<min) {min = array[j];}
        if(array[j]>max) {max = array[j];}
    }
    diff = max - min;
    return diff;
}


