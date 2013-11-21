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
		public void isIsoscelesTestWhenFalse()
		{
			Triangle triFalse = new Triangle(1.0, 1.0, 1.0);
			Assert.IsFalse(triFalse.isIsosceles());
		}

		[TestMethod]
		public void isEquilateralTest()
		{
			Triangle tri2 = new Triangle(10.0, 10.0, 10.0);
			Assert.IsTrue(tri2.isEquilateral());
		}

		[TestMethod]
		public void isEquilateralTestWhenFalse()
		{
			Triangle triFalse2 = new Triangle(7.0, 10.0, 30.0);
			Assert.IsFalse(triFalse2.isEquilateral());
		}

		[TestMethod]
		public void isScaleneTest()
		{
			Triangle tri3 = new Triangle(5.0, 30.0, 30.0);
			Assert.IsTrue(tri3.isScalene());
		}

		[TestMethod]
		public void isScaleneTestWhenFalse()
		{
			Triangle triFalse3 = new Triangle(10.0, 10.0, 10.0);
			Assert.IsFalse(triFalse3.isScalene());
		}

		[TestMethod]
		public void CheckStruct()
		{
			int a;
			int b;
			Assert.IsTrue(true);
		}
		
	}
}
