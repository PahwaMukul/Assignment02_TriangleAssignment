using NUnit.Framework;
using TriangleAssignment;

namespace TriangleTest
{
    public class Tests

    {
        static string eq = "Equilateral";
        static string isc = "Isoceles";
        static string scl = "Scalene";


        [Test]
        public void TC01_Verifying_Equilateral_Triangle_Cannot_be_formed_with_negative_Input_of_sides()
        {
            Assert.AreEqual(null, TriangleSolver.Analyze(-2, -2, -2));
        }

        [Test]
        public void TC02_Verifying_Isoceles_Triangle_Cannot_be_formed_with_negative_Input_of_sides()
        {
            Assert.AreEqual(null, TriangleSolver.Analyze(-6, -6, -8));
        }

        [Test]
        public void TC03_Verifying_Scalene_Triangle_Cannot_be_formed_with_negative_Input_of_sides()
        {
            Assert.AreEqual(null, TriangleSolver.Analyze(-6, -6, -8));
        }

        [Test]
        public void TC04_Verifying_Equilateral_Triangle_Can_be_formed_with_Same_input_of_sides()
        {
            Assert.AreEqual(eq, TriangleSolver.Analyze(5, 5, 5));
        }

        [Test]
        public void TC05_Verifying_Equilateral_Triangle_Cannot_be_formed_with_different_input_of_sides()
        {
            Assert.AreNotEqual(eq, TriangleSolver.Analyze(4, 5, 6));
        }

        [Test]
        public void TC06_Verifying_Isoceles_Triangle_Can_be_formed_with_Same_input_of_two_sides()
        {
            Assert.AreEqual(isc, TriangleSolver.Analyze(6, 6, 8));
        }

        [Test]
        public void TC07_Verifying_Isoceles_Triangle_Cannot_be_formed_with_all_different_sides()
        {
            Assert.AreNotEqual(isc, TriangleSolver.Analyze(4, 5, 6));
        }


        [Test]
        public void TC08_Verifying_Scalene_Triangle_Can_be_formed_with_All_different_sides()
        {
            Assert.AreEqual(scl, TriangleSolver.Analyze(6, 7, 8));
        }

        [Test]
        public void TC09_Verifying_Scalene_Triangle_Cannot_be_formed_with_two_or_all_same_sides()
        {
            Assert.AreNotEqual(scl, TriangleSolver.Analyze(6, 6, 8));

        }



    }
}