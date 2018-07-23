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
			var p = new Program();
			p.DownloadWords();
		}

		public string[] DownloadWords()
		{
			string wordsDownloadedFromSource;
			using (var webClient = new WebClient())
			{
				wordsDownloadedFromSource = webClient.DownloadString(@"https://raw.githubusercontent.com/dwyl/english-words/master/words.txt");
			}

			var arrayOfDownloadedWords = wordsDownloadedFromSource.Split('\n');

			return arrayOfDownloadedWords;

		}
	}
}
