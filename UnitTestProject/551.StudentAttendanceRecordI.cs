using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest551
    {
        [TestMethod]
        public void TestStudentAttendanceRecordI()
        {
            Assert.IsTrue(CheckRecord_IndexOf("PPALLP"));

            Assert.IsTrue(CheckRecord_IndexOf("PPALLL") == false);
            Assert.IsTrue(CheckRecord_IndexOf("LALL"));

        }

        public bool CheckRecord(string s)
        {
            int findACount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    findACount++;
                }
                if (findACount > 1) return false;

                if (i >= 2 && s[i] == 'L' && s[i - 1] == 'L' && s[i - 2] == 'L')
                {
                    return false;
                }

            }
            return true;

        }

        public bool CheckRecord_IndexOf(string s)
        {
            if (s.IndexOf("LLL") >= 0) return false;

            var firstAIndex = s.IndexOf("A");
            if (firstAIndex >= 0)
            {
                if (s.IndexOf("A", firstAIndex + 1) >= 0) { return false; }
            }
            return true;
        }
    }
}
