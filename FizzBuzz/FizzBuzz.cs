using System;

namespace FizzBuzz
{
	public class GameClass
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
	

		public string Main (int num)
		{
			if (IsDivisibleBy15 (num)) {
				return say = "FizzBuzz";
			} else {
				return say = num.ToString();
			}
		}
	}
}

