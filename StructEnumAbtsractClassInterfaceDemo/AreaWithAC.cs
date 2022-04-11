using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumAbtsractClassInterface
{ 
    abstract class Shape
     
    {
        protected int dim1, dim2, area;
        public abstract void GetDimensions();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine($"Area is {area}");

        }
    }

    class Square : Shape
    {
        public override void CalculateArea()
        {
            area = dim1 * dim1;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("Enter value for side");
            dim1 = byte.Parse(Console.ReadLine());
        }
    }

    class  Rectangle : Shape
    {
        public override void CalculateArea()
        {
            area = dim1 * dim2;
        }
        public override void GetDimensions()
        {
            Console.WriteLine("Enter l");
            dim1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("ENter w");
            dim2 = byte.Parse(Console.ReadLine());
        }

    }
    class AreaWithAC
    {
        static void Main()
        {
            //Shape shape = new Shape();
            Square square = new Square();
            square.GetDimensions();
            square.CalculateArea();
            square.DisplayArea();

            Rectangle rectangle = new Rectangle();
            rectangle.GetDimensions();
            rectangle.CalculateArea();
            rectangle.DisplayArea();

        }
    }
}
