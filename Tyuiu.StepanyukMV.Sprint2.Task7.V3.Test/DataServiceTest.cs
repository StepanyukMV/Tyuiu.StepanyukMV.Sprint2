using Tyuiu.StepanyukMV.Sprint2.Task7.V3.Lib;
namespace Tyuiu.StepanyukMV.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 2;
            bool res =ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, res);

        }
    }
}