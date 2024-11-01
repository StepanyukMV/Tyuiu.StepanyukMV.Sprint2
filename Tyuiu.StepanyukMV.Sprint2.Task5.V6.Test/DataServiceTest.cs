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

            Assert.AreEqual("шестерка пики", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("семерка пики", ds.FindCardNameAndValue(1, 7));
            Assert.AreEqual("восьмерка пики", ds.FindCardNameAndValue(1, 8));
            Assert.AreEqual("девятка пики", ds.FindCardNameAndValue(1, 9));
            Assert.AreEqual("десятка пики", ds.FindCardNameAndValue(1, 10));
            Assert.AreEqual("валет пики", ds.FindCardNameAndValue(1, 11));
            Assert.AreEqual("дама пики", ds.FindCardNameAndValue(1, 12));
            Assert.AreEqual("король пики", ds.FindCardNameAndValue(1, 13));
            Assert.AreEqual("туз пики", ds.FindCardNameAndValue(1, 14));
            Assert.AreEqual("шестерка трефы", ds.FindCardNameAndValue(2, 6));
            Assert.AreEqual("семерка трефы", ds.FindCardNameAndValue(2, 7));
            Assert.AreEqual("восьмерка трефы", ds.FindCardNameAndValue(2, 8));
            Assert.AreEqual("девятка трефы", ds.FindCardNameAndValue(2, 9));
            Assert.AreEqual("десятка трефы", ds.FindCardNameAndValue(2, 10));
            Assert.AreEqual("валет трефы", ds.FindCardNameAndValue(2, 11));
            Assert.AreEqual("дама трефы", ds.FindCardNameAndValue(2, 12));
            Assert.AreEqual("король трефы", ds.FindCardNameAndValue(2, 13));
            Assert.AreEqual("туз трефы", ds.FindCardNameAndValue(2, 14));
            Assert.AreEqual("шестерка бубны", ds.FindCardNameAndValue(3, 6));
            Assert.AreEqual("семерка бубны", ds.FindCardNameAndValue(3, 7));
            Assert.AreEqual("восьмерка бубны", ds.FindCardNameAndValue(3, 8));
            Assert.AreEqual("девятка бубны", ds.FindCardNameAndValue(3, 9));
            Assert.AreEqual("десятка бубны", ds.FindCardNameAndValue(3, 10));
            Assert.AreEqual("валет бубны", ds.FindCardNameAndValue(3, 11));
            Assert.AreEqual("дама бубны", ds.FindCardNameAndValue(3, 12));
            Assert.AreEqual("король бубны", ds.FindCardNameAndValue(3, 13));
            Assert.AreEqual("туз бубны", ds.FindCardNameAndValue(3, 14));
            Assert.AreEqual("шестерка червы", ds.FindCardNameAndValue(4, 6));
            Assert.AreEqual("семерка червы", ds.FindCardNameAndValue(4, 7));
            Assert.AreEqual("восьмерка червы", ds.FindCardNameAndValue(4, 8));
            Assert.AreEqual("девятка червы", ds.FindCardNameAndValue(4, 9));
            Assert.AreEqual("десятка червы", ds.FindCardNameAndValue(4, 10));
            Assert.AreEqual("валет червы", ds.FindCardNameAndValue(4, 11));
            Assert.AreEqual("дама червы", ds.FindCardNameAndValue(4, 12));
            Assert.AreEqual("король червы", ds.FindCardNameAndValue(4, 13));
            Assert.AreEqual("туз червы", ds.FindCardNameAndValue(4, 14));

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