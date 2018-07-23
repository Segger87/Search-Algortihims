using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SearchAlgorithms.TypesOfSearches;

namespace SearchAlgorithms
{
	public class Program
	{
		static void Main(string[] args)
		{
			var ToFindAWord = new DownloadWords();
			var IWantToUseA = new Searches();

			ToFindAWord.WordUserWantsToFind();
			IWantToUseA.LinearSearch(ToFindAWord);
			
		}	
	}
}
