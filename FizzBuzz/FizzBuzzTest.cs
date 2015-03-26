using NUnit.Framework;
using System;

namespace FizzBuzz
{
	[TestFixture]
	public class FizzBuzzTest
	{ 
		[Test()]
		public void IsDivisibleBy15()
		{
			FizzBuzz number = new FizzBuzz ();
			Assert.IsTrue(number.IsDivisibleBy15(45));
			Assert.IsFalse(number.IsDivisibleBy15(50));
		}

		[Test()]
		public void IsDivisibleBy5()
		{
			FizzBuzz number = new FizzBuzz ();
			Assert.IsTrue(number.IsDivisibleBy5(10));
			Assert.IsFalse(number.IsDivisibleBy5(7));
		}

		[Test()]
		public void IsDivisibleBy3()
		{
			FizzBuzz number = new FizzBuzz ();
			Assert.IsTrue(number.IsDivisibleBy3(9));
			Assert.IsFalse(number.IsDivisibleBy3(5));
		}

		[Test ()]
		public void Shout()
		{
			FizzBuzz number = new FizzBuzz ();
			number.Shout (30);
			Assert.AreEqual("FizzBuzz", number.say);
			Assert.AreNotEqual ("Buzz", number.say);
			Assert.AreNotEqual ("Fizz", number.say);

			number.Shout (20);
			Assert.AreEqual("Buzz", number.say);

			number.Shout (18);
			Assert.AreEqual("Fizz", number.say);
		}
	}
}
