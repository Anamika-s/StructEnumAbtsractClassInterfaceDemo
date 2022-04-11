using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumAbtsractClassInterfaceDemo
{
    struct Address
    {
        string streetNo;
        string city;
        string state;
        string pinCode;
        public void GetAddressDetails()
        {
            Console.WriteLine("ENter StreetNo");
            streetNo = Console.ReadLine();
            Console.WriteLine("Enter City");
            city = Console.ReadLine();
            Console.WriteLine("Enter State");
            state = Console.ReadLine();
            
        }

    }
    struct DateOfBirth
    {
        public int day, month, year;
    }
    class Employee
    {
        int id;
        string name;
        Address address;
        DateOfBirth dob;
        public void GetDetails()
        {
            Console.WriteLine("Enter Id");
            id = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("ENter NAme");
            name = Console.ReadLine();
            address.GetAddressDetails();
            Console.WriteLine("Enter Date of Birth");
            dob.day = byte.Parse(Console.ReadLine());
            dob.month = byte.Parse(Console.ReadLine());
            dob.year = byte.Parse(Console.ReadLine());
        }
    }
}
