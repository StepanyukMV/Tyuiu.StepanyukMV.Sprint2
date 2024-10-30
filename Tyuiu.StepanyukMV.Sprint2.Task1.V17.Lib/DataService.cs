using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.StepanyukMV.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = b + 198 == d | a == b;
            res[1] = (a > c) & (b < d);
            res[2] = a + 320 > c || d > b;
            res[3] = (a > c) && (b < d);
            res[4] = !(!res[0]);
            res[5] = (a > c) ^ (b < d);
            return res;
        }
    }
}
