using NUnit.Framework;
using System;

namespace FizzBuzz
{
  [TestFixture]
    public class GameClassTest
    { 

      [Test ()]

      public void DivisibleBy15()
      {
	    GameClass number = new GameClass ();
	    number.DivisibleBy15 (15);
		Assert.IsTrue(number.Divisible);
      }
	}
}
