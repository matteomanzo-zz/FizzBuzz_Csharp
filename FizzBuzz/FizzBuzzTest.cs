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
			number.IsDivisibleBy15 (45);
			Assert.IsTrue(45 % 15 == 0);
			Assert.IsFalse (45 % 15 != 0);
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
