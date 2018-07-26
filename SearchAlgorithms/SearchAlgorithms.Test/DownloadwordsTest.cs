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
			var expected = new DownloadWords();

			//Act
			var actual = new DownloadWords();

			//Assert
			Assert.AreEqual(expected.WordsSeperatedIntoArray.Length, actual.WordsSeperatedIntoArray.Length);
		}
	}
}
