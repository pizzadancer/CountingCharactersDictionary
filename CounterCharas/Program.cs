using System;
using System.Collections.Generic;
using System.IO;

namespace CounterCharas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counting Characters");
            // In this studio, you will write a program to count the number of times each character occurs in a string and then print the results to the console.
            string ipsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Console.WriteLine("Enter a string, type 'd' for default, or 'file' to pull from file: ");
            string input = Console.ReadLine();

            
            if (input.ToLower() == "file")
            {
                ipsum = File.ReadAllText("D:/testing.txt");
               /* Console.WriteLine(text);*/
            }
            else if (input.ToLower() != "d")
            {
                ipsum = input;
            }
            Console.WriteLine(ipsum);

            ipsum = ipsum.ToLower();
            Dictionary<char, int> ipsumDict = new Dictionary<char, int>();
            foreach (char letter in ipsum)
            {
                if ((!ipsumDict.ContainsKey(letter)) && (Char.IsLetter(letter))) 
                {
                    ipsumDict.Add(letter, 0);
                }
                
            }
            Console.WriteLine("Pre-Calc");
            foreach (KeyValuePair<char, int> entry in ipsumDict)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }

            foreach (char letter in ipsum)
            {
                if (Char.IsLetter(letter))
                {
                    ipsumDict[letter] += 1;
                }
                    
            }
            Console.WriteLine("Post-Calc");
            foreach (KeyValuePair<char, int> entry in ipsumDict)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
       
    }
}
/*ipsumDict[letter] += count;*/
/*Console.WriteLine(letter);*/
// currentLetterToAdd
// currentLetterToAddCount
// Add(currentLetterToAdd, currentLetterToAddCount)