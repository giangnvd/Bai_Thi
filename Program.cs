using System;
using Bai_Thi.Controller;
using Bai_Thi.Entity;

namespace Bai_Thi
{
    class Program
    {
        static controller cnl = new controller();

        static void Main(string[] args)
        {
            Console.WriteLine("-------Menu---------");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by ID");
            Console.WriteLine("4. Exit ");
            Console.WriteLine("Please enter you choice (1|2|3|4): ");
            var choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. Add product records.");
                    cnl.AddProductRecords();
                    break;
                case 2:
                    cnl.DisplayProductRecords();
                    break;
                case 3:
                    cnl.DeleteProductById();
                    break;
                case 4:
                    break;
            }
        }
    }
}