using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    public class Rectangle
    {
     
        public Rectangle(Point  topLeft, Point bottomRight, int height, int width)
        {
            if (topLeft.X > bottomRight.X || topLeft.Y > bottomRight.Y)
            { 
                throw new ArgumentException("coordinates are not right"); 
            }
            TopLeft = topLeft;
            BottomRight = bottomRight;

            Width = width;
            Height = height;

            TopRight = new Point(topLeft.X + Width, topLeft.Y);
            BottomLeft = new Point(topLeft.X, topLeft.Y + Height);
           


            
        }
        public Point TopLeft { get; }
        public Point TopRight { get; }

        public Point BottomLeft { get; }

        public Point BottomRight { get; }

        public int Width { get; }

        public int Height { get; }

    }
}
