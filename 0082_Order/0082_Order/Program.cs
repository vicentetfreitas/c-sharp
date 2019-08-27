using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using _0082_Order.Entities;
using _0082_Order.Entities.Enums;

namespace _0082_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

        }
    }
}
