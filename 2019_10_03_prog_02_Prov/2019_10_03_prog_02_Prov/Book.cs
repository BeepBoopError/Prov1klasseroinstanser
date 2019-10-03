using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_10_03_prog_02_Prov
{
    class Book
    {

        //a random generator that is static to prevent books form becomming the same, should they be created at the same time, and it is private because otherwise it might as well just have been in main, which could be an improvement
        private static Random rangen = new Random();

        //value between 1 - 100 if it's zero, I know something is wrong, or it was manually created to be so.
        private int condition = 0;
            
        //rarity is the same as condition, but rarity. these two are private becasue I don't want to accidentaly change them somewhere else in the program.
        private int rarity = 0;

        //the name of the book, could add a random book name generator
        public string name = "";

        //if the instance should generate a random book, this can be set to true when creating the new instance, and but also makes it so we can add manually created books
        public bool random = false;

        //if the item is cursed, a smart customer will see the curse and demand half price, less experienced customers will meet an unfortunate end if they buy the book.
        private bool cursed = false;

        //the value of the book, based of the condition and rarity
        private int value = 0;

        //the player assigned value to the book.
        public int pValue = 0;

        //this class is only for books but could really be upgraded to be a general items class.
        private string type = "book";

        //cunstructor
        public Book()
        {
            //if the book is supposed to be randomly generated, this will do so
            if (random)
            {
                //random stats
                condition = rangen.Next(1,101);
                rarity = rangen.Next(1, 101);

                //1 in ten chance the book is cursed
                if (rangen.Next(1,11) == 1) { cursed = true; }

                //her you could add a random name generator
                name = "random book name";
            }

            //calculating the value of the book.
            value = condition * rarity;




        }

        //display the stats of the book to the player
        public void PrintStats()
        {
            Console.WriteLine(name + "'s condition is " + condition+ ". rarity is " + rarity);



        }

        //get the condition of the book
        public int GetCon()
        {
            return condition;
        }

        //get the rarity of the book
        public int GetRar()
        {
            return rarity;
        }

        //see if the book is cursed
        public bool GetCur()
        {
            return cursed;
        }

        public int GetVal()
        {
            return value;
        }

        
        

    }
}
