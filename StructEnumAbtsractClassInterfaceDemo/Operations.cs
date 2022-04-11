
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumAbtsractClassInterfaceDemo
{
     class Operations
    {
        static void Main()
        {
            int n1, n2, ch;
            Console.WriteLine("Enter No1");
            n1 = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter No2");
            n2 = Byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter choice");
            ch = Byte.Parse(Console.ReadLine());
      switch(ch)
            {
                case 1: Console.WriteLine(n1+n2);  break;

                case 2: Console.WriteLine(n1 - n2); break;

                case 3: Console.WriteLine(n1 * n2); break;

                case 4: Console.WriteLine(n1 / n2); break;

                case 5: Console.WriteLine(n1 % n2); break;
                default: Console.WriteLine("Invalid Choice"); break;
            }
        }
    }
}
