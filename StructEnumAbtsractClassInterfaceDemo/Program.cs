using System;

namespace StructEnumAbtsractClassInterfaceDemo
{
    struct Record
    {
        int id;
        string name;
        string address;
        //public Record()
        //{

        //}
        public Record(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void Get()
        {
            Console.WriteLine("Enter Id");
            id = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("ENter Address");
            address = Console.ReadLine();
            Console.WriteLine("ENter Name");
            name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine($"ID is {id}\nName is{name}\nAddress is {address}");
        }

    }
    //struct Rec   : Record
    //{

    //}
    class Program
    {
        static void Main(string[] args)
        {
            Record record = new Record();
         
            record.Get();
            record.Display();

            Employee employee = new Employee();
            employee.GetDetails();
           
            
        }
    }
}
