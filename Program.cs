﻿using System;
using System.Linq;

namespace Homework_S1_1;

public static class Program 
{         
    public static void Main()
    {
		// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
		Console.WriteLine("Введите число A ");
		int numberA = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Введите число B ");
		int numberB = Convert.ToInt32(Console.ReadLine());
		if (numberA>numberB)
		{
            Console.Write("Большее число = ");
		    Console.WriteLine(numberA);
		}
		else
		{
		Console.Write("Большее число = ");
		Console.WriteLine(numberB);
        }
		Console.WriteLine("Нажмите любую кнопку для продолжения ");
		Console.ReadKey(true);

	Console.WriteLine("Введите 3 числа ");
	int[] array = new int[3];
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine(string.Format("Введите {0}й элемент массива:",i+1));
   		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	int max2 = int.MinValue;
	foreach(int num in array)
	{
		if(num>max2)
		{
			max2=num;
		}
	}
	Console.Write("Максимальнон число = ");
	Console.WriteLine(max2);
	Console.WriteLine("Нажмите любую кнопку для продолжения ");
	Console.ReadKey(true);

	Console.WriteLine("Введите число ");
	int numC = Convert.ToInt32(Console.ReadLine());
	if(numC % 2 == 0)
	{
		Console.WriteLine($"*Звуки победного марша мышат*");
	}
	else 
	{
		Console.WriteLine($"*Звуки грустного трамбона*");
	}

	Console.WriteLine("Введите число ");
	int numD = Convert.ToInt32(Console.ReadLine());
	int numD1 = 1;
	while (numD1<=numD)
	{
		if (numD1 % 2 == 0)
		{
		Console.Write(numD1);
		if (numD1 != numD)
		{
			Console.Write($", ");
		}
		else
		{
			Console.Write($" ");
		}
		numD1++;
		}
		else 
		{
                numD1++;
            }
	}
    }
}