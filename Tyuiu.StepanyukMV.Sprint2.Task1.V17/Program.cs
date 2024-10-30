using Tyuiu.StepanyukMV.Sprint2.Task1.V17.Lib;
namespace Tyuiu.StepanyukMV.Sprint2.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Степанюк М.В. | РППб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Степанюк Михаил Вадимович | РППб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз           *");
            Console.WriteLine("* в выражении) и логических операций (|, &, ||, &&, !, ^,                 *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также              *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
            Console.WriteLine("* (True, False, True, True, True, False), при a = 135, b = 123, c = 455.  *");
            Console.WriteLine("* d = 321.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" A = 135 ");
            Console.WriteLine(" B = 123 ");
            Console.WriteLine(" C = 455 ");
            Console.WriteLine(" D = 321 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
