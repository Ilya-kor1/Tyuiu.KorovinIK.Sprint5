using Tyuiu.KorovinIK.Sprint5.Task1.V21.Lib;
namespace Tyuiu.KorovinIK.Sprint5.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.KorovinIK.Sprint5\Tyuiu.KorovinIK.Sprint5.Task1.V21\bin\Debug\net8.0\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
