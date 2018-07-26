using Microsoft.VisualStudio.TestTools.UnitTesting;

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
	}
}
