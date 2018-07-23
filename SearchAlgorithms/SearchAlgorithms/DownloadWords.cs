using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
	public class DownloadWords 
	{
		public string WordsFromSource { get; set; }
		public string[] WordsFromSourceSplitIntoArray { get; set; }
		public string WordBeingSearchedFor { get; set; }

		public DownloadWords()
		{
			using (var webClient = new WebClient())
			{
				WordsFromSource = webClient.DownloadString(@"https://raw.githubusercontent.com/dwyl/english-words/master/words.txt");
			}

			SplitDownloadedWordsIntoArray();
		}

		public void SplitDownloadedWordsIntoArray()
		{
			WordsFromSourceSplitIntoArray = WordsFromSource.Split('\n');
		}

		public void WordUserWantsToFind()
		{
			Console.WriteLine("Please Enter the word you wish to search for:");
			WordBeingSearchedFor = Console.ReadLine();
		}
	}
}
