using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FizzBuzz
{
	[TestFixture ()]
	public class ProgramTest
	{
		Program program;

		[SetUp()]
		public void Init()
		{
			program = new Program();	
		}

		[Test()]
		public void ItShouldPrintAnInitialMessageOnScreen()
		{
			StringWriter output = new StringWriter();
			Console.SetOut(output);
			program.ReceiveInput ();
			Assert.AreEqual ("Type a number\n", output.ToString ());
		}
	}
}