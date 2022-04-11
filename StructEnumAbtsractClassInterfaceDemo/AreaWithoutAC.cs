using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumAbtsractClassInterfaceDemo
{ class Square
    {
        int side, area;
        public void GetDimensions()
        {
            Console.WriteLine("Enter Value of side");
            side = Byte.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = side * side;
        }
        public void DisplayArea()
        {
            Console.WriteLine($"Area is {area}");

        }
    }

    class Recangle
    {
        int l, w, area;
        public void GetDimensions()
        {
            Console.WriteLine("Enter Value of length");
            l = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of width");
            w = Byte.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = l * w;
        }
        public void DisplayArea()
        {
            Console.WriteLine($"Area is {area}");

        }
    }



    class Triangle
    {
        int b,h , area;
        public void GetDimensions()
        {
            Console.WriteLine("Enter Value of base");
            b = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of heigth");
            h = Byte.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = (int).5 * b * h;
        }
        public void DisplayArea()
        {
            Console.WriteLine($"Area is {area}");

        }
    }
    class AreaWithoutAC
    {
    }
}
