using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SearchAlgorithms.Test
{
	[TestClass]
	public class DownloadwordsTest
	{
		[TestMethod]
		public void ExpectedLengthOfDownloadWordsArray_ExpectedLengthOfDownloadWordsArray_AreEqual()
		{
			//Arrange
			var words = new DownloadWords();
			var expected = new SortedWords(words);
			
			//Act
			var actual = new SortedWords(words);

			//Assert
			Assert.AreEqual(expected.WordsSeperatedIntoArray.Length, actual.WordsSeperatedIntoArray.Length);
		}

		[TestMethod]
		public void BinarySearch_LinearSearch_Results_AreSame()
		{
			//Arrange
			var randomWords = new DownloadWords();
			var selectedWords = new Program().SelectWords(randomWords).Take(1);

			//Act
			var search = new TypesOfSearches.Searches();

			foreach (var word in selectedWords)
			{
				//Assert
				Assert.AreSame(search.BinarySearch(word), search.LinearSearch(word));
			}	
		}

		[TestMethod]
		public void IfBinarySearch_CantFindAMatch_ItsReturnValue_IsNull()
		{
			//Arrange
			var randomWords = new DownloadWords();
			var selectedWords = new Program().SelectWords(randomWords).Take(1);

			//Act
			var search = new TypesOfSearches.Searches();

			foreach (var word in selectedWords)
			{
				word.RandomWord = "BeastModeBarry";
				//Assert
				Assert.IsNull(search.BinarySearch(word));
			}	
		}

		[TestMethod]
		public void IfLinearSearch_CantFindAMatch_ItsReturnValue_IsNull()
		{
			//Arrange
			var randomWords = new DownloadWords();
			var selectedWords = new Program().SelectWords(randomWords).Take(1);

			//Act
			var search = new TypesOfSearches.Searches();

			foreach (var word in selectedWords)
			{
				word.RandomWord = "BeastModeBarry";
				//Assert
				Assert.IsNull(search.LinearSearch(word));
			}
		}
	}
}
