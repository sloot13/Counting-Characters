using System;
using System.Collections.Generic;

namespace Counting_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] charString = input.ToCharArray();
            Dictionary<char, int> counter = new Dictionary<char, int>();

            
            foreach ( char c in charString)
            {
                if(counter.ContainsKey(c))
                {
                    counter[c]++;
                } 
                else
                {
                    counter.Add(c, 1);
                }
            }

            foreach (KeyValuePair<char, int> letter in counter)
            {
                Console.WriteLine(letter.Key + ": " + letter.Value);
            }
        }
    }
}
