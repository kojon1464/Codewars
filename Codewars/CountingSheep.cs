using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{

    [TestFixture]
    public class CountSheepsTests
    {

        [Test]
        public void SampleTest()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.AreEqual(2, CountSheep.CountSheeps(sheeps));
        }
    }


    public static class CountSheep
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Where(s => s == true).Count();
        }
    }
}
