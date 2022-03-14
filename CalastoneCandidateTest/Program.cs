using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CalastoneCandidateTest.Filters;

namespace CalastoneCandidateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordList = ReadFile("CalastoneFile.txt");
            var filters = new AllFilters();

            var result = filters.Apply(wordList);

            Console.WriteLine("{0}", result);

            return;
        }

        static List<string> ReadFile(string fName)
        {
            var fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fName);
            if (!File.Exists(fullPath))
                throw new FileNotFoundException(fullPath);

            var text = File.ReadAllText(fullPath);

            //use regex split to split on a number of delimiters, but retain punctuation
            var splitText = Regex.Split(text, @"(?<=[.,;:?)! ])").Where(s => s != " ").ToList<string>();

            return splitText;

        }
    }
}
