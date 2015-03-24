using System;

namespace FizzBuzz
{
	public class GameClass
	{
		private string shout;

		public void Game (int num)
		{
			if (num % 15 == 0)
			{
				shout = "FizzBuzz";
			}
		}

		public string Shout
		{
			get { return shout; }
		}

	}
}

