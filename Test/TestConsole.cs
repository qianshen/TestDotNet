using System;
using NUnit.Framework;
using System.Diagnostics;

namespace Test
{
	[TestFixture()]
	public class TestConsole
	{
		[Test()]
		public void TestCase ()
		{
			Console.WriteLine("console");
			Assert.Pass("pass");
			Trace.WriteLine("passed");
		}
	}
}

