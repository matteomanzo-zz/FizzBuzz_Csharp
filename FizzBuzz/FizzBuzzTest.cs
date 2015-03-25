using NUnit.Framework;
using System;

namespace FizzBuzz
{
	[TestFixture]
	public class GameClassTest
	{ 
		[Test()]
		public void IsDivisibleBy15()
		{
			GameClass number = new GameClass ();
			Assert.IsTrue(number.IsDivisibleBy15(45));
			Assert.IsFalse(number.IsDivisibleBy15(50));
		}
//
		[Test ()]
		public void Main()
		{
			GameClass number = new GameClass ();
			number.Main (30);
			Assert.AreEqual("FizzBuzz", number.say);
		}
	}
}
