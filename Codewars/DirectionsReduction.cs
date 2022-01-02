using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    [TestFixture]
    public class DirReductionTests
    {

        [Test]
        public void Test1()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };
            Assert.AreEqual(b, DirReduction.dirReduc(a));
        }
        [Test]
        public void Test2()
        {
            string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            Assert.AreEqual(b, DirReduction.dirReduc(a));
        }
    }

    public class DirReduction
    {
        public static string[] dirReduc(String[] arr)
        {
            List<String> list = arr.ToList();
            int startLenght = arr.Length;

            for (int i = startLenght - 2; i >= 0; i--)
            {
                if ((arr[i] == "WEST" && arr[i + 1] == "EAST") ||
                    (arr[i] == "EAST" && arr[i + 1] == "WEST") ||
                    (arr[i] == "NORTH" && arr[i + 1] == "SOUTH") ||
                    (arr[i] == "SOUTH" && arr[i + 1] == "NORTH"))
                {
                    list.RemoveAt(i + 1);
                    list.RemoveAt(i);
                    i--;
                }
            }

            String[] result = list.ToArray();

            if (arr.Length == result.Length)
            {
                return result;
            }

            return dirReduc(result);
        }
    }
}
