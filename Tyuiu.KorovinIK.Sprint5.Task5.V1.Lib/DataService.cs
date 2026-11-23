using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KorovinIK.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;

            
            using (StreamReader reader = new StreamReader(path))
            {
                string line = File.ReadAllText(path);
                string[] numbers = line.Split(",");



                foreach (string num in numbers) 
                {
                    double number = Convert.ToDouble(num.Trim());

                    if (number % 2 == 0)
                    {
                        res = res + number;
                    }
                }
            }

            return Math.Round(res, 3);
        }
    }
}
