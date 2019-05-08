// Programmer: Rod Mesquita
// Program name: Northwind Database - Web App Dev - LTU
// Date: April 29, 2019
// Honor code: "I have neither given nor received unauthorized aid in completing this work, 
//		nor have I presented someone else's work as my own."

using System;
using static System.Console;
using Packt.CS7;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Xml.Linq;

namespace LinqWithEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Northwind())
            { 

                foreach (Customer customerItem in db.Customers)
                {
                    Console.WriteLine("COMPANY: {0,2} CONTACT TITLE: {1,-15} NAME: {2}", 
                        customerItem.CompanyName, customerItem.ContactTitle, customerItem.ContactName);
                }
                Console.ReadLine();

            }
        }
    }
}