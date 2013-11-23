using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
	[TestClass]
	public class TriangleUnitTest
	{
		// Testar om triangeln är likbent
		[TestMethod]
		public void IsIsoscelesTest()
		{
			Triangle triIsIsosceles = new Triangle(1.0, 0.5, 1.0);
			Assert.IsTrue(triIsIsosceles.isIsosceles());
		}

		// Testar värden som ger en liksidig triangel istället för likbent
		[TestMethod]
		public void IsIsoscelesWhenFalseInputTest()
		{
			Triangle triNotAIsosceles = new Triangle(1.0, 1.0, 1.0);
			Assert.IsFalse(triNotAIsosceles.isIsosceles());
		}

		// Testar värden som ger en triangel med olika sidor istället för likbent
		[TestMethod]
		public void IsIsoscelesWhenFalseInputTest2()
		{
			Triangle triNotAIsosceles2 = new Triangle(5.0, 10.0, 20.0);
			Assert.IsFalse(triNotAIsosceles2.isIsosceles());
		}

		// Testar om triangeln är liksidig 
		[TestMethod]
		public void IsEquilateralTest()
		{
			Triangle triIsEquilateral = new Triangle(10.0, 10.0, 10.0);
			Assert.IsTrue(triIsEquilateral.isEquilateral());
		}

		// Testar värden som ger en triangel med tre olika sidor istället för liksidig 
		[TestMethod]
		public void IsEquilateralWhenFalseInputTest()
		{
			Triangle triIsNotEquilateral = new Triangle(5.0, 10.0, 20.0);
			Assert.IsFalse(triIsNotEquilateral.isEquilateral());
		}

		// Testar värden som ger en likbent triangel istället för liksidig
		[TestMethod]
		public void IsEquilateralWhenFalseInputTest2()
		{
			Triangle triIsNotEquilateral2 = new Triangle(5.0, 10.0, 10.0);
			Assert.IsFalse(triIsNotEquilateral2.isEquilateral());
		}

		// Testar om triangeln har olika sidor
		[TestMethod]
		public void IsScaleneTest()
		{
			Triangle triIsScalene = new Triangle(5.0, 20.0, 30.0);
			Assert.IsTrue(triIsScalene.isScalene());
		}

		// Testar värden som ger en liksidig triangel istället för olika sidor 
		[TestMethod]
		public void IsScaleneTestWhenFalseInputTest()
		{
			Triangle triIsNotScalene = new Triangle(5.0, 5.0, 5.0);
			Assert.IsFalse(triIsNotScalene.isScalene());
		}

		// Testar värden som ger en likbent triangel istället för olika sidor 
		[TestMethod]
		public void IsScaleneTestWhenFalseInputTest2()
		{
			Triangle triIsNotScalene2 = new Triangle(5.0, 10.0, 10.0);
			Assert.IsFalse(triIsNotScalene2.isScalene());
		}

		// Testar om det kastas ett undantag av typen ArgumentNullException 
		// med ogiltiga värden
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ZeroInputTest()
		{
			Triangle tri = new Triangle(0.0, 0.0, 0.0);
		}

		// Testar om beräkning kan göras trots ogiltiga värden
		[TestMethod]
		public void IsIsoscelesTestForNullValueInput()
		{
			Triangle triWithNullValue = new Triangle(0.0, 0.0, 0.0);
			Assert.IsFalse(triWithNullValue.isIsosceles());
		}

		// Testar Pointskonstruktorn för uträkning av likbent triangel
		[TestMethod]
		public void IsIsoscelesPointsTest()
		{
			Point a = new Point(1, 3);
			Point b = new Point(-1, -1);
			Point c = new Point(3, -1);

			Triangle triPointsIsIsosceles = new Triangle(a, b, c);

			Assert.IsTrue(triPointsIsIsosceles.isIsosceles());
		}

		// Testar Pointskonstruktorn för uträkning av likbent triangel
		// med felaktig pointsvärden
		[TestMethod]
		public void IsIsoscelesPointsWithWrongInputTest()
		{
			Point a = new Point(3, 1);
			Point b = new Point(-1, -1);
			Point c = new Point(-1, 3);

			Triangle triPointsIsNotIsosceles = new Triangle(a, b, c);

			Assert.IsFalse(triPointsIsNotIsosceles.isIsosceles());
		}

		// Testar Pointskonstruktorn för uträkning av triangel med olika sidor
		[TestMethod]
		public void IsScalenePointsTest()
		{
			Point a = new Point(4, 4);
			Point b = new Point(3, 2);
			Point c = new Point(-6, -3);

			Triangle triPointsIsScalene = new Triangle(a, b, c);

			Assert.IsTrue(triPointsIsScalene.isScalene());
		}

		// Testar Pointskonstruktorn för uträkning av liksidig triangel
		[TestMethod]
		public void IsEquilateralPointsTest()
		{
			Point a = new Point(0, 3);
			Point b = new Point(-3, -2);
			Point c = new Point(3, -2);

			Triangle triPointsIsEquilateral = new Triangle(a, b, c);

			Assert.IsTrue(triPointsIsEquilateral.isEquilateral());
		}
	}
}
