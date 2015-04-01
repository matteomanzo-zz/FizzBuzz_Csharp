using NUnit.Framework;
using System;

namespace FizzBuzz
{
	[TestFixture]
	public class FizzBuzzTest
	{ 
		FizzBuzz number;

		[SetUp()]
		public void Init()
		{
			number = new FizzBuzz ();
		}

		[Test()]
		public void ItShouldcheckIfANumberIsDivisibleBy15()
		{
			Assert.IsTrue(number.IsDivisibleBy15(45));
			Assert.IsFalse(number.IsDivisibleBy15(50));
		}

		[Test()]
		public void ItShouldcheckIfANumberIsDivisibleBy5()
		{
			Assert.IsTrue(number.IsDivisibleBy5(10));
			Assert.IsFalse(number.IsDivisibleBy5(7));
		}

		[Test()]
		public void ItShouldcheckIfANumberIsDivisibleBy3()
		{
			Assert.IsTrue(number.IsDivisibleBy3(9));
			Assert.IsFalse(number.IsDivisibleBy3(5));
		}

		[Test ()]
		public void ItShouldReturnTheRightExpressionsWhenNumberIsDivisibleBy15()
		{
			number.Shout (30);
			Assert.AreEqual("FizzBuzz", number.say);
		}

		[Test()]
		public void ItShouldNotReturnTheWrongExpressionsWhenNumberIsDivisibleBy15()
		{
			number.Shout (30);
			Assert.AreNotEqual ("Buzz", number.say);
			Assert.AreNotEqual ("Fizz", number.say);
		}

		[Test()]
		public void ItShouldReturnTheRightExpressionsWhenNumberIsDivisibleBy5()
		{
			number.Shout (20);
			Assert.AreEqual ("Buzz", number.say);
		}

		[Test()]
		public void ItShouldNotReturnTheWrongExpressionsWhenNumberIsDivisibleBy5()
		{
			number.Shout (20);
			Assert.AreNotEqual ("FizzBuzz", number.say);
			Assert.AreNotEqual ("Fizz", number.say);
		}

		[Test()]
		public void ItShouldReturnTheRightExpressionsWhenNumberIsDivisibleBy3()
		{
			number.Shout (12);
			Assert.AreEqual("Fizz", number.say);
		}

		[Test()]
		public void ItShouldNotReturnTheWrongExpressionsWhenNumberIsDivisibleBy3()
		{
			number.Shout (12);
			Assert.AreNotEqual ("FizzBuzz", number.say);
			Assert.AreNotEqual ("Buzz", number.say);
		}
	}
}
