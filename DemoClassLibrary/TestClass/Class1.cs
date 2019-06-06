using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.QualityTools.Testing.Fakes;
using System.Data.SqlClient.Fakes;
using System.Data;
using ClassLibrary1;

namespace TestClass
{
    [TestClass]
    public class ClassTest
    {
        [TestMethod]
        public void TestConect()
        {
            using (ShimsContext.Create())
            {
                ShimSqlConnection.AllInstances.Open = (sender) => { };
                ShimSqlConnection.AllInstances.StateGet = (sender) => ConnectionState.Open;

                Class1 cls = new Class1();
                cls.test();

            }
        }
    }
}
