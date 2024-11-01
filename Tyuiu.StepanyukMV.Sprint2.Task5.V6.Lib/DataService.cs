using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.StepanyukMV.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
           string res;
           switch(value1, value2)
            {
                case (1, 6):
                    res = "шестерка пик";
                    break;
                case (1, 7):
                    res = "семерка пик";
                    break;
                case (1, 8):
                    res = "восьмерка пик";
                    break;
                case (1, 9):
                    res = "девятка пик";
                    break;
                case (1, 10):
                    res = "десятка пик";
                    break;
                case (1, 11):
                    res = "валет пик";
                    break;
                case (1, 12):
                    res = "дама пик";
                    break;
                case (1, 13):
                    res = "король пик";
                    break;
                case (1, 14):
                    res = "туз пик";
                    break;
                case (2, 6):
                    res = "шестерка треф";
                    break;
                case (2, 7):
                    res = "семерка треф";
                    break;
                case (2, 8):
                    res = "восьмерка треф";
                    break;
                case (2, 9):
                    res = "девятка треф";
                    break;
                case (2, 10):
                    res = "десятка треф";
                    break;
                case (2, 11):
                    res = "валет треф";
                    break;
                case (2, 12):
                    res = "дама треф";
                    break;
                case (2, 13):
                    res = "король треф";
                    break;
                case (2, 14):
                    res = "туз треф";
                    break;
                case (3, 6):
                    res = "шестерка бубн";
                    break;
                case (3, 7):
                    res = "семерка бубн";
                    break;
                case (3, 8):
                    res = "восьмерка бубн";
                    break;
                case (3, 9):
                    res = "девятка бубн";
                    break;
                case (3, 10):
                    res = "десятка бубн";
                    break;
                case (3, 11):
                    res = "валет бубн";
                    break;
                case (3, 12):
                    res = "дама бубн";
                    break;
                case (3, 13):
                    res = "король бубн";
                    break;
                case (3, 14):
                    res = "туз бубн";
                    break;
                case (4, 6):
                    res = "шестерка черв";
                    break;
                case (4, 7):
                    res = "семерка черв";
                    break;
                case (4, 8):
                    res = "восьмерка черв";
                    break;
                case (4, 9):
                    res = "девятка черв";
                    break;
                case (4, 10):
                    res = "десятка черв";
                    break;
                case (4, 11):
                    res = "валет черв";
                    break;
                case (4, 12):
                    res = "дама черв";
                    break;
                case (4, 13):
                    res = "король черв";
                    break;
                case (4, 14):
                    res = "туз черв";
                    break;

                default:
                    throw new ArgumentException($"Первое число 1-4 для масти, второе число 6-14 для силы карты{value1}{value2}");
            }
            return res;

        }
            
    }
              
}
    

