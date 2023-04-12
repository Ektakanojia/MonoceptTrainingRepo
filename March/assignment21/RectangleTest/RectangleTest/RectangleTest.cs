using RectangleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleTest
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void ShouldCalculateAreaIfWidthAndHeightIsPostitveAndReturnPostiveArea()
        {
            int exceptedResult = 100;
            string exceptedColor="red";
            int exceptedHeight = 10;
            int exceptedWidth = 10;
            Rectangle  rectangle= new Rectangle(10,10,"red");
            int actualResult = rectangle.CalculateArea(10, 10);
            Assert.AreEqual(exceptedResult, actualResult);
            Assert.AreEqual(exceptedColor,rectangle.GetColor());
            Assert.AreEqual(exceptedWidth, rectangle.GetWidth());
            Assert.AreEqual(exceptedHeight, rectangle.GetHeight());

        }
        [TestMethod]
        
        public void ShouldCalculateAreaIfBothWidthAndHeightIsNegativeAndReturnPostiveArea()
        {
            int exceptedResult = 100;
            Rectangle rectangle= new Rectangle(-10,-10,"red");
            int actualResult =rectangle.CalculateArea(-10, -10);
            Assert.AreEqual(exceptedResult, actualResult);


        }
        [TestMethod]
        public void ShouldReturnZeroAreaIfAnyOneOfHeightAndWidthIsZero()
        {
            int exceptedResult = 0;
            Rectangle rectangle= new Rectangle(10,0,"red");
            int actualResult = rectangle.CalculateArea(10, 0);
            Assert.AreEqual(exceptedResult, actualResult);

        }
        [TestMethod]
        public void ShouldReturnAreaInNegativeIfAnyOfHeightAndWidthIsNegative()
        {
            int exceptedResult = -200;
            Rectangle rectangle= new Rectangle(10,20,"red");
            int actualResult=rectangle.CalculateArea(10, -20);
            Assert.AreEqual(exceptedResult, actualResult);
        }



    }
}
