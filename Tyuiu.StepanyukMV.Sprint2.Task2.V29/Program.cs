using Tyuiu.StepanyukMV.Sprint2.Task2.V29.Lib;
namespace Tyuiu.StepanyukMV.Sprint2.Task2.V29
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Степанюк Михаил Вадимович | РППб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу , которая запрашивает целые значение с клавиатуры    *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение X=");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Значение Y=");
            int y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine("Точка в зашхтрихованной области");
            }
            else
            {
                Console.WriteLine("Точка вне зашхтрихованной области");
            }
        }
    }
}
