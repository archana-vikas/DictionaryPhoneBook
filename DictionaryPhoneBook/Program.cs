using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            string[] userInput = new string[2];
            //For loop for Adding entries in the phonebook//
            for (int i = 0; i < n; i++)
            {
                userInput = Console.ReadLine().Split(' ');
                phoneBook.Add(userInput[0], userInput[1]);
            }

            string name = Console.ReadLine();
            while (!string.IsNullOrEmpty(name))
            {
                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"{name}={phoneBook[name]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
                name = Console.ReadLine();
            } 
            Console.ReadLine();
        }
    }
}
