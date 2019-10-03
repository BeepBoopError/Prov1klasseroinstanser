using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_10_03_prog_02_Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            //a list of all the books
            List<Book> Books = new List<Book> { new Book() { random = true}, new Book() { random = true } };
            //a list of all the customers
            List<Customer> Customers = new List<Customer> { new Customer() { random = true }, new Customer() { random = true } };
            //both lists could be added to with a for loop, if more of each is needed, etc.


            //write out all the stuff
            Console.WriteLine("what book do you want to show to to what custommer?");
            Console.WriteLine("books");
            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine((i+1) +": " + Books[i].name);
            }
            Console.WriteLine("customers");
            for (int i = 0; i < Customers.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + Customers[i].name);
            }

            //offering a book to a customer
            bool wantToBuy = Customers[1].Judge(Books[1]);

            Console.ReadLine();
        }
    }
}
