using System;

namespace FizzBuzz
{
	public class FizzBuzz
	{
		public bool IsDivisibleBy15 (int num)
		{
			return (num % 15 == 0) ? true : false;
		}

		public bool IsDivisibleBy5 (int num)
		{
			return (num % 5 == 0) ? true : false;
		}

		public bool IsDivisibleBy3 (int num)
		{
			return (num % 3 == 0) ? true : false;
		}

		public string Shout (int num)
		{
			string say = (IsDivisibleBy15 (num)) ? "FizzBuzz"
				: (IsDivisibleBy5 (num)) ? "Buzz"
				: (IsDivisibleBy3 (num)) ? "Fizz"
				: num.ToString ();
			return say;
		}
	}
}

