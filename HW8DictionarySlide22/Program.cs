using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8DictionarySlide22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instructions

            //Create the following Dictionary:

            //  Dictionary<string, int> animals = new Dictionary<string, int>();

            //      Add 6 animals in the following format:
            //          animals.Add("Bear", 4);
            //          animals.Add("Squid", 10);
            //          animals.Add("Bird", 2);
            //          “ ”
            //          “ ”
            //          “ ”

            Dictionary<string, int> animals = new Dictionary<string, int>();

            animals.Add("Aye aye", 2);
            animals.Add("Babirusa", 3);
            animals.Add("Caecilian", 10);
            animals.Add("Dabchick", 5);
            animals.Add("Emu", 8);
            animals.Add("Flamingo", 30);

            //  Run queries against the dictionary in the following format.
            //  Test different animals. Try animals that aren’t in the dictionary.
            //      if (dictionary.ContainsKey("Bear"))
            //          {
            //              int value = dictionary["Bear"];
            //              Console.WriteLine(“Bear has ” +value + ” legs.”);
            //          }

            if (animals.ContainsKey("Emu"))
            {
                int value = animals["Emu"];
                Console.WriteLine("There are " + value + " in your managerie.");
            }
            else
            {
                Console.WriteLine("You do not have this animal in your managerie.");
            }

            //  How can we make the previous queries more efficient to use?
            //  We could make a list of the queries we want to run and have a loop check if each is a key.

            List<string> search = new List<string>();
            search.Add("Bear");
            search.Add("Aye aye");
            search.Add("Caecilian");
            search.Add("Parrot");

            foreach (string creature in search)
                if (animals.ContainsKey(creature))
                {
                    int value = animals[creature];
                    Console.WriteLine("There are " + value + " in your managerie.");
                }
                else
                {
                    Console.WriteLine("You do not have this animal in your managerie.");
                }

        }
    }
}
