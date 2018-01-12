/***********************************************************
 * Author: Makram Ibrahim
 * Brother Blazzard,
 * CIT 365 - .NET Software Development
 * Summary:
 * This program is a simple console application using Visual
 * Studio. 
 * *********************************************************/
using System;

namespace ConsoleAppWeek1
{
    class Program
    { 
        /************************************
         * Main(): will call other functions
         * to display!
         * **********************************/
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            HelloWorld();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            GetName("Makram Ibrahim", "Utah, United States of America");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Display();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            GlazerCalc();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");

            do
            {
                Choice();
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            } while (true);

         
        }

        /*********************************
         * Choice(): Will prompt the user for 
         * Input either yes or no.
         *********************************/
        static void Choice()
        {
            string yOn;
            Console.Write("To continue press (Y) to exit press (N): ");
            yOn = Convert.ToString(Console.ReadLine());

            if (yOn == "y" || yOn == "Y")
            { 
                Draw(5);
            }

            if (yOn == "n" || yOn == "N")
            {
                Console.WriteLine("Thanks for playing!");
                System.Environment.Exit(1);
            }
        }

        /**************************************
         * Display a simple "Hello, World!"
         * ************************************/
        static void HelloWorld()
        {
            Console.WriteLine("My First Program in C#: Hello, World!");
        }

        /********************************************
         * Add two more WriteLine statements directly 
         * after the Console.WriteLine("Hello World!"); 
         * statement that display 1) your full name, and 2) 
         * your location in terms of state or country.
         *********************************************/

        static void GetName(string name, string location)
        {
            Console.WriteLine($"My Name is {name}");
            Console.WriteLine($"I live in {location}");
            Console.WriteLine("Hello " + name + "!");
        }

       /*************************************
        * Add a line that displays and labels 
        * the number of days until Christmas.
        ************************************/
        static void Display()
        {
            // Add a line the writes the current date.
            var curTime = DateTime.Now;
            Console.WriteLine("Date: " + curTime);

            var christmasDate = DateTime.Parse("12/25/2018");

            var timeLeft = christmasDate - curTime;
         
            Console.WriteLine($"Number of Days until Christmas are {timeLeft.Days} days left!");
        }

        /********************************************
         * Add the program example from section 2.1 of 
         * the C# Programming Yellow Book in the required 
         * readings. In addition to the given code, 
         * include the following additions: 
         *********************************************/
        static double GetInput(double height, double width)
        {
            Console.WriteLine("Want to build a Pyramid?");
            Console.Write("Please Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a width: ");
            width = Convert.ToDouble(Console.ReadLine());

            double total = height * width;
            Console.WriteLine("You total height and width is: " + total);
            Console.WriteLine("Enjoy watching your pyramid");
            return total;
        }

        /************************************
         * Draw(): will draw a simple pyramids 
         ************************************/
         static int Draw(int num)
        {
          
                num = Convert.ToInt32(GetInput(0, 0));
           
                for (int i = 1; i <= num; i++)

                {
                    for (int j = i; j <= num; j++)
                    {
                        Console.Write("  ");
                    }
                    for(int k = 1; k <= i * 2 -1; k++ )
                    {
                        Console.Write("*" + " ");
                    }
                    Console.WriteLine();
                }
                return num;
        }

        /***************************************************
         * Add the program example from section 2.1 of the C# 
         * Programming Yellow Book in the required readings. 
         * In addition to the given code, include the following 
         * additions: 
         ****************************************************/
        static void GlazerCalc()
        {
            double width, height, glassArea, woodLength;
            string widthString = "", heightString = "";

            Console.Write("Enter glass width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter glass hieght: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea =  2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }
        
    }
}
