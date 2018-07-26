using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SearchAlgorithms.TypesOfSearches
{
	public class Searches
	{
		public List<TimeSpan> TotalTimeForLinearSearch = new List<TimeSpan>();
		public List<TimeSpan> TotalTimeForBinarySearch = new List<TimeSpan>();
		public void LinearSearch(DownloadWords d)
		{
			var methodExecutionTime = Stopwatch.StartNew();

			for (int i = 0; i < d.WordsSeperatedIntoArray.Length; i++)
			{
				if (d.WordsSeperatedIntoArray[i] == d.RandomWord)
				{
					methodExecutionTime.Stop();
					TotalTimeForLinearSearch.Add(methodExecutionTime.Elapsed);
					Console.WriteLine($"{d.RandomWord} is a match, it is entry {i} in the array, it took { methodExecutionTime.Elapsed} Seconds to find");
					return;
				}
			}
			Console.WriteLine("Sorry there is no match");
		}

		public void BinarySearch(DownloadWords words)
		{
			var methodExecutionTime = Stopwatch.StartNew();
			int leftSide = 0;
			int rightSide = words.WordsSeperatedIntoArray.Length - 1;
			
			while (leftSide <= rightSide)
			{
				int middle = (leftSide + rightSide) / 2;

				if (string.Compare(words.RandomWord, words.WordsSeperatedIntoArray[middle]) == 0)
				{
					methodExecutionTime.Stop();
					TotalTimeForBinarySearch.Add(methodExecutionTime.Elapsed);
					Console.WriteLine($"The word {words.RandomWord} has been found at index value {middle} using Binary Search, it took {methodExecutionTime.Elapsed} to find");
					return;
				}
				if (string.Compare(words.RandomWord, words.WordsSeperatedIntoArray[middle]) > 0)
				{
					leftSide = middle + 1;
				}
				else 
				{
					rightSide = middle - 1;
				}
			}
		}
	}
}
