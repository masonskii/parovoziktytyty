using Microsoft.VisualStudio.TestTools.UnitTesting;
using parovoziktytyty;
namespace TestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchSiteTest_11_3кн()
        {
            // Arrange
            Train train = new Train();

            // Act
            string result = train.search_site(11).ToString();

            // Assert
            Assert.AreEqual("3кн", result);
        }
        [TestMethod]
        public void SearchSiteTest_36_9кв()
        {
            // Arrange
            Train train = new Train();

            // Act
            string result = train.search_site(36).ToString();

            // Assert
            Assert.AreEqual("9кв", result);
        }
        [TestMethod]
        public void SearchSiteTest_50_3бв()
        {
            // Arrange
            Train train = new Train();

            // Act
            string result = train.search_site(50).ToString();

            // Assert
            Assert.AreEqual("3бв", result);
        }
        [TestMethod]
        public void SearchSiteTest_33_9кн()
        {
            // Arrange
            Train train = new Train();

            // Act
            string result = train.search_site(33).ToString();

            // Assert
            Assert.AreEqual("9кн", result);
        }
    }
}
