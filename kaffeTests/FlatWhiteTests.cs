using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffe.Tests
{
    [TestClass()]

    public class FlatWhiteTests
    {
        [TestMethod()]
        public void FlatWhitePris()
        {
            var flatwhite = new FaltWhite();
            int pris = flatwhite.Pris();
            Assert.AreEqual(45, pris);
        }

        [TestMethod()]
        public void FlatWhiteStykke()
        {
            var flatwhit = new FaltWhite();
            string styrke = flatwhit.Styrke();
            Assert.AreEqual("mild", styrke);
        }

        [TestMethod()]
        public void FlatWhiteMlMælk()
        {
            var flatwhit = new FaltWhite();
            int mlMælk = flatwhit.MlMælk();
            Assert.AreEqual(160, mlMælk);
        }
    }
}
