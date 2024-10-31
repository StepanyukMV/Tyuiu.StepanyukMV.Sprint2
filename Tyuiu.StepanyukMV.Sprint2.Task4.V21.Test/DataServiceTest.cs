using Tyuiu.StepanyukMV.Sprint2.Task4.V21.Lib;
namespace Tyuiu.StepanyukMV.Sprint2.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
             double x = 1;
             double y = 4;
             double res = ds.Calculate(x, y);
             double wait1 = 256;
             Assert.AreEqual(wait1, res);

        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double res =ds.Calculate(x, y);
            double wait2 = 0.689;
            Assert.AreEqual(wait2, res);
        }
    }
}