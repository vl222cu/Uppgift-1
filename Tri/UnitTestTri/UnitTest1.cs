using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
	[TestClass]
	public class TriangleUnitTest
	{
		[TestMethod]
		public void isIsoscelesTest()
		{
			Triangle tri1 = new Triangle(1.0, 0.5, 1.0);
			Assert.IsTrue(tri1.isIsosceles());
		}

		[TestMethod]
		public void isEquilateralTest()
		{
			Triangle tri2 = new Triangle(10.0, 10.0, 10.0);
			Assert.IsTrue(tri2.isEquilateral());
		}

		[TestMethod]
		public void isScaleneTest()
		{
			Triangle tri3 = new Triangle(10.0, 20.0, 30.0);
			Assert.IsTrue(tri3.isScalene());
		}	
	}
}
