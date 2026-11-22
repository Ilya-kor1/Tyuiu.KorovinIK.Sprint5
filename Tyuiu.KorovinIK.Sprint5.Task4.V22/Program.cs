using Tyuiu.KorovinIK.Sprint5.Task4.V22.Lib;
namespace Tyuiu.KorovinIK.Sprint5.Task4.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Коровин И. К. | ИСТНб-26-1";

            Console.WriteLine("****************************************************************************");

            Console.WriteLine("* Спринт #5                                                               *");

            Console.WriteLine("* : Тема Класс File. Запись данных в текстовый файл                 *");

            Console.WriteLine("* Задание #4                                          *");

            Console.WriteLine("* Вариант #22                                                       *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");



            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask4V22.txt");

            Console.WriteLine("Данные находяться в файле " + path);













            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            double res = ds.LoadFromDataFile(path);

            
            Console.WriteLine(res);
            

            Console.ReadKey();




        }
    }
}