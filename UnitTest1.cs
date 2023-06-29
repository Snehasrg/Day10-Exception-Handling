using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            ExceptionHandling.PersonCategorybasedoAge testing = new ExceptionHandling.PersonCategorybasedoAge();
            //ExceptionHandling.PersonCategorybasedoAge.GetCategory(45);
            testing.GetCategory(65);
            Assert.AreEqual("Test Passed ", testing);
        }
    }
}
