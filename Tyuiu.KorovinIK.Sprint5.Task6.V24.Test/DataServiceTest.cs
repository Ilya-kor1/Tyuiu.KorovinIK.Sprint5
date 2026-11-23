using Tyuiu.KorovinIK.Sprint5.Task6.V24.Lib;
namespace Tyuiu.KorovinIK.Sprint5.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]

        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V24.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\DataSprint5\InPutDataFileTask6V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
