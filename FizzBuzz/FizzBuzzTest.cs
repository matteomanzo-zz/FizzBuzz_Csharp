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
			Assert.AreEqual("FizzBuzz", number.Shout (30));
		}

		[Test()]
		public void ItShouldNotReturnTheWrongExpressionsWhenNumberIsDivisibleBy15()
		{
			Assert.AreNotEqual ("Buzz", number.Shout (30));
			Assert.AreNotEqual ("Fizz", number.Shout (30));
		}

		[Test()]
		public void ItShouldReturnTheRightExpressionsWhenNumberIsDivisibleBy5()
		{
			Assert.AreEqual ("Buzz", number.Shout (20));
		}

		[Test()]
		public void ItShouldNotReturnTheWrongExpressionsWhenNumberIsDivisibleBy5()
		{
			Assert.AreNotEqual ("FizzBuzz", number.Shout (20));
			Assert.AreNotEqual ("Fizz", number.Shout (20));
		}

		[Test()]
		public void ItShouldReturnTheRightExpressionsWhenNumberIsDivisibleBy3()
		{
			Assert.AreEqual("Fizz", number.Shout (12));
		}

		[Test()]
		public void ItShouldNotReturnTheWrongExpressionsWhenNumberIsDivisibleBy3()
		{
			Assert.AreNotEqual ("FizzBuzz", number.Shout (12));
			Assert.AreNotEqual ("Buzz", number.Shout (12));
		}
	}
}
