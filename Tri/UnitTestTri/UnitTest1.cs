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
		public void IsNotIsoscelesWhenWrongInputTest()
		{
			Triangle triNotAIsosceles = new Triangle(1.0, 1.0, 1.0);
			Assert.IsFalse(triNotAIsosceles.isIsosceles());
		}

		// Testar värden som ger en triangel med olika sidor istället för likbent
		[TestMethod]
		public void IsNotIsoscelesWhenWrongInputTest2()
		{
			Triangle triNotAIsosceles2 = new Triangle(5.0, 10.0, 20.0);
			Assert.IsFalse(triNotAIsosceles2.isIsosceles());
		}

		// Testar Pointskonstruktorn för uträkning av likbent triangel
		[TestMethod]
		public void IsIsoscelesPointsTest()
		{
			Point a = new Point(0, 0);
			Point b = new Point(2, 2);
			Point c = new Point(4, 0);

			Triangle triPointsIsIsosceles = new Triangle(a, b, c);

			Assert.IsTrue(triPointsIsIsosceles.isIsosceles());
		}

		// Testar Pointsarraykonstruktorn för uträkning av likbent triangel
		[TestMethod]
		public void IsIsoscelesArrayPointsTest()
		{
			Point[] array = { new Point(0, 0), new Point(2, 2), new Point(4, 0) };
			Triangle triArrayPointsIsIsosceles = new Triangle(array);

			Assert.IsTrue(triArrayPointsIsIsosceles.isIsosceles());
		}

		// Testar doublearraykonstruktorn för uträkning av likbent triangel
		[TestMethod]
		public void IsIsoscelesArrayTest()
		{
			double[] array = { 5.0, 10.0, 5.0 };
			Triangle triArrayIsIsosceles = new Triangle(array);

			Assert.IsTrue(triArrayIsIsosceles.isIsosceles());
		}

		// Testar Pointsarraykonstruktorn för uträkning av ogiltiga värden
		[TestMethod]
		public void ZeroArrayPointsTest()
		{
			Point[] array = { new Point(0, 0), new Point(0, 0), new Point(0, 0) };
			Triangle triZeroArrayPoints = new Triangle(array);

			Assert.IsFalse(triZeroArrayPoints.isIsosceles());
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
		public void IsNotEquilateralWhenWrongInputTest()
		{
			Triangle triIsNotEquilateral = new Triangle(5.0, 10.0, 20.0);
			Assert.IsFalse(triIsNotEquilateral.isEquilateral());
		}

		// Testar värden som ger en likbent triangel istället för liksidig
		[TestMethod]
		public void IsNotEquilateralWhenWrongInputTest2()
		{
			Triangle triIsNotEquilateral2 = new Triangle(5.0, 10.0, 10.0);
			Assert.IsFalse(triIsNotEquilateral2.isEquilateral());
		}

		// Testar Pointskonstruktorn för uträkning av liksidig triangel
		[TestMethod]
		public void IsEquilateralPointsTest()
		{
			Point a = new Point(-3, 2);
			Point b = new Point(3, 2);
			Point c = new Point(0, -3);

			Triangle triPointsIsEquilateral = new Triangle(a, b, c);

			Assert.IsTrue(triPointsIsEquilateral.isEquilateral());
		}

		// Testar doublearraykonstruktorn för uträkning av liksidig triangel
		[TestMethod]
		public void IsEquilateralArrayTest()
		{
			double[] array = { 5.0, 5.0, 5.0 };
			Triangle triArrayIsEquilateral = new Triangle(array);

			Assert.IsTrue(triArrayIsEquilateral.isEquilateral());
		}

		// Testar Pointsarraykonstruktorn för uträkning av liksidig triangel 
		[TestMethod]
		public void IsEquilateralArrayPointsTest()
		{
			Point[] array = { new Point(-3, 0), new Point(2, 3), new Point(2, -3) };
			Triangle triArrayPointsIsEquilateral = new Triangle(array);

			Assert.IsTrue(triArrayPointsIsEquilateral.isEquilateral());
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
		public void IsNotScaleneWhenWrongInputTest()
		{
			Triangle triIsNotScalene = new Triangle(5.0, 5.0, 5.0);
			Assert.IsFalse(triIsNotScalene.isScalene());
		}

		// Testar värden som ger en likbent triangel istället för olika sidor 
		[TestMethod]
		public void IsNotScaleneWhenWrongInputTest2()
		{
			Triangle triIsNotScalene2 = new Triangle(5.0, 10.0, 10.0);
			Assert.IsFalse(triIsNotScalene2.isScalene());
		}

		// Testar Pointskonstruktorn för uträkning av likbent triangel
		// med felaktig pointsvärden
		[TestMethod]
		public void IsNotIsoscelesPointsWhenWrongInputTest()
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

		// Testar doublearraykonstruktorn för uträkning av triangel
		// med olika sidor
		[TestMethod]
		public void IsScaleneArrayTest()
		{
			double[] array = { 5.0, 10.0, 20.0 };
			Triangle triArrayIsScalene = new Triangle(array);

			Assert.IsTrue(triArrayIsScalene.isScalene());
		}

		// Testar Pointsarraykonstruktorn för uträkning av triangel 
		// med olika sidor
		[TestMethod]
		public void IsScaleneArrayPointsTest()
		{
			Point[] array = { new Point(4, 4), new Point(3, 2), new Point(-6, -3) };
			Triangle triArrayPointsIsScalene = new Triangle(array);

			Assert.IsTrue(triArrayPointsIsScalene.isScalene());
		}

		// Testar om det kastas ett undantag av typen ArgumentNullException 
		// med ogiltiga värden
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ZeroInputTest()
		{
			Triangle tri = new Triangle(0.0, 0.0, 0.0);
		}

		// Testar om det kastas ett undantag av typen ArgumentNullException 
		// med ogiltiga värden
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void NegativeInputTest()
		{
			Triangle tri = new Triangle(-1.0, 10.0, -20.0);
		}

		// Testar om det kastas ett undantag av typen ArgumentNullException 
		// med ogiltiga värden 
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ConstructorWithNullPoints()
		{
			double[] s = null;
			Triangle nullPoints = new Triangle(s);
		}

		// Testar om det kastas ett undantag av typen ArgumentNullException 
		// med ogiltiga värden
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ConstructorWithTwoPoints()
		{
			double[] s = new double[2];
			Triangle wrongValueSides = new Triangle(s);
		}
	}
}
