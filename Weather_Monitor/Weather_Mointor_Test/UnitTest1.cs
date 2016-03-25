using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weather_Monitor;

namespace Weather_Mointor_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException),
    "An expected exception")]
        public void changedData_characrer_exceptionThrow()
        {
            Manager m = new Manager(null, null, null);
            m.changedData(0, "asd");
        }
    }
}
