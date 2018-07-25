using System;

namespace SearchAlgorithms.TypesOfSearches
{
	public class Searches
	{
		public void LinearSearch(DownloadWords d)
		{
			for (int i = 0; i < d.WordsSeperatedIntoArray.Length; i++)
			{
				if (d.WordsSeperatedIntoArray[i] == d.WordBeingSearchedFor)
				{
					Console.WriteLine($"{d.WordBeingSearchedFor} is a match, it is entry {i} in the array");
					Console.ReadLine();
					return;
				}
			}

			Console.WriteLine("Sorry there is no match");
			Console.ReadLine();
		}

		public void BinarySearch(DownloadWords words)
		{ 
			int frontOfArray = words.WordsSeperatedIntoArray.Length - 1;
			int middleOfArray = words.WordsSeperatedIntoArray.Length / 2;
			int endOfArray = 0;

			while (endOfArray <= frontOfArray)
			{
				int middle = frontOfArray + ((endOfArray - frontOfArray) >> 1);

				if (string.Compare(words.WordBeingSearchedFor, words.WordsSeperatedIntoArray[middle], true) == 0)
				{
					Console.WriteLine($"The word has been found at index value {middle} using Binary Search");
					Console.ReadLine();
					return;
				}
				else if (string.Compare(words.WordsSeperatedIntoArray[middle], words.WordBeingSearchedFor, true) > 0)
				{
					frontOfArray = middle;
				}
				else if (string.Compare(words.WordsSeperatedIntoArray[middle], words.WordBeingSearchedFor, true) < 0)
				{
					endOfArray = middle;
				}

				Console.WriteLine("Sorry there is no match");
			}
		}
	}
}
