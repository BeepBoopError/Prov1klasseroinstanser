using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_10_03_prog_02_Prov
{
    class Customer
    {
        //random number generator
        private static Random rangen = new Random();

        //the amount of money the customer can spend
        private int money = 0;

        //the amount of ´money the custommer is will ing to pay bellow their budget, determines how low their minimum price range is.
        private int generosity = 0;

        //the chance of the customer of finding a curse on an item.
        private int experience = 0;

        //some customers are looking for cursed items.
        private bool occult = false;

        //currently there are only books, but other types of items may be added.
        public List<string> interests = new List<string> { "book" };

        //should one wish the customer to randomly generate when the instance is created, this can be made true
        public bool random = false;

        //every customer has a name, could be randomly generated
        public string name = "";

        //constructor
        public Customer()
        {
            //if the customer should be randomly generated, then do
            if (random)
            {
                //generate stats
                money = rangen.Next(100, 10001);
                generosity = rangen.Next(10, 5001);
                experience = rangen.Next(1, 101);

                //1 in ten they are occult 
                if (rangen.Next(1,11)==1) { occult = true; }

                //space to add a random name generator
                name = "random name";

            } 


        }

        //between leaving and comming back, the cusomer makes some money, money shouldn't go over ten thousand, since it might never buy books after that point.
        public void MakeMoney()
        {
            money += rangen.Next(1,5001);

            if (money > 10000) { money = 10000; }
        }


        //the customer decides if it wants to buy the book, requires a book as input
        public bool Judge (Book judging )
        {
            //create a bool for if the customer wants the book
            bool buy = false;

            //if the books price is within the range of the actual value and in the customers price range it will buy
            if (judging.GetVal() >= judging.pValue - generosity && judging.GetVal() <= judging.pValue + generosity && judging.pValue <= money && judging.pValue> money -generosity)
            {
                //if the item is cursed and the customer can detect it is cursed, the customer will demand half off the price, unless they are occult, then they will offer more money
                if (judging.GetCur() == true && rangen.Next(1, 101) < experience)
                {
                    Console.Write("It's cursed! ");
                    if (occult)
                    {
                        Console.WriteLine("I'll give you dubble! or at least as much as I can!");
                    }
                    else
                    {
                        Console.WriteLine("I'll give you half!");
                    }


                }
                else
                {
                    Console.WriteLine("I'll buy it!");
                }
                //the custommer wants to buy the book.
                buy = true;
            }
            //return
            return buy;
        }

        //write out information about the custommer
        public void PrintStats()
        {
            Console.WriteLine(money + generosity + experience);
            //write out interests too
        }
        
        

    }
}
