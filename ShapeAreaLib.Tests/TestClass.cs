namespace ShapeAreaLib.Tests
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void Circle_GetArea_10_returned314()
        {
            // arrange
            double radius = 10;
            double excepted = Math.PI * Math.Pow(radius, 2);
            
            // act
            Circle testCircle = new Circle(radius);
            double actual = testCircle.GetArea();

            // assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Circle_GetArea_0_returned0()
        {
            // arrange
            double radius = 0;
            double excepted = 0;

            // act
            Circle testCircle = new Circle(radius);
            double actual = testCircle.GetArea();

            // assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Triangle_GetArea_1_2_3_returned0()
        {
            // arrange
            double s1 = 1;
            double s2 = 2;
            double s3 = 3;
            double p = (s1 + s2 + s3) / 2;
            double excepted = Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));

            // act
            Triangle testTriangle = new Triangle(s1,s2,s3);
            double actual = testTriangle.GetArea();

            // assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Triangle_GetArea_9_2_4_returned0()
        {
            // arrange
            double s1 = 9;
            double s2 = 2;
            double s3 = 4;
            double p = (s1 + s2 + s3) / 2;
            double excepted = Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));

            // act
            Triangle testTriangle = new Triangle(s1, s2, s3);
            double actual = testTriangle.GetArea();

            // assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle_3_4_5_returnedTrue()
        {
            // arrange
            double s1 = 3;
            double s2 = 4;
            double s3 = 5;
            bool excepted = true;

            // act
            Triangle testTriangle = new Triangle(s1, s2, s3);
            bool actual = testTriangle.IsRightTriangle();

            // assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle_3_8_5_returnedTrue()
        {
            // arrange
            double s1 = 3;
            double s2 = 8;
            double s3 = 5;
            bool excepted = false;

            // act
            Triangle testTriangle = new Triangle(s1, s2, s3);
            bool actual = testTriangle.IsRightTriangle();

            // assert
            Assert.AreEqual(excepted, actual);
        }
    }
}