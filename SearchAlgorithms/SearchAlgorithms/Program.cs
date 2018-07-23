using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			
			var arrayOfDownloadedWords = DownloadWords();
			var findThisWord = WordUserWantsToFind();
			LinearSearch(arrayOfDownloadedWords, findThisWord);
			Console.ReadLine();
		}

		private static string[] DownloadWords()
		{
			string wordsDownloadedFromSource;
			using (var webClient = new WebClient())
			{
				wordsDownloadedFromSource = webClient.DownloadString(@"https://raw.githubusercontent.com/dwyl/english-words/master/words.txt");
			}

			var wordsSplitIntoArray = SplitDownloadedWordsIntoArray(wordsDownloadedFromSource);
			return wordsSplitIntoArray;
		}

		private static string[] SplitDownloadedWordsIntoArray(string words)
		{
			var arrayOfDownloadedWords = words.Split('\n');
			return arrayOfDownloadedWords;
		}

		private static void LinearSearch(string[] arrayOfWords, string userGeneratedWord)
		{
			for (int i = 0; i < arrayOfWords.Length; i++)
			{
				if(arrayOfWords[i] == userGeneratedWord)
				{
					Console.WriteLine($"{userGeneratedWord} is a match, it is entry {i} in the array");
					return;
				}
			}

			Console.WriteLine("Sorry there is no match");
		}

		private static string WordUserWantsToFind()
		{
			Console.WriteLine("Please Enter the word you wish to search for:");
			return Console.ReadLine();
		}
	}
}
