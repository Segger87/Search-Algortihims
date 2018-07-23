using System;

namespace SearchAlgorithms.TypesOfSearches
{
	public class Searches
	{
		public void LinearSearch(DownloadWords d)
		{
			for (int i = 0; i < d.WordsFromSourceSplitIntoArray.Length; i++)
			{
				if (d.WordsFromSourceSplitIntoArray[i] == d.WordBeingSearchedFor)
				{
					Console.WriteLine($"{d.WordBeingSearchedFor} is a match, it is entry {i} in the array");
					Console.ReadLine();
					return;
				}
			}

			Console.WriteLine("Sorry there is no match");
			Console.ReadLine();
		}
	}
}
