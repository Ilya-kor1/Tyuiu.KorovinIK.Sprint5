using Tyuiu.KorovinIK.Sprint5.Task2.V1.Lib;
namespace Tyuiu.KorovinIK.Sprint5.Task2.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { {6, 9, 4 },
                                          {7, 2, 4 },
                                          {4, 8, 3 } };

            int rows = mtrx.GetLength(0);
            int columse = mtrx.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Коровин И. К. | ИСТНб-26-1";

            Console.WriteLine("****************************************************************************");

            Console.WriteLine("* Спринт #5                                                               *");

            Console.WriteLine("* : Тема Класс File. Запись данных в текстовый файл                 *");

            Console.WriteLine("* Задание #1                                           *");

            Console.WriteLine("* Вариант #21                                                       *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Масcив");











            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            string res = ds.SaveToFileTextData(mtrx);



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columse; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t ");
                }

                Console.WriteLine();
            }


            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();


            

        }
    }
}