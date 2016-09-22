﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class userInterface
    {
        //There are no backing field variables because we don't need any
        //There are no properties because we don't have any backing fields
        //There are also, no constructors. We will just use the default that is
        //automatically provided to us.

        //This class essentially becomes a collection of methods that do work.

        //Get user input.
        public int GetUserInput()
        {
            //Call the printMenu method that is private to the class
            this.printMenu();

            //Get input from the console.
            string input = Console.ReadLine();

            //Continue to loop while the input is not a valid choice
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                //Since it is not valid, output a message saying so
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();

                //re-display the menu in case the user forgot what they could do.
                this.printMenu();

                //re-get the input from the user
                input = Console.ReadLine();
            }

            //At this point, the input is valid, so we can return the parse of it.
            return Int32.Parse(input);
        }

        public void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        private void printMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Find item by item ID");
            Console.WriteLine("3. Add new item to Wine List");
            Console.WriteLine("4. Exit");
        }


    }
}