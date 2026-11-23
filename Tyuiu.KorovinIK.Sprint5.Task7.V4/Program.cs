using Tyuiu.KorovinIK.Sprint5.Task7.V4.Lib;
namespace Tyuiu.KorovinIK.Sprint5.Task7.V4.V24
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

            Console.WriteLine("* Задание #5                                          *");

            Console.WriteLine("* Вариант #1                                                       *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V4.txt");

            string pathSaviFile = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V4.txt");

            Console.WriteLine("Данные находяться в файле " + path);













            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Находиться в файле:");
            pathSaviFile = ds.LoadDataAndSave(path);




            Console.WriteLine(pathSaviFile);


            Console.ReadKey();




        }
    }
}
