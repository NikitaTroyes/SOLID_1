using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_1
{
    class Program
    {
   
        public abstract class Polygon
        {
            public abstract double Area(); 
        }
        
        
        class Rectangle : Polygon

        {
            private double width;

            private double height;

            public void SetWidth(double width)
            {
                this.width = width;
            }

            public void SetHeight(double height)
            {
                this.height = height;
            }

            public double GetWidth()

            {
                return width;
            }

            public double GetHeight()

            {
                return height;
            }

            public override double Area()
            {
                return height * width;
            }

        }


        class Square : Polygon

        {
            private double side;

            public void SetSide(double side)

            {
                this.side = side;

            }

            public double GetSide()

            {
                return side;
            }

            public override double Area()
            {
                return side * side;
            }


        }
    }
}
