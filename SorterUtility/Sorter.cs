using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SorterUtility
{
    public class Sorter
    {
        public List<SortResult> GetSortResults(int[] arr)
        {
            List<SortResult> sortResults = new List<SortResult>();

            sortResults.Add(GetSortResult("BubbleSort", arr));
            sortResults.Add(GetSortResult("InsertionSort", arr));
            sortResults.Add(GetSortResult("SelectionSort", arr));
            sortResults.Add(GetSortResult("MergeSort", arr));
            sortResults.Add(GetSortResult("QuickSort", arr));

            return sortResults;
        }

        private SortResult GetSortResult(string name, int[] arr)
        {
            int[] sortedArray;
            Stopwatch watch = new Stopwatch();
            long elapsedTime;

            switch (name)
            {
                case "BubbleSort":
                    watch.Start();
                    sortedArray = BubbleSort.Sort(arr);
                    elapsedTime = watch.ElapsedMilliseconds;
                    break;
                case "InsertionSort":
                    watch.Start();
                    sortedArray = InsertionSort.Sort(arr);
                    elapsedTime = watch.ElapsedMilliseconds;
                    break;
                case "SelectionSort":
                    watch.Start();
                    sortedArray = SelectionSort.Sort(arr);
                    elapsedTime = watch.ElapsedMilliseconds;
                    break;
                case "MergeSort":
                    watch.Start();
                    sortedArray = MergeSort.Sort(arr);
                    elapsedTime = watch.ElapsedMilliseconds;
                    break;
                case "QuickSort":
                    watch.Start();
                    sortedArray = QuickSort.Sort(arr);
                    elapsedTime = watch.ElapsedMilliseconds;
                    break;
                default:
                    throw new ArgumentException("Unknown algorithm name");
            }
            watch.Stop();

            return new SortResult { Name = name, SortedArray = sortedArray, SortTimeInMs = elapsedTime };
        }
    }

    public class SortResult
    {
        public string Name { get; set; }
        public int[] SortedArray { get; set; }
        public long SortTimeInMs { get; set; }
    }
}
