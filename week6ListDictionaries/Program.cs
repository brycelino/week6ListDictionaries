using System;
using System.Collections.Generic;
/* If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2]
and [Number of Other People] others like your post.
 * Write a program and continuously ask the user to enter different names
until the user presses Enter (without supplying a name).
Depending on the number of names provided, display a message based on the above pattern
You should use a List when solving this one!
    */
namespace week6ListDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            problemOne();
            
        }
        static public void problemOne() // Declares a method for first problem
        {
            string input;
            List<string> list = new List<string>();

            do
            {
                Console.WriteLine("Enter a name. When done press enter without any words to exit.");
                input = Console.ReadLine();
                if (input == "")
                    return;
                list.Add(input);
              //  Console.WriteLine(input + " likes your post.");

                if (list.Count > 3)
                    Console.WriteLine( "{0}, {1} and {2} likes your post.", list[0], list[1],list.Count-1);
                 //for(int i = 0; i < list.Count; i++)
                 // {
                 //    Console.WriteLine(list[i] + " likes your post.");
                 //  }

            } while (input != ""); 
           
        }
    }
}
