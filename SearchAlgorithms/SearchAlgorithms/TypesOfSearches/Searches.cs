using System;

namespace SearchAlgorithms.TypesOfSearches
{
	public class Searches
	{
		public void LinearSearch(DownloadWords d)
		{
			for (int i = 0; i < d.WordsSeperatedIntoArray.Length; i++)
			{
				if (d.WordsSeperatedIntoArray[i] == d.RandomWord)
				{
					Console.WriteLine($"{d.RandomWord} is a match, it is entry {i} in the array");
					Console.ReadLine();
					return;
				}
			}

			Console.WriteLine("Sorry there is no match");
			Console.ReadLine();
		}

		public void BinarySearch(DownloadWords words)
		{ 
			int endOfArray = words.WordsSeperatedIntoArray.Length;
			int middleOfArray = words.WordsSeperatedIntoArray.Length / 2;
			int frontOfArray = 0;

			while (frontOfArray <= endOfArray)
			{
				int middle = endOfArray + ((frontOfArray - endOfArray) >> 1);

				if (string.Compare(words.RandomWord, words.WordsSeperatedIntoArray[middle], true) == 0)
				{
					Console.WriteLine($"The word {words.RandomWord} hasbeen found at index value {middle} using Binary Search");
					Console.ReadLine();
					return;
				}
				else if (string.Compare(words.WordsSeperatedIntoArray[middle], words.RandomWord, true) > 0)
				{
					endOfArray = middle;
				}
				else if (string.Compare(words.WordsSeperatedIntoArray[middle], words.RandomWord, true) < 0)
				{
					frontOfArray = middle;
				}
				else
				{
					Console.WriteLine("Sorry there is no match");
				}	
			}
		}
	}
}
