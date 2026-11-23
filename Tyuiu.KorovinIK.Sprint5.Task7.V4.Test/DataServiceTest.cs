using Tyuiu.KorovinIK.Sprint5.Task7.V4.Lib;
namespace Tyuiu.KorovinIK.Sprint5.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
      

        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\DataSprint5\InPutDataFileTask7V4.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

