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
                    res = "шестерка пики";
                    break;
                case (1, 7):
                    res = "семерка пики";
                    break;
                case (1, 8):
                    res = "восьмерка пики";
                    break;
                case (1, 9):
                    res = "девятка пики";
                    break;
                case (1, 10):
                    res = "десятка пики";
                    break;
                case (1, 11):
                    res = "валет пики";
                    break;
                case (1, 12):
                    res = "дама пики";
                    break;
                case (1, 13):
                    res = "король пики";
                    break;
                case (1, 14):
                    res = "туз пики";
                    break;
                case (2, 6):
                    res = "шестерка трефы";
                    break;
                case (2, 7):
                    res = "семерка трефы";
                    break;
                case (2, 8):
                    res = "восьмерка трефы";
                    break;
                case (2, 9):
                    res = "девятка трефы";
                    break;
                case (2, 10):
                    res = "десятка трефы";
                    break;
                case (2, 11):
                    res = "валет трефы";
                    break;
                case (2, 12):
                    res = "дама трефы";
                    break;
                case (2, 13):
                    res = "король трефы";
                    break;
                case (2, 14):
                    res = "туз трефы";
                    break;
                case (3, 6):
                    res = "шестерка бубны";
                    break;
                case (3, 7):
                    res = "семерка бубны";
                    break;
                case (3, 8):
                    res = "восьмерка бубны";
                    break;
                case (3, 9):
                    res = "девятка бубны";
                    break;
                case (3, 10):
                    res = "десятка бубны";
                    break;
                case (3, 11):
                    res = "валет бубны";
                    break;
                case (3, 12):
                    res = "дама бубны";
                    break;
                case (3, 13):
                    res = "король бубны";
                    break;
                case (3, 14):
                    res = "туз бубны";
                    break;
                case (4, 6):
                    res = "шестерка червы";
                    break;
                case (4, 7):
                    res = "семерка червы";
                    break;
                case (4, 8):
                    res = "восьмерка червы";
                    break;
                case (4, 9):
                    res = "девятка червы";
                    break;
                case (4, 10):
                    res = "десятка червы";
                    break;
                case (4, 11):
                    res = "валет червы";
                    break;
                case (4, 12):
                    res = "дама червы";
                    break;
                case (4, 13):
                    res = "король червы";
                    break;
                case (4, 14):
                    res = "туз червы";
                    break;

                default:
                    throw new ArgumentException($"Первое число 1-4 для масти, второе число 6-14 для силы карты{value1}{value2}");
            }
            return res;

        }
            
    }
              
}
    

