using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KorovinIK.Sprint5.Task1.V21.Lib
{
    public class DataService : ISprint5Task1V21
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y = 0;
            string strY;
            for (int x  = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) - 2 * x;

                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (2 * x - 3) / denominator + 5 * x - Math.Sin(x);
                }

                y = Math.Round(y, 2);

                strY = Convert.ToString(y);

                File.AppendAllText(path, strY + Environment.NewLine);
            }
            return path;

        }
    }
}
