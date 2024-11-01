using Tyuiu.StepanyukMV.Sprint2.Task5.V6.Lib;
namespace Tyuiu.StepanyukMV.Sprint2.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Степанюк М.В. | РППб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Степанюк Михаил Вадимович | РППб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите первую цифру масти:");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите вторую цифру силы карты:");
            int value2 = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindCardNameAndValue(value1, value2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение карты:" + res);
        }
    }
}
