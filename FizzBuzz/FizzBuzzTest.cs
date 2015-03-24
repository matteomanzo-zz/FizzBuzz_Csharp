using NUnit.Framework;
using System;

namespace FizzBuzz
{
	[TestFixture]
	public class GameClassTest
	{
		[Test]
		public void Game()
		{
			GameClass number = new GameClass();
			number.Game (15);
			Assert.AreEqual("FizzBuzz", number.Shout);

			number.Game (5);
			Assert.AreEqual ("Buzz", number.Shout);
		}
	}
}
