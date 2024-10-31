using Tyuiu.StepanyukMV.Sprint2.Task3.V1.Lib;
namespace Tyuiu.StepanyukMV.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -2;
            double res = ds.Calculate(x);
            double wait = -21.5 ;
            Assert.AreEqual(wait, res);
        }
    }
}