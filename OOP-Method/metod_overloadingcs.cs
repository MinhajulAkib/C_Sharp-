using System;


public class Class1
{
	static int PlusMethodInt(int x, int y)
	{
		return x + y;
	}

	static double PlusMethodDouble(double x, double y)
	{
		return x + y;
	}
	public Class1()
	{
		int myNum1 = PlusMethodInt(8, 5);
		double myNum2 = PlusMethodDouble(4.3, 6.26);
		Console.WriteLine("Int: " + myNum1);
		Console.WriteLine("Double: " + myNum2);
	}
}
