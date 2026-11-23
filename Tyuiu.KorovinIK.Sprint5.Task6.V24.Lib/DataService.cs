using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.KorovinIK.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            
            {
                
                string line = File.ReadAllText(path);
                string[] numbers = line.Split(" ");

                foreach (string number in numbers) 
                {
                    
                    
                        if (number.Length == 5)
                        {
                            count ++;
                        }
                    
                }
            }
            return count;
        }
    }
}
