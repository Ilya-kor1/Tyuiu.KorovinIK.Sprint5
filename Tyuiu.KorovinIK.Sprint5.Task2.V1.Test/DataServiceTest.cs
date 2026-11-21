using Tyuiu.KorovinIK.Sprint5.Task2.V1.Lib;
namespace Tyuiu.KorovinIK.Sprint5.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.KorovinIK.Sprint5\Tyuiu.KorovinIK.Sprint5.Task2.V1\bin\Debug\net8.0\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}


