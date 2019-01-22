using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             John Williams
             DVP1
             Assigment: Grocery Calculator
             01-20-2019
             */
             //Making sure the repo folder works test test test

            //Introduction to application
            Console.WriteLine("Welcome to the Grocery Calculator.");

            //Lets get the users name
            Console.WriteLine("Lets get started. Please type your name and then press enter.");

            //Listen for users name here
            //Create a variable to catch the returned text string
            string customerName = Console.ReadLine();

            //Greet the user!
            Console.WriteLine("Hello " + customerName + " . Welcome to the Grocery Calculator!");

            //Ask the user for quantities
            //Tell the user what we are doing!!
            Console.WriteLine("Let's find out how many items you will be purchasing!\r\nPlease enter how many carrots you would like to buy and press enter:");

            //Listen for the quantity ---- but as a text string!! Then convert
            string carrotString = Console.ReadLine();

            //Convert string to a number datatype
            double carrotNumber = double.Parse(carrotString);

            //Ask user for quantity
            Console.WriteLine("Please enter how many potatos you want to buy:");

            //Store the answer as a string
            string potatoString = Console.ReadLine();


            //Convert string to a integer
            double potatoNumber = double.Parse(potatoString);

            //Ask user for quantity
            Console.WriteLine("Please enter how many onions you want to buy:");

            //Store the answer as a string
            string onionString = Console.ReadLine();


            //Convert string to a integer
            double onionNumber = double.Parse(onionString);

            //Use to get total items in cart
            double cartItems = carrotNumber * 1 + potatoNumber * 1 + onionNumber * 1;


            //Add in description text
            Console.WriteLine("You have this many grocery items in your cart: " + cartItems);

            Console.Write("\r\n");

            //Ask the user for prices
            //Tell the user what we are doing!!
            Console.WriteLine("Let's find out how much your items will cost!\r\nPlease enter how much each carrot will cost and press enter:");



        }
    }
}