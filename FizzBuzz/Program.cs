using System;

namespace FizzBuzz
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Type a number")
			string input = Console.ReadLine ();
			int num = Convert.ToInt32 (input);
			FizzBuzz fizzbuzz = new FizzBuzz ();
			Console.WriteLine (fizzbuzz.Shout (num));
		}
	}
}
