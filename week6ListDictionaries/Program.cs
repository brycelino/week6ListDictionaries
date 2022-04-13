using System;
using System.Collections.Generic; // Allows the use of lists and dictionaries 

namespace week6ListDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne(); // calls method problem one and executes the code inside the method 
            ProblemTwo(); // calls method problem two and executes the code inside 
        }
        static public void ProblemOne() // Declares a method for first problem
        {
            string input; // string input which will hold the users input 
            List<string> list = new List<string>(); // Intitializes the list function allows us to call it 

            while(true)
            {
                Console.WriteLine("Enter a name. Press enter with nothing typed to exit."); // asks the user to enter a name or enter on the keyboard to exit 
                input = Console.ReadLine(); // Declares input string as the users input from console.readline 
                if (input == "") //if the users leaves the writing space blank 
                    return; //and presses enter on their keyboard they will exit
                list.Add(input); // adds the users input from console.readline to the list 
                

                if (list.Count >= 3) // if user input has 3 + names it will display code below
                    Console.WriteLine("{0}, {1}, {2} and others likes your post.", list[0], list[1], list.Count -2);
                else if (list.Count == 2) // if user input has 2 names it will display code below
                    Console.WriteLine("{0} and {1} likes your post.", list[0], list[1]);
                else if (list.Count == 1) // if user input has 1 names it will display code below
                    Console.WriteLine("{0} likes your post.", list[0]);
        
            } 
           
        }
        /*Write a program that asks the user to enter a sentence. 
         * Display each unique letter in the sentence, 
         * and how many times each one appeared. 
         * You should use a Dictionary when solving this one!
         */
        static public void ProblemTwo()
        {
            Dictionary<char, int> dict = new Dictionary<char, int>(); // Intializes the dictionary function declares it as sentence 
            
            string userInput; // declares string for variable that will hold the user input 
            do
            {
                Console.WriteLine("Enter a sentence. Press enter with nothing typed to exit. "); // asks the user to enter a sentence or ok to exit
                userInput = Console.ReadLine(); //  obtains the users input and places it in the variable userinput 
                userInput = userInput.Replace(" ", string.Empty); // blank spaces will no longer be apart of the users input.

                foreach (char i in userInput) // for each loop that determines how many char are in user input
                {
                    if (dict.ContainsKey(i)) // if statement that checks if the dictionary contains a specified char
                    {
                        dict[i]++; // increments a specific char by 1 everytime it is used in the users input 
                    }
                    else
                    {
                        dict[i] = 1; // if the char appears once it is stil displayed 
                    }
                }
                    foreach(char i in userInput) //for each loop that determines how many char are in user input
                    {
                       if (dict[i] != 0 ) // if conditon that checks if a char is equal to 0
                        {
                            Console.WriteLine(i + "|" + dict[i].ToString()); // displays the single char on the left side and how many times it appears on the right side 
                            dict[i] = 0; // sets dictionary char to 0 so letters that were used multiple times wont appear twice on the letter side
                        }
                    
                    }
                
            } while (userInput != ""); // if the user enter all caps OK they will exit 
        }
    }
}
