using System;
using System.Linq;

namespace Homework_S1_1;

public static class Program 
{         
    public static void Main()
    {
		int numberA = 5;
		int numberB = 7;
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
		
		int numberA1 = 2;
		int numberB1 = 9;
		if (numberA>numberB)
		{
            Console.Write("Большее число = ");
		    Console.WriteLine(numberA1);
		}
		else
		{
		Console.Write("Большее число = ");
		Console.WriteLine(numberB1);
        }
		Console.WriteLine("Нажмите любую кнопку для продолжения ");
		Console.ReadKey(true);
	
		int numberA2 = -9;
		int numberB2 = -3;
		if (numberA>numberB)
		{
            Console.Write("Большее число = ");
		    Console.WriteLine(numberA2);
		}
		else
		{
		Console.Write("Большее число = ");
		Console.WriteLine(numberB2);
        }
		Console.WriteLine("Нажмите любую кнопку для продолжения ");
		Console.ReadKey(true);
	int[]array = { 2, 3, 7};
	 int max = 0;
	 for (int count=0;count<array.Length; count++)
	{
		if (array[count]>max);
		max = array[count];
	}
    Console.Write("Максимальнон число = ");
	Console.WriteLine(max);
	Console.WriteLine("Нажмите любую кнопку для продолжения ");
	Console.ReadKey(true);
	int[]array1 = { 44, 5, 78};
	int max1 = 0;
	int count1 = 0;
	while (count1<array1.Length)
	{
	    if (max1<array1[count1])
		{
	        max1 = array1[count1];
		    count1++;
		}
		else 
		{
		    count1++;
		}
	}
	Console.Write("Максимальнон число = ");
	Console.WriteLine(max1);
	Console.WriteLine("Нажмите любую кнопку для продолжения ");
	Console.ReadKey(true);
	int[]array2 = { 22, 3, 9};
	int max2 = int.MinValue;
	foreach(int num in array2)
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
		if (numD1 < (numD - 2))
		{
			Console.Write($", ");
		}
		else
		{
			Console.Write($".");
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