using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System.IO;
using System.Linq;

namespace TestsSuperBASIC
{
    [TestClass]
    public class Shpere_volTest
    {
        [TestMethod]
        public void Shepere_vol() 
        {
            Mock.MockPrint print = new Mock.MockPrint();
            Library lib = new Library();

            lib.AddFunction(new SuperBASIC.Functions.Sphere_vol(), 2, "SPHERE_VOL");
            lib.AddFunction(print, 1, "PRINT");

            Runtime r = new Runtime(lib);
            r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\Sphere_volTest1.txt");
            r.Run();

            Assert.AreEqual((float)print.output[0], 8,377581);
        }
    }
}
