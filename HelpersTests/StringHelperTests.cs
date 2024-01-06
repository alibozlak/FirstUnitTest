using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass()]
    public class StringHelperTests
    {
        [TestMethod()]
        public void BasindakiVeSonundakiBosluklariSilTest()
        {
            //Arrange
            string text = "     Engin Demiroğ                  ";
            string expected = "Engin Demiroğ";

            //Actual
            string actualized = StringHelper.FazlaBosluklariSil(text);

            //Assert
            Assert.AreEqual(expected, actualized);
        }

        [TestMethod()]
        public void AradakiBosluklariSil()
        {
            string text = "Bu   metnin    arasındaki       fazla   boşluklar       silinmeli";
            string expected = "Bu metnin arasındaki fazla boşluklar silinmeli";

            string actualized = StringHelper.FazlaBosluklariSil(text);

            Assert.AreEqual(expected, actualized);
        }
    }
}