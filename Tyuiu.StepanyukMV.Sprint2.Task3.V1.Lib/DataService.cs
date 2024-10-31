using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.StepanyukMV.Sprint2.Task3.V1.Lib
{
    public class DataService : ISprint2Task3V1
    {
        public double Calculate(double x)
        {

            double y = 0;

            if (x > 0)
            {
                y = Math.Exp(x) - 12 * x + Math.Cos(x);

            }
            else
            {
                if (x == 2)
                {
                    y = x + (15 / x);
                }
                else
                {

                    if ((x >= -5) && (x <= 3))
                    {
                        y = x + 10 * x - (1 / x);
                    }
                    else
                    {
                        if (x <= -5)
                        {
                            y = x + 10 * x - (1 / Math.Cbrt(x) + 3);
                        }
                    }

                }

            }
                
            

            return Math.Round(y,3);

        }
    }
}
