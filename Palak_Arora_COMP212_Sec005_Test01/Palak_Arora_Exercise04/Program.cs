using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Palak_Arora_Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dictionary = CollectWords();

            DisplayDictionary(dictionary); // display sorted dictionary content
            Console.ReadLine();
        }
        private static SortedDictionary<string, int> CollectWords()
        {
            // create a new sorted dictionary
            var dictionary = new SortedDictionary<string, int>();

            Console.WriteLine("Enter a string: "); // prompt for user input
            string input = Console.ReadLine(); // get input

            // split input text into tokens
            string[] words = Regex.Split(input, @"\s+");

            // processing input words
            foreach (var word in words)
            {
                var key = word.ToLower(); // get word in lowercase

                // if the dictionary contains the word
                if (dictionary.ContainsKey(key))
                {
                    ++dictionary[key];
                }
                else
                {
                    // add new word with a count of 1 to the dictionary
                    dictionary.Add(key, 1);
                }
            }

            return dictionary;
        }

        private static void DisplayDictionary<K, V>(
      SortedDictionary<K, V> dictionary)
        {

            Console.WriteLine(
                   $"\nSorted dictionary\n************************\n{"Key",-12}{"Value",-12}");

            // generate output for each key in the sorted dictionary
            // by iterating through the Keys property with a foreach statement
            string[] d = new string[dictionary.Count];
            int j = 0;
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key,-12}{dictionary[key],-12}");

                int a = Convert.ToInt32(dictionary[key]);

                // store the values of repeated words
                if (a > 1 && a< 3)                                 
                {
                    d[j] = Convert.ToString(key);
                    j++;// if repeated it will store the resulted words in to string
                }

            }
            Console.WriteLine("\nDuplicate words which are repeated minimum number of times\n********************");
            for (int i = 0; i < j; i++)
            {
                Console.Write(d[i] + "  ");
            }

        }
    }
}
