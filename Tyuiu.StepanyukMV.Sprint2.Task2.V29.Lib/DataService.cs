using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.StepanyukMV.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

           //!!!Перед отправкой сделать более читаемо это гавно!!!
           // if ((y ==3) && (x >= 3 && x <= 5) || (x>=9 && x <=12) // || (y == 4) && ( x >=1  &&  x<= 5) && ( x>=9 && x<=12) // ( y== 5) && ( x >=1 && x<=13) || ( y==6) && (y==7) && ( x>=3 && x<= 13) || ( y==8) && (x==6) && (x>= 10 && x<=13) || (y == 9) && (y==10) && (x == 6) && (x >= 10 && x <= 12) || (y==11) && (x>=3) && (x<=6 && x>=10) && (x<=12) || (y==12) && (x>=4 && x<=5) && (x==10))
            
            if ((y == 3) && (x >= 3 && x <= 5) || (x >= 9 && x <= 12)) return true;
            if ((y == 4) && (x >= 1 && x <= 5) || (x >= 9 && x <= 12)) return true;
            if ((y == 5) && (x >= 1 && x <= 13)) return true;
            if ((y == 6) || (y == 7) && (x >= 3 && x <= 13)) return true;
            if ((y == 8) && (x == 6) || (x >= 10 && x <= 13)) return true;
            if ((y == 9 && y == 10) && (x == 6) || (x >= 10 && x <= 12)) return true;
            if ((y == 11) && (x >= 3 && x <= 6) || (x >= 10 && x <= 12)) return true;
            if ((y == 12) && (x >= 4 && x <= 5) || (x == 10)) return true;

            else return false;
        }
    }
}
