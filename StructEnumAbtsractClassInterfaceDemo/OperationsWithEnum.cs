
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumAbtsractClassInterfaceDemo
{
    enum Result : byte {  Poor=255, Ok=8, Avg=8, Fair=8, Good=12 , VGood=15, Excellent=20}
  enum Choice { Addition=1 , Subtarction , Product, Quotient, Remainder};
    class OperationsWithEnum
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
                case (int)Choice.Addition : Console.WriteLine(n1+n2);  break;

                case (int)Choice.Subtarction : Console.WriteLine(n1 - n2); break;

                case (int)Choice.Product: Console.WriteLine(n1 * n2); break;

                case (int)Choice.Quotient: Console.WriteLine(n1 / n2); break;

                case (int)Choice.Remainder: Console.WriteLine(n1 % n2); break;
                default: Console.WriteLine("Invalid Choice"); break;
            }
        }
    }
}
