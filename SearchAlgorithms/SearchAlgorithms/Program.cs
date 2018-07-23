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
			Console.ReadLine();
		}

		public static string[] DownloadWords()
		{
			string wordsDownloadedFromSource;
			using (var webClient = new WebClient())
			{
				wordsDownloadedFromSource = webClient.DownloadString(@"https://raw.githubusercontent.com/dwyl/english-words/master/words.txt");
			}

			var wordsSplitIntoArray = SplitDownloadedWordsIntoArray(wordsDownloadedFromSource);
			return wordsSplitIntoArray;
		}

		public static string[] SplitDownloadedWordsIntoArray(string words)
		{
			var arrayOfDownloadedWords = words.Split('\n');
			return arrayOfDownloadedWords;
		}
	}
}
