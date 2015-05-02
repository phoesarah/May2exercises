using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madlibs
{
    class Program
    {//3) Write a madlibs style exercise that contains 3 different "stories". Prompt the user for Story 1, story 2, and story 3. Based on their input, begin prompting for user 
        //input for values. After all values for the story has been entered, display the mad libs story and prompt the user to either 
        //enter a story number to do another, or enter a negative number to end the program.
        static void Main(string[] args)
        {
            int input = 1;
            while (input > 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Which story would you like to hear? please enter 1, 2 or 3, if you don't want to hear a story, please enter a negative number");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.Write("Please enter a proper noun: ");
                        string a = Console.ReadLine();
                        Console.Write("Please enter a noun: ");
                        string b = Console.ReadLine();
                        Console.Write("Please enter a feeling: ");
                        string c = Console.ReadLine();
                        Console.Write("Please enter a verb in past tense: ");
                        string d = Console.ReadLine();                        
                        Console.Write("Please enter a sentence: ");
                        string z = Console.ReadLine();
                        Console.Write("Please enter a noun: ");
                        string e = Console.ReadLine();
                         Console.Write("Please enter a verb in past tense: ");
                        string f = Console.ReadLine();
                        Console.WriteLine("One day " + a + " was walking down the street and saw a " + b  + ", to which they exclaimed: " + z + "! " + "They felt " + c + " so they " + d + " to the nearest " + e + " and " + f + "." );
                        Console.ReadLine();
                       break;
                    case 2:
                       Console.Write("Please enter a proper noun: ");
                        string g = Console.ReadLine();
                        Console.Write("Please enter a place: ");
                        string h = Console.ReadLine();
                        Console.Write("Please enter a noun: ");
                        string i = Console.ReadLine();
                        Console.Write("Please enter a verb: ");
                        string j = Console.ReadLine();
                        Console.Write("Please enter a different verb: ");
                        string k = Console.ReadLine();
                         Console.Write("Please enter a feeling: ");
                        string l = Console.ReadLine();
                       Console.WriteLine( g + " went to the " + h + " to get a " + i + " so they can " + j + " without having to " + k + " this made them feel " + l + ".");
                       break;
                    case 3:
                        Console.Write("Please enter a feeling: ");
                        string m = Console.ReadLine();
                        Console.Write("Please enter a verb: ");
                        string n = Console.ReadLine();
                        Console.Write("Please enter another verb: ");
                        string o = Console.ReadLine();
                        Console.Write("Please enter a job title: ");
                        string p = Console.ReadLine();
                        Console.Write("Please enter a different verb: ");
                        string q = Console.ReadLine();
                         Console.Write("Please enter an animal: ");
                        string r = Console.ReadLine();
                       Console.WriteLine( "When I feel " + m + ", I like to " + n + " until I " + o + ".  That way, when the " + p + " comes to my house.  He won't " + q + "  on my pet " + r + ".");
                       break;
                    default:
                       Console.WriteLine("Please Enter 1, 2, or 3");
                       break;

                }
             
            }
                
        }
       // static string Story1(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
       // {
       //     string answer = "One day " + a.ToUpper + "was wa;");
         //   return answer;   I don't know how to concantenate string in method? 
      //  }
            
    }
}
