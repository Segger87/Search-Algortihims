using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
	public class SortedWords
	{
		public string[] WordsSeperatedIntoArray { get; set; }
		public string WordBeingSearchedFor { get; set; }
		public string RandomWord { get; set; }

		public SortedWords(DownloadWords dw)
		{
			SplitDownloadedWordsIntoArray(dw);
		}
		private void SplitDownloadedWordsIntoArray(DownloadWords dw)
		{
			WordsSeperatedIntoArray = dw.WordsFromSource.Split('\n');
			GenerateRandomWord();
		}

		public void WordUserWantsToFind()
		{
			Console.WriteLine("Please Enter the word you wish to search for:");
			WordBeingSearchedFor = Console.ReadLine();
		}

		private void GenerateRandomWord()
		{
			var random = new Random();
			int randomNumber = random.Next(0, WordsSeperatedIntoArray.Length);
			RandomWord = WordsSeperatedIntoArray[randomNumber];
		}
	}
}
