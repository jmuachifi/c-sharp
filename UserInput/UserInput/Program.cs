﻿using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type your username and press enter
            Console.WriteLine("Enter your username: ");

            //Create a string variable and get user input from the keyboard and store it in the variable
            string username = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age =  Convert.ToInt32(Console.ReadLine());

            //Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is : " + username + " and His age is " + age);
        }
    }
}
