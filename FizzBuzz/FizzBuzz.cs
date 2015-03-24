using System;

namespace FizzBuzz
{
  public class GameClass
  {
    private string shout;

    public void DivisibleBy15 (int num)
    {
      if (num % 15 == 0) {
	    shout = "FizzBuzz";
	  }
    }
	
    public void DivisibleBy5 (int num)
    {
	  if (num % 5 == 0) {
	    shout = "Buzz";
	  }
    }

    public void DivisibleBy3 (int num)
    {
      if (num % 3 == 0) {
	    shout = "Fizz";
	  }
    }

    public string Shout
    {
      get { return shout; }
    }

  }
}

