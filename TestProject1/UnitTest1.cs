using TestMindbox;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCircleSquare()
        {
            GeometricFigure d = new Circle(4.6);

            double expected = 66.47610054996001;

            Assert.AreEqual(expected, d.getSquare());
        }

        [TestMethod]
        public void TestMethodTriangleSquare()
        {
            GeometricFigure d = new Triangle(4,5,6);

            double expected = 9.921567416492215;

            Assert.AreEqual(expected, d.getSquare());
        }

        [TestMethod]
        public void TestMethodTriangleIsRectangular()
        {
            Triangle d = new Triangle(3, 4, 5);

            bool expected = true;

            Assert.AreEqual(expected, d.IsRectangular());
        }
    }
}