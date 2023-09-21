using System;
using System.Linq;
using CSharpShellCore;

namespace Homework__S1_2;

public static class Program
{
	public static void Main()
	{	
     int[]Array = { 2, 3, 7};
	 int Max = 0;
	 for (int count=0;count<Array.Length; count++)
	{
		if (Array[count]>Max);
		Max = Array[count];
	}
    Console.Write("Максимальнон число = ");
	Console.WriteLine(Max);
	}
}
