using System;
using System.Collections.Generic;
using System.IO;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Solve();
            }
        }

        private static void Solve()
        {
            string input = null;
            int result = 0;
            HashSet<int> freq = new HashSet<int>();
            freq.Add(result);   //Initial value
            string firstTwiceSet = string.Empty;
            bool foundDuplicate = false;
            bool firstItteration = true;
            var allValues = File.ReadAllLines("../../input.in");
            int index = 0;
            while (index < allValues.Length || (!foundDuplicate && (index=0)==0))
            {
                input = allValues[index];
                var number = int.Parse(input.Substring(1));
                switch (input[0])
                {
                    case '-':
                        result -= number;
                        break;
                    case '+':
                        result += number;
                        break;
                }
                if (!foundDuplicate && freq.Contains(result))
                {
                    Console.WriteLine("First duplicate = {0}", result);
                    foundDuplicate = true;
                }
                freq.Add(result);
                index++;
                if(firstItteration && index == allValues.Length)
                {
                    Console.WriteLine("Result = {0}", result);
                    firstItteration = false;
                }
            }
        }
    }
}