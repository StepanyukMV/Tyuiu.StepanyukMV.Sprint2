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

            Assert.AreEqual("�������� ���", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("������� ���", ds.FindCardNameAndValue(1, 7));
            Assert.AreEqual("��������� ���", ds.FindCardNameAndValue(1, 8));
            Assert.AreEqual("������� ���", ds.FindCardNameAndValue(1, 9));
            Assert.AreEqual("������� ���", ds.FindCardNameAndValue(1, 10));
            Assert.AreEqual("����� ���", ds.FindCardNameAndValue(1, 11));
            Assert.AreEqual("���� ���", ds.FindCardNameAndValue(1, 12));
            Assert.AreEqual("������ ���", ds.FindCardNameAndValue(1, 13));
            Assert.AreEqual("��� ���", ds.FindCardNameAndValue(1, 14));
            Assert.AreEqual("�������� ����", ds.FindCardNameAndValue(2, 6));
            Assert.AreEqual("������� ����", ds.FindCardNameAndValue(2, 7));
            Assert.AreEqual("��������� ����", ds.FindCardNameAndValue(2, 8));
            Assert.AreEqual("������� ����", ds.FindCardNameAndValue(2, 9));
            Assert.AreEqual("������� ����", ds.FindCardNameAndValue(2, 10));
            Assert.AreEqual("����� ����", ds.FindCardNameAndValue(2, 11));
            Assert.AreEqual("���� ����", ds.FindCardNameAndValue(2, 12));
            Assert.AreEqual("������ ����", ds.FindCardNameAndValue(2, 13));
            Assert.AreEqual("��� ����", ds.FindCardNameAndValue(2, 14));
            Assert.AreEqual("�������� ����", ds.FindCardNameAndValue(3, 6));
            Assert.AreEqual("������� ����", ds.FindCardNameAndValue(3, 7));
            Assert.AreEqual("��������� ����", ds.FindCardNameAndValue(3, 8));
            Assert.AreEqual("������� ����", ds.FindCardNameAndValue(3, 9));
            Assert.AreEqual("������� ����", ds.FindCardNameAndValue(3, 10));
            Assert.AreEqual("����� ����", ds.FindCardNameAndValue(3, 11));
            Assert.AreEqual("���� ����", ds.FindCardNameAndValue(3, 12));
            Assert.AreEqual("������ ����", ds.FindCardNameAndValue(3, 13));
            Assert.AreEqual("��� ����", ds.FindCardNameAndValue(3, 14));
            Assert.AreEqual("�������� ����", ds.FindCardNameAndValue(4, 6));
            Assert.AreEqual("������� ����", ds.FindCardNameAndValue(4, 7));
            Assert.AreEqual("��������� ����", ds.FindCardNameAndValue(4, 8));
            Assert.AreEqual("������� ����", ds.FindCardNameAndValue(4, 9));
            Assert.AreEqual("������� ����", ds.FindCardNameAndValue(4, 10));
            Assert.AreEqual("����� ����", ds.FindCardNameAndValue(4, 11));
            Assert.AreEqual("���� ����", ds.FindCardNameAndValue(4, 12));
            Assert.AreEqual("������ ����", ds.FindCardNameAndValue(4, 13));
            Assert.AreEqual("��� ����", ds.FindCardNameAndValue(4, 14));

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