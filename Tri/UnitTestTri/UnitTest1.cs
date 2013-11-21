using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
	[TestClass]
	public class TriangleUnitTest
	{
		// Testar om triangeln är likbent
<<<<<<< HEAD
		// [PASSED]
=======
>>>>>>> 2965f6e562e12bdd4c465e39adba9af8990929af
		[TestMethod]
		public void isIsoscelesTest()
		{
			Triangle triIsIsosceles = new Triangle(1.0, 0.5, 1.0);
			Assert.IsTrue(triIsIsosceles.isIsosceles());
		}

		// Testar värden som ger en liksidig triangel istället för likbent
<<<<<<< HEAD
		// [PASSED]
=======
>>>>>>> 2965f6e562e12bdd4c465e39adba9af8990929af
		[TestMethod]
		public void isIsoscelesWhenFalseInputTest()
		{
			Triangle triNotAIsosceles = new Triangle(1.0, 1.0, 1.0);
			Assert.IsFalse(triNotAIsosceles.isIsosceles());
		}

		// Testar värden som ger en triangel med olika sidor istället för likbent
<<<<<<< HEAD
		// [PASSED]
=======
>>>>>>> 2965f6e562e12bdd4c465e39adba9af8990929af
		[TestMethod]
		public void isIsoscelesWhenFalseInputTest2()
		{
			Triangle triNotAIsosceles2 = new Triangle(5.0, 10.0, 20.0);
			Assert.IsFalse(triNotAIsosceles2.isIsosceles());
		}

		// Testar om triangeln är liksidig 
<<<<<<< HEAD
		// [FAILED TEST] då ska ge [TRUE] men gav [FALSE]
=======
>>>>>>> 2965f6e562e12bdd4c465e39adba9af8990929af
		[TestMethod]
		public void isEquilateralTest()
		{
			Triangle triIsEquilateral = new Triangle(10.0, 10.0, 10.0);
			Assert.IsTrue(triIsEquilateral.isEquilateral());
		}

		// Testar värden som ger en triangel med tre olika sidor istället för liksidig 
<<<<<<< HEAD
		// [FAILED TEST] då ska ge [TRUE] men gav [FALSE]
=======
>>>>>>> 2965f6e562e12bdd4c465e39adba9af8990929af
		[TestMethod]
		public void isEquilateralWhenFalseInputTest()
		{
			Triangle triIsNotEquilateral = new Triangle(5.0, 10.0, 20.0);
			Assert.IsFalse(triIsNotEquilateral.isEquilateral());
		}

		// Testar värden som ger en likbent triangel istället för liksidig
<<<<<<< HEAD
		// [PASSED]
=======
>>>>>>> 2965f6e562e12bdd4c465e39adba9af8990929af
		[TestMethod]
		public void isEquilateralWhenFalseInputTest2()
		{
			Triangle triIsNotEquilateral2 = new Triangle(5.0, 10.0, 10.0);
			Assert.IsFalse(triIsNotEquilateral2.isEquilateral());
		}

		// Testar om triangeln har olika sidor
<<<<<<< HEAD
		// [FAILED TEST] då ska ge [TRUE] men gav [FALSE]
=======
>>>>>>> 2965f6e562e12bdd4c465e39adba9af8990929af
		[TestMethod]
		public void isScaleneTest()
		{
			Triangle triIsScalene = new Triangle(5.0, 20.0, 30.0);
			Assert.IsTrue(triIsScalene.isScalene());
		}

		// Testar värden som ger en liksidig triangel istället för olika sidor 
<<<<<<< HEAD
		// [FAILED TEST] då ska ge [TRUE] men gav [FALSE]
=======
>>>>>>> 2965f6e562e12bdd4c465e39adba9af8990929af
		[TestMethod]
		public void isScaleneTestWhenFalseInputTest()
		{
			Triangle triIsNotScalene = new Triangle(5.0, 5.0, 5.0);
			Assert.IsFalse(triIsNotScalene.isScalene());
		}

		// Testar värden som ger en likbent triangel istället för olika sidor 
<<<<<<< HEAD
		// [PASSED]
=======
>>>>>>> 2965f6e562e12bdd4c465e39adba9af8990929af
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

<<<<<<< HEAD
		// Testar om beräkning kan göras trots nollvärden
=======
		// Testar om beräkning kan göras trots ogiltiga värden
>>>>>>> 2965f6e562e12bdd4c465e39adba9af8990929af
		[TestMethod]
		public void isIsoscelesTestForNullValueInput()
		{
			Triangle triWithNullValue = new Triangle(0.0, 0.0, 0.0);
			Assert.IsFalse(triWithNullValue.isIsosceles());
		}
		
	}
}
