using Microsoft.VisualStudio.TestTools.UnitTesting;
using parovoziktytyty;
namespace TestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchSiteTest_11_3��()
        {
            // Arrange
            Train train = new Train();

            // Act
            string result = train.search_site(11).ToString();

            // Assert
            Assert.AreEqual("3��", result);
        }
        [TestMethod]
        public void SearchSiteTest_36_9��()
        {
            // Arrange
            Train train = new Train();

            // Act
            string result = train.search_site(36).ToString();

            // Assert
            Assert.AreEqual("9��", result);
        }
        [TestMethod]
        public void SearchSiteTest_50_3��()
        {
            // Arrange
            Train train = new Train();

            // Act
            string result = train.search_site(50).ToString();

            // Assert
            Assert.AreEqual("3��", result);
        }
        [TestMethod]
        public void SearchSiteTest_33_9��()
        {
            // Arrange
            Train train = new Train();

            // Act
            string result = train.search_site(33).ToString();

            // Assert
            Assert.AreEqual("9��", result);
        }
    }
}
