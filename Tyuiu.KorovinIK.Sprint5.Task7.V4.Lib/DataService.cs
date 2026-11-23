using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KorovinIK.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V4.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strline = File.ReadAllText(path);

            string result = "";

            for (int i = 0; i < strline.Length; i++)
            {
                if ((strline[i] >= 'А' && strline[i] <= 'Я') ||
                    (strline[i] >= 'а' && strline[i] <= 'я') ||
                    (strline[i] == 'ё') || (strline[i] == 'Ё'))
                {
                    result = result + "#";
                }
                else
                {
                    result = result + strline[i];
                }
            }

            File.WriteAllText(pathSaveFile, result);

            return pathSaveFile;
        }
    } 
}
