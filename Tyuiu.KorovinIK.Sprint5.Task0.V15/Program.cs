using Tyuiu.KorovinIK.Sprint5.Task0.V15.Lib;
namespace Tyuiu.KorovinIK.Sprint5.Task0.V15
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

            Console.WriteLine("* Задание #0                                            *");

            Console.WriteLine("* Вариант #15                                                        *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("x = " + x);

            








            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("y = " + File.ReadAllText(res));

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
