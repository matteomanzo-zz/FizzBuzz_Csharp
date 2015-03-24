using NUnit.Framework;
using System;

namespace FizzBuzz
{
	[TestFixture]
	public class GameClassTest
	{
		[Test]
		public void DivisibleBy15()
		{
			GameClass number = new GameClass ();
			number.DivisibleBy15 (15);
			Assert.AreEqual ("FizzBuzz", number.Shout);
		}

		[Test]
		public void DivisibleBy5()
		{
			GameClass number = new GameClass();
			number.DivisibleBy5 (5);
			Assert.AreEqual ("Buzz", number.Shout);
		}
	}
}
