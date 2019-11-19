using System;
using static System.Console;

namespace Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] roster = { "Alice", "Alex", "Ben", "Alisha", "Harry", "Chris", "Luke" };

            Array.Sort(roster);//Sorts the array

            WriteLine("Enter an Name:");
            string name = ReadLine();
            
            while(name != "EXIT")
            {
                int post = Array.BinarySearch(roster, name);

                if(post >= 0)
                {
                    WriteLine("{0} is already in use, choose another", name);
                }
                else
                {
                    string[] copy = new string[roster.Length + 1];
                    roster.CopyTo(copy, 0);
                    copy[copy.Length - 1] = name;
                    Array.Sort(copy);

                    roster = new string[copy.Length];
                    copy.CopyTo(roster, 0);
                }

                WriteLine("Enter an Name:");
                name = ReadLine();

            }

            WriteLine("");
            //print out the roster
            for (int p = 0; p < roster.Length; ++p)
            {
                WriteLine(roster[p]);
            }
        }
    }
}
