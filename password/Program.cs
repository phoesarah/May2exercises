﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    class Program
    { //Write a cipher that takes a string "password", and converts the password into an integer number
        //based on the int value of each letter in the word. For checking your answers, the password "Welcome" evaluates to the integer 716.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a password");
            string password = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < password.Length; i++)
			{
                sum += password[i];
			 }                  
                           
            Console.WriteLine(Convert.ToString(sum));
            Console.ReadLine();
        }
    }
}
