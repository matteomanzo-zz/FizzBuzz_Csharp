using System;

namespace FizzBuzz
{
	public class Game
	{
		public static void Main (string[] args)
		{	
			string userInput = Console.ReadLine();
			int num = int.Parse (userInput);
			FizzBuzz logic = new FizzBuzz ();
			string result = logic.Shout (num);
			Console.WriteLine(result);

		}
	}
}

