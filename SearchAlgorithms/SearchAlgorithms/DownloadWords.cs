using System;
using System.Net;

namespace SearchAlgorithms
{
	public class DownloadWords 
	{
		public string WordsFromSource { get; set; }

		public DownloadWords()
		{
			using (var webClient = new WebClient())
			{
				WordsFromSource = webClient.DownloadString(@"https://raw.githubusercontent.com/dwyl/english-words/master/words.txt");
			}
		}
	}
}
