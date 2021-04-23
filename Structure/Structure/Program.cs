using System;

public class Program
{
	public static void Main()
	{
		Coordinate point;
		//Console.Write(point.x); // Compile time error  

		point.x = 10;
		point.y = 20;
		Console.Write(point.x); //output: 10  
		Console.Write(point.y);
	}
}

struct Coordinate
{
	public int x;
	public int y;
}
