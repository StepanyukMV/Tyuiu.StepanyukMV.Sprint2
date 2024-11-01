using Tyuiu.StepanyukMV.Sprint2.Task5.V6.Lib;
namespace Tyuiu.StepanyukMV.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("шестерка пик", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("семерка пик", ds.FindCardNameAndValue(1, 7));
            Assert.AreEqual("восьмерка пик", ds.FindCardNameAndValue(1, 8));
            Assert.AreEqual("девятка пик", ds.FindCardNameAndValue(1, 9));
            Assert.AreEqual("десятка пик", ds.FindCardNameAndValue(1, 10));
            Assert.AreEqual("валет пик", ds.FindCardNameAndValue(1, 11));
            Assert.AreEqual("дама пик", ds.FindCardNameAndValue(1, 12));
            Assert.AreEqual("король пик", ds.FindCardNameAndValue(1, 13));
            Assert.AreEqual("туз пик", ds.FindCardNameAndValue(1, 14));
            Assert.AreEqual("шестерка треф", ds.FindCardNameAndValue(2, 6));
            Assert.AreEqual("семерка треф", ds.FindCardNameAndValue(2, 7));
            Assert.AreEqual("восьмерка треф", ds.FindCardNameAndValue(2, 8));
            Assert.AreEqual("девятка треф", ds.FindCardNameAndValue(2, 9));
            Assert.AreEqual("десятка треф", ds.FindCardNameAndValue(2, 10));
            Assert.AreEqual("валет треф", ds.FindCardNameAndValue(2, 11));
            Assert.AreEqual("дама треф", ds.FindCardNameAndValue(2, 12));
            Assert.AreEqual("король треф", ds.FindCardNameAndValue(2, 13));
            Assert.AreEqual("туз треф", ds.FindCardNameAndValue(2, 14));
            Assert.AreEqual("шестерка бубн", ds.FindCardNameAndValue(3, 6));
            Assert.AreEqual("семерка бубн", ds.FindCardNameAndValue(3, 7));
            Assert.AreEqual("восьмерка бубн", ds.FindCardNameAndValue(3, 8));
            Assert.AreEqual("девятка бубн", ds.FindCardNameAndValue(3, 9));
            Assert.AreEqual("десятка бубн", ds.FindCardNameAndValue(3, 10));
            Assert.AreEqual("валет бубн", ds.FindCardNameAndValue(3, 11));
            Assert.AreEqual("дама бубн", ds.FindCardNameAndValue(3, 12));
            Assert.AreEqual("король бубн", ds.FindCardNameAndValue(3, 13));
            Assert.AreEqual("туз бубн", ds.FindCardNameAndValue(3, 14));
            Assert.AreEqual("шестерка черв", ds.FindCardNameAndValue(4, 6));
            Assert.AreEqual("семерка черв", ds.FindCardNameAndValue(4, 7));
            Assert.AreEqual("восьмерка черв", ds.FindCardNameAndValue(4, 8));
            Assert.AreEqual("девятка черв", ds.FindCardNameAndValue(4, 9));
            Assert.AreEqual("десятка черв", ds.FindCardNameAndValue(4, 10));
            Assert.AreEqual("валет черв", ds.FindCardNameAndValue(4, 11));
            Assert.AreEqual("дама черв", ds.FindCardNameAndValue(4, 12));
            Assert.AreEqual("король черв", ds.FindCardNameAndValue(4, 13));
            Assert.AreEqual("туз черв", ds.FindCardNameAndValue(4, 14));

            Assert.ThrowsException<ArgumentException>(()=>
                {
                     ds.FindCardNameAndValue(5, 1); 
              });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(15, 1);
            });



        }
    }
}