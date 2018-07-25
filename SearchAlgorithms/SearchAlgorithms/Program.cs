using SearchAlgorithms.TypesOfSearches;

namespace SearchAlgorithms
{
	public class Program
	{
		static void Main(string[] args)
		{
			var ToFindThisWord = new DownloadWords();
			var IWantToUseA = new Searches();

			ToFindThisWord.WordUserWantsToFind();
			IWantToUseA.LinearSearch(ToFindThisWord);
			IWantToUseA.BinarySearch(ToFindThisWord);
		}
	}
}
