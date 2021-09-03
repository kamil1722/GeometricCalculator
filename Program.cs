//R - Радиус круга , для вычисления площади по формуле S = PI * R^2
//Нахожу площадь треугольника по формуле Герона S = sqrt(p*(p-a)*(p-b)*(p-c)), где p-полуперметр треугольника, a,b,c - его стороны
//+ проверка на то , что треугольник прямоугольный по теореме Пифагора(a^2=b^2+c^2)
using System;
using System.Linq;

public class Program
{
	public static double CircleCalculate(double R)
	{
		return Math.Pow(R, 2) * Math.PI;
	}
	public static string TriangleCalculate(double a, double b, double c, double S, string text)
	{
		string s1 = null;
		double P = 0.5 * (a + b + c);
		double[] SidesTriangle = new double[3] { a, b, c };
		double maxValue = SidesTriangle.Max();
		if (Math.Pow(maxValue, 2) == a * a + b * b || Math.Pow(maxValue, 2) == c * c + b * b || Math.Pow(maxValue, 2) == a * a + c * c)
		{
			return (Math.Sqrt(P * (P - a) * (P - b) * (P - c)) + " - треугольник прямоугольный");
		}
		else
		{
			return (Math.Sqrt(P * (P - a) * (P - b) * (P - c)) + s1);
		}
	}
	public static void Main()
	{
		Console.WriteLine("Введите радиус окружности:");
		Console.WriteLine("Площадь круга: " + (CircleCalculate(double.Parse(Console.ReadLine()))) + "\n");

		Console.WriteLine("Введите стророны треугольника:");
		Console.WriteLine("Площадь треугольника: " + TriangleCalculate((double.Parse(Console.ReadLine())),
											double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), 0, "0"));

	}
}