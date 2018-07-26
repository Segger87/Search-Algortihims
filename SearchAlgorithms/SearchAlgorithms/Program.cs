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
			var randomWords = new Program().SelectWords().Take(amountOfSearchesToPerform);
			var search = new Searches();

			foreach (var word in randomWords)
			{
				search.LinearSearch(word);
				search.BinarySearch(word);
			}

			var combinedLinearSearchTime = TotalLinearSearchTimes(search);
			var combinedBinarySearchTime = TotalBinarySearchTimes(search);

			PrintResults(combinedLinearSearchTime, combinedBinarySearchTime, amountOfSearchesToPerform);	
			Console.ReadLine();
		}

		private IEnumerable<DownloadWords> SelectWords()
		{
			while (true)
			{
				yield return new DownloadWords
				{
				};
			}
		}

		public static TimeSpan TotalLinearSearchTimes(Searches search)
		{
			var combinedLinearSearchTime = new TimeSpan();

			foreach (var time in search.TotalTimeForLinearSearch)
			{
				combinedLinearSearchTime += time;
			}

			return combinedLinearSearchTime;
		}

		public static TimeSpan TotalBinarySearchTimes(Searches search)
		{
			var combinedBinarySearchTime = new TimeSpan();

			foreach (var time in search.TotalTimeForBinarySearch)
			{
				combinedBinarySearchTime += time;
			}

			return combinedBinarySearchTime;
		}

		public static void PrintResults(TimeSpan linear, TimeSpan binary, int num)
		{
			var differnceInSpeed = CalculateSearchTimeDifference(linear, binary);
			var percentageDifference = TimesFaster(linear, binary);

			Console.WriteLine($"Search is Complete.");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Total time for all Linear Searches are search is {linear} \nTotal time for all Binary Searches are {binary}");
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
