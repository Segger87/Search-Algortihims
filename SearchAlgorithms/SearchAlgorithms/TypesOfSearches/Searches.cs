using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SearchAlgorithms.TypesOfSearches
{
	public class Searches
	{
		public List<TimeSpan> TotalTimeForLinearSearch = new List<TimeSpan>();
		public List<TimeSpan> TotalTimeForBinarySearch = new List<TimeSpan>();

		public string LinearSearch(SortedWords word)
		{
			var methodExecutionTime = Stopwatch.StartNew();

			for (int i = 0; i < word.WordsSeperatedIntoArray.Length; i++)
			{
				if (word.WordsSeperatedIntoArray[i] == word.RandomWord)
				{
					methodExecutionTime.Stop();
					TotalTimeForLinearSearch.Add(methodExecutionTime.Elapsed);
					Console.WriteLine($"The Word {word.RandomWord} has been found using Linear Search, it is entry {i} in the array, it took { methodExecutionTime.Elapsed} Seconds to find");
					return word.RandomWord;
				}
			}
			Console.WriteLine("Sorry there is no match");
			return null;
		}

		public string BinarySearch(SortedWords words)
		{
			var methodExecutionTime = Stopwatch.StartNew();
			int leftSide = 0;
			int rightSide = words.WordsSeperatedIntoArray.Length;
			
			while (leftSide <= rightSide)
			{
				int middle = (leftSide + rightSide) / 2;

				if (string.Compare(words.RandomWord, words.WordsSeperatedIntoArray[middle]) == 0)
				{
					methodExecutionTime.Stop();
					TotalTimeForBinarySearch.Add(methodExecutionTime.Elapsed);
					Console.WriteLine($"The word {words.RandomWord} has been found at index value {middle} using Binary Search, it took {methodExecutionTime.Elapsed} to find");
					return words.RandomWord;
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

			return null;
		}
	}
}
