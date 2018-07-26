using SearchAlgorithms.TypesOfSearches;
using System.Linq;
using System;
using System.Collections.Generic;

namespace SearchAlgorithms
{
	public class Program
	{
		static void Main(string[] args)
		{
			int amountOfSearchesToPerform = 100;
			var downloadWords = new DownloadWords();
			var randomWords = new Program().SelectWords(downloadWords).Take(amountOfSearchesToPerform);	
			var search = new Searches();

			foreach (var word in randomWords)
			{
				search.LinearSearch(word);
				search.BinarySearch(word);
			}

			var combinedLinearSearchTime = TotalSearchTimes("linear", search);
			var combinedBinarySearchTime = TotalSearchTimes("binary", search);
			PrintResults(combinedLinearSearchTime, combinedBinarySearchTime, amountOfSearchesToPerform);	
			Console.ReadLine();
		}

		private IEnumerable<SortedWords> SelectWords(DownloadWords dw)
		{
			while (true)
			{
				yield return new SortedWords(dw)
				{
				};
			}
		}

		public static TimeSpan TotalSearchTimes(string type, Searches time)
		{
			var combinedSearchTime = new TimeSpan();
			switch (type.ToLower())
			{
				case "linear":
					foreach (var t in time.TotalTimeForLinearSearch)
					{
						combinedSearchTime += t;
					}
					break;
				case "binary":
					foreach (var t in time.TotalTimeForBinarySearch)
					{
						combinedSearchTime += t;
					}
					break;
				default:
					Console.WriteLine("Sorry that is not a recognised search type");
					break;
			}
			
			return combinedSearchTime;
		}

		public static void PrintResults(TimeSpan linear, TimeSpan binary, int num)
		{
			var differnceInSpeed = CalculateSearchTimeDifference(linear, binary);
			var percentageDifference = TimesFaster(linear, binary);

			Console.WriteLine($"Search is Complete.");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Total time for all Linear searches is {linear} \nTotal time for all Binary Searches are {binary}");
			Console.WriteLine($"Over {num} iterations Binary search is {differnceInSpeed} seconds quicker than Linear Search.");
			Console.WriteLine($"Binary search is {percentageDifference} times faster");
			Console.ResetColor();
		}

		public static TimeSpan CalculateSearchTimeDifference(TimeSpan linear, TimeSpan binary)
		{
			return (linear - binary);
		}

		public static double TimesFaster(TimeSpan linear, TimeSpan binary)
		{		
			return linear.TotalMilliseconds / binary.TotalMilliseconds;
		}
	}
}
