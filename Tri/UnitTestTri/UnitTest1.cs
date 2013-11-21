using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
	[TestClass]
	public class TriangleUnitTest
	{
		// Testar om triangeln är likbent
		[TestMethod]
		public void isIsoscelesTest()
		{
			Triangle triIsIsosceles = new Triangle(1.0, 0.5, 1.0);
			Assert.IsTrue(triIsIsosceles.isIsosceles());
		}

		// Testar värden som ger en liksidig triangel istället för likbent
		[TestMethod]
		public void isIsoscelesWhenFalseInputTest()
		{
			Triangle triNotAIsosceles = new Triangle(1.0, 1.0, 1.0);
			Assert.IsFalse(triNotAIsosceles.isIsosceles());
		}

		// Testar värden som ger en triangel med olika sidor istället för likbent
		[TestMethod]
		public void isIsoscelesWhenFalseInputTest2()
		{
			Triangle triNotAIsosceles2 = new Triangle(5.0, 10.0, 20.0);
			Assert.IsFalse(triNotAIsosceles2.isIsosceles());
		}

		// Testar om triangeln är liksidig 
		[TestMethod]
		public void isEquilateralTest()
		{
			Triangle triIsEquilateral = new Triangle(10.0, 10.0, 10.0);
			Assert.IsTrue(triIsEquilateral.isEquilateral());
		}

		// Testar värden som ger en triangel med tre olika sidor istället för liksidig 
		[TestMethod]
		public void isEquilateralWhenFalseInputTest()
		{
			Triangle triIsNotEquilateral = new Triangle(5.0, 10.0, 20.0);
			Assert.IsFalse(triIsNotEquilateral.isEquilateral());
		}

		// Testar värden som ger en likbent triangel istället för liksidig
		[TestMethod]
		public void isEquilateralWhenFalseInputTest2()
		{
			Triangle triIsNotEquilateral2 = new Triangle(5.0, 10.0, 10.0);
			Assert.IsFalse(triIsNotEquilateral2.isEquilateral());
		}

		// Testar om triangeln har olika sidor
		[TestMethod]
		public void isScaleneTest()
		{
			Triangle triIsScalene = new Triangle(5.0, 20.0, 30.0);
			Assert.IsTrue(triIsScalene.isScalene());
		}

		// Testar värden som ger en liksidig triangel istället för olika sidor 
		[TestMethod]
		public void isScaleneTestWhenFalseInputTest()
		{
			Triangle triIsNotScalene = new Triangle(5.0, 5.0, 5.0);
			Assert.IsFalse(triIsNotScalene.isScalene());
		}

		// Testar värden som ger en likbent triangel istället för olika sidor 
		[TestMethod]
		public void isScaleneTestWhenFalseInputTest2()
		{
			Triangle triIsNotScalene2 = new Triangle(5.0, 10.0, 10.0);
			Assert.IsFalse(triIsNotScalene2.isScalene());
		}

		// Testar om det kastas ett undantag av typen ArgumentNullException 
		// med ogiltiga värden
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void MethodTest()
		{
			Triangle tri = new Triangle(0.0, 0.0, 0.0);
		}

		// Testar om beräkning kan göras trots ogiltiga värden
		[TestMethod]
		public void isIsoscelesTestForNullValueInput()
		{
			Triangle triWithNullValue = new Triangle(0.0, 0.0, 0.0);
			Assert.IsFalse(triWithNullValue.isIsosceles());
		}
		
	}
}
