using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    [TestFixture]
    public class ReplaceWithAlphabetPositionTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", ReplaceWithAlphabetPosition.AlphabetPosition("The sunset sets at twelve o' clock."));
            Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", ReplaceWithAlphabetPosition.AlphabetPosition("The narwhal bacons at midnight."));
        }
    }

    public static class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.ToLower().Where(c => char.IsLetter(c)).Select(c => c - 96));
        }

        public static string AlphabetPosition1(string text)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char character in text.ToLower().ToCharArray())
            {
                if (char.IsLetter(character))
                {
                    sb.Append(character - 96);
                    sb.Append(" ");
                }
            }

            if(sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }

            return sb.ToString();
        }
    }
}
