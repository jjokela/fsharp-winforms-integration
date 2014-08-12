
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SortingAlgorithms;
using System.Diagnostics;
using SorterUtility;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 5, 4, 3, 2, 1 };

            var sorter = new Sorter();

            var sortResults = sorter.GetSortResults(arr);
            foreach (var result in sortResults)
            {
                Console.WriteLine("{0}: {1} ms", result.Name, result.SortTimeInMs);
            }

            Console.ReadLine();
        }
    }
}
