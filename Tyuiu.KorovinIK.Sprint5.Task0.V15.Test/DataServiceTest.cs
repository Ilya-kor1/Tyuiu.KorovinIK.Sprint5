using Tyuiu.KorovinIK.Sprint5.Task0.V15.Lib;
namespace Tyuiu.KorovinIK.Sprint5.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.KorovinIK.Sprint5\Tyuiu.KorovinIK.Sprint5.Task0.V15\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
