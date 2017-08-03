using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointinTheFigure
{
    class PointInTheFigure
    {
        static void Main()
        {
            //* Lower Rectangle
            int blockSize = int.Parse(Console.ReadLine());
            int pointToCheckX = int.Parse(Console.ReadLine());
            int pointToCheckY = int.Parse(Console.ReadLine());

            int lowerRectangleLowerLeftPointX = 0;
            int lowerRectangleLowerLeftPointY = 0;
            int lowerRectangleLowerRightPointX = 3 * blockSize;
            int lowerRectangleUpperLeftPointY = blockSize;

            //Inside in lower Rectangle
            bool pointHorizontallyInsideLowerRectangle =
                lowerRectangleLowerLeftPointX < pointToCheckX && 
                pointToCheckX < lowerRectangleLowerRightPointX;

            bool pointVerticallyInsideLowerRectangle = 
                lowerRectangleLowerLeftPointY < pointToCheckY &&
                pointToCheckY < lowerRectangleUpperLeftPointY;

            bool pointInsideLowerRectangle =
                pointHorizontallyInsideLowerRectangle && pointVerticallyInsideLowerRectangle;

            //Outside in lower Rectangle
            bool pointHorizontallyOutsideLowerRectangle =
                pointToCheckX < lowerRectangleLowerLeftPointX || lowerRectangleLowerRightPointX < pointToCheckX;
            bool pointVerticalyOutSideLowerRectangle =
                pointToCheckY < lowerRectangleLowerLeftPointY || lowerRectangleUpperLeftPointY < pointToCheckY;
            bool pointOutsideLowerRectangle =
                pointHorizontallyOutsideLowerRectangle || pointVerticalyOutSideLowerRectangle;

            //Border in lower Rectangle
            bool pointOnBorderOfLowerRectangle =
                !pointInsideLowerRectangle && !pointOutsideLowerRectangle;

           
            //* Upper Rectangle

            int upperRectangleLowerLeftPointX = blockSize;
            int upperRectangleLowerLeftPointY = blockSize;
            int upperRectangleLowerRightPointX = 2 * blockSize;
            int upperRectangleUpperLeftPointY = 4 * blockSize;

            //Inside in upper Rectangle
            bool pointHorizontallyInsideUpperRectangle =
                upperRectangleLowerLeftPointX < pointToCheckX &&
                pointToCheckX < upperRectangleLowerRightPointX;

            bool pointVerticallyInsideUpperRectangle =
                upperRectangleLowerLeftPointY < pointToCheckY &&
                pointToCheckY < upperRectangleUpperLeftPointY;

            bool pointInsideUpperRectangle =
                pointHorizontallyInsideUpperRectangle && pointVerticallyInsideUpperRectangle;

            //Outside in upper Rectangle
            bool pointHorizontallyOutsideUpperRectangle =
                pointToCheckX < upperRectangleLowerLeftPointX || upperRectangleLowerRightPointX < pointToCheckX;
            bool pointVerticalyOutSideUpperRectangle =
                pointToCheckY < upperRectangleLowerLeftPointY || upperRectangleUpperLeftPointY < pointToCheckY;
            bool pointOutsideUpperRectangle =
                pointHorizontallyOutsideUpperRectangle || pointVerticalyOutSideUpperRectangle;

            //Border in upper Rectangle
            bool pointOnBorderOfUpperRectangle =
                !pointInsideUpperRectangle && !pointOutsideUpperRectangle;
            // Common side
            bool pointOnCommonSideOfRectangle =
                pointOnBorderOfLowerRectangle && pointOnBorderOfUpperRectangle
                && pointToCheckX > blockSize && pointToCheckX < 2 * blockSize;

            //All Figure
            bool pointInsideFigure = pointInsideLowerRectangle ||
                pointInsideUpperRectangle || pointOnCommonSideOfRectangle;

            bool pointOutsideFigure = pointOutsideLowerRectangle && pointOutsideUpperRectangle;
            bool pointOnBorderOfFigure = !pointInsideFigure && !pointOutsideFigure;

            if (pointInsideFigure)
            {
                Console.WriteLine("inside");
            }
            else if (pointOnBorderOfFigure)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
