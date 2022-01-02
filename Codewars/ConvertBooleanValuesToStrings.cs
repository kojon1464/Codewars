using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars
{

    [TestFixture]
    public class ConvertBooleanValuesToStrings
    {

        [Test]
        public void boolToWordReturned1()
        {
            Assert.AreEqual("Yes", ConvertBooleanValuesToStringsKata.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }

        [Test]
        public void boolToWordReturned2()
        {
            Assert.AreEqual("No", ConvertBooleanValuesToStringsKata.boolToWord(false));
            Console.WriteLine("Expected No");
        }

        [Test]
        public void boolToWordReturned3()
        {
            Assert.AreEqual("Yes", ConvertBooleanValuesToStringsKata.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }
    }

    public static class ConvertBooleanValuesToStringsKata
    {
        public static string boolToWord(bool word)
        {
            return word ? "Yes" : "No";
        }
    }
}
