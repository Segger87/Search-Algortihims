using System;
using System.Net;

namespace SearchAlgorithms
{
	public class DownloadWords 
	{
		public string WordsFromSource { get; set; }
		public string[] WordsSeperatedIntoArray { get; set; }
		public string WordBeingSearchedFor { get; set; }
		public string RandomWord { get; set; }

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
			WordsSeperatedIntoArray = WordsFromSource.Split('\n');
			GenerateRandomWord();
		}

		public void WordUserWantsToFind()
		{
			Console.WriteLine("Please Enter the word you wish to search for:");
			WordBeingSearchedFor = Console.ReadLine();
		}

		public void GenerateRandomWord()
		{
			var random = new Random();
			int randomNumber = random.Next(0, WordsSeperatedIntoArray.Length);
			RandomWord = WordsSeperatedIntoArray[randomNumber];
		}
	}
}
