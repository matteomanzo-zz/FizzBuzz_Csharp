using System;

namespace FizzBuzz
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Program program = new Program ();
			int num = program.ReceiveInput ();
			program.WriteResult (num);
		}

		public int ReceiveInput()
		{
			Console.WriteLine ("Type a number");
			string input = Console.ReadLine ();
			int num = Convert.ToInt32 (input);
			return num;
		}

		public void WriteResult(int num)
		{
			FizzBuzz fizzbuzz = new FizzBuzz ();
			Console.WriteLine (fizzbuzz.Shout (num));
		}
	}
}
