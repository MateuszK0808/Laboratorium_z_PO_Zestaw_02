using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboratorium_z_PO_Zestaw_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_z_PO_Zestaw_02.Tests
{
    [TestClass()]
    public class OsobaTests
    {
        [TestMethod()]
        public void OsobaTest()
        {
            var o = new Osoba("Adam", "Miś", "20.03.1980");
            Assert.AreEqual("Adam", o.Imie);
            Assert.AreEqual("Miś", o.Nazwisko);
            Assert.AreEqual("20.03.1980", o.DataUrodzenia);
        }
    }
}