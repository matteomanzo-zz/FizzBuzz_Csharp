using System;

namespace FizzBuzz
{
	public class FizzBuzz
	{
		public string say;

		public bool IsDivisibleBy15 (int num)
		{
			if (num % 15 == 0) {
				return true;
			} else {
				return false;
			}
		}

		public bool IsDivisibleBy5 (int num)
		{
			if (num % 5 == 0) {
				return true;
			} else {
				return false;
			}
		}

		public bool IsDivisibleBy3 (int num)
		{
			if (num % 3 == 0) {
				return true;
			} else {
				return false;
			}
		}

		public string Shout (int num)
		{
			if (IsDivisibleBy15 (num)) {
				return say = "FizzBuzz";
			} else if (IsDivisibleBy5 (num)) {
				return say = "Buzz";
			} else if (IsDivisibleBy3 (num)) {
				return say = "Fizz";
			} else {
				return say = num.ToString();
			}
		}
	}
}

