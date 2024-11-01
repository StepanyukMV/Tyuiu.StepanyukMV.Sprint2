using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.StepanyukMV.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            switch (value1,value2)
            {
                case (1, 6):return "шестерка пик";
                case (1, 7):return "семерка пик";
                case(1, 8): return "восьмерка пик";
                case (1, 9): return "девятка пик";
                case (1, 10): return "десятка пик";
                case (1, 11): return "валет пик";
                case (1, 12): return "дама пик";
                case (1, 13): return "король пик";
                case (1, 14): return "туз пик";
                case (2, 6): return "шестерка треф";
                case (2, 7): return "семерка треф";
                case (2, 8): return "восьмерка треф";
                case (2, 9): return "девятка треф";
                case (2, 10): return "десятка треф";
                case (2, 11): return "валет треф";
                case (2, 12): return "дама треф";
                case (2, 13): return "король треф";
                case (2, 14): return "туз треф";
                case (3, 6): return "шестерка бубн";
                case (3, 7): return "семерка бубн";
                case (3, 8): return "восьмерка бубн";
                case (3, 9): return "девятка бубн";
                case (3, 10): return "десятка бубн";
                case (3, 11): return "валет бубн";
                case (3, 12): return "дама бубн";
                case (3, 13): return "король бубн";
                case (3, 14): return "туз бубн";
                case (4, 6): return "шестерка черв";
                case (4, 7): return "семерка черв";
                case (4, 8): return "восьмерка черв";
                case (4, 9): return "девятка черв";
                case (4, 10): return "десятка черв";
                case (4, 11): return "валет черв";
                case (4, 12): return "дама черв";
                case (4, 13): return "король черв";
                case (4, 14):return "туз черв";
                default: throw new ArgumentException($"Первое число 1-4 для масти, второе число 6-14 для силы карты{value1}{value2}");
            };
        }
    }
}
