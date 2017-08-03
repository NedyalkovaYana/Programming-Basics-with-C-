using System;


namespace _9.CircleRectangle
{
    class CircleRectangle
    {
        static void Main()
        {
            Console.WriteLine("Please enter the coordinates X & Y coordinates:");
            Console.Write("X: ");
            double X = double.Parse(Console.ReadLine());
            double circlepointX = X - 1;

            Console.Write("Y: ");
            double Y = double.Parse(Console.ReadLine());
            double circlepointY = Y - 1;
            double circleRadius = 3;

            if ((circlepointX * circlepointX + circlepointY * circlepointY) <= (circleRadius * circleRadius))
            {
                Console.WriteLine("The given point IS within a circle with radius of {0}!", circleRadius);
            }

            else
            {
                Console.WriteLine("The given point IS NOT within a circle with radius of {0}!", circleRadius);
            }
            // Rectangle Sides Coordinates
            double rectangleHeight = 2;
            double rectangleWidth = 6;
            double topY = 1;
            double rightX = 0 + (rectangleWidth / 2);
            double bottomY = 0 - (rectangleHeight / 2);
            double leftX = -1;

            Console.WriteLine("Rectangle Sides Coordinates:nTop Y: {0} nRight X: {1} nBottom Y: {2} nLeft X: {3}", topY, rightX, bottomY, leftX);

            double rectanglePointX = X - (-1); // = x + 1
            double rectanglePointY = Y - 1;

            if ((rectanglePointY < topY) && (rectanglePointY > bottomY) && (rectanglePointX < rightX) && (rectanglePointX > leftX))
            {
                Console.WriteLine("The given point IS withing the rectangle R(top=1, left=-1, width=6, height=2)");
            }
            else
            {
                Console.WriteLine("The given point IS NOT withing rectangle R(top=1, left=-1, width=6, height=2)");
            }
        }
    }
    }

