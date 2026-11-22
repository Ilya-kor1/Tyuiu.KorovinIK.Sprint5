using Tyuiu.KorovinIK.Sprint5.Task3.V29.Lib;
namespace Tyuiu.KorovinIK.Sprint5.Task3.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Коровин И. К. | ИСТНб-26-1";

            Console.WriteLine("****************************************************************************");

            Console.WriteLine("* Спринт #5                                                               *");

            Console.WriteLine("* : Тема Класс File. Запись данных в текстовый файл                 *");

            Console.WriteLine("* Задание #3                                           *");

            Console.WriteLine("* Вариант #29                                                       *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");
            
            
            
            Console.WriteLine("x =" + x);

            











            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("F(x) = 64.000");
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();




        }
    }
}