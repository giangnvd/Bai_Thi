using System;
using System.Collections;
using System.Collections.Generic;
using Bai_Thi.Entity;

namespace Bai_Thi.Controller
{
    public class controller
    {
        entity ettt = new entity();
        private static List<entity> List = new List<entity>();

        public void AddProductRecords()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            entity ett = new entity();
            Console.WriteLine("Please enter ID");
            ett.ProductId = Console.ReadLine();
            Console.WriteLine("Please enter name");
            ett.ProductName = Console.ReadLine();
            Console.WriteLine("Please enter price");
            ett.Price = Console.ReadLine();
            Console.WriteLine("Save successfully");
            List.Add(ett);
        }

        public void DisplayProductRecords()
        {
            Console.WriteLine(" ---------Display product records-------------");
            Console.WriteLine("{0, -20} {1, -20} {2,-20}", "ProductId", "ProductName", "Price");
            Console.WriteLine("----------------------------------------------------");

            foreach (var product in List)
            {
                Console.WriteLine("{0, -20} {1, -20} {2,-20}", product.ProductId, product.ProductName, product.Price);
            }

            Console.ReadLine();
        }


        public void DeleteProductById()
        {
            Console.WriteLine("Please enter product Id :");
            string productId = Console.ReadLine();
            entity delete = List.Find(a => a.ProductId == productId);
            List.Remove(delete);
        }
    }
}