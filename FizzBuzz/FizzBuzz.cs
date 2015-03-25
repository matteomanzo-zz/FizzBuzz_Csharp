using System;

namespace FizzBuzz
{
  public class GameClass
  {
    private bool divisible = false;

	public void DivisibleBy15 (int num)
    {
			if (num % 15 == 0) {
				divisible = true;
			} 
    }
	
		public bool Divisible {
			get { return divisible; }
		}

  }
}

