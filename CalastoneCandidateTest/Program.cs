using System;
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
            var text = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "CalastoneFile.txt"));

            //use regex split to split on a number of delimiters, but retain punctuation
            var splitText = Regex.Split(text, @"(?<=[.,;:?)! ])").Where(s => s != " ").ToList<string>();
            var filters = new AllFilters();

            var result = filters.Apply(splitText);

            Console.WriteLine("{0}", result);

            return;
        }
    }
}
