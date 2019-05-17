using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest657
    {
        [TestMethod]
        public void TestRobotReturnToOrigin()
        {
            //RLUD

            Assert.IsTrue(JudgeCircle(""));
            Assert.IsTrue(JudgeCircle("R") == false);
            Assert.IsTrue(JudgeCircle("RRR") == false);
            Assert.IsTrue(JudgeCircle("RRRR") == false);
            Assert.IsTrue(JudgeCircle("RL") == true);
            Assert.IsTrue(JudgeCircle("RLR") == false);
            Assert.IsTrue(JudgeCircle("RLLR") == true);
            Assert.IsTrue(JudgeCircle("U") == false);
            Assert.IsTrue(JudgeCircle("UD") == true);
            Assert.IsTrue(JudgeCircle("UUD") == false);
            Assert.IsTrue(JudgeCircle("UUDD") == true);
        }
        public bool JudgeCircle(string moves)
        {
            if (string.IsNullOrEmpty(moves)) return true;

            int countR = 0, countU = 0;

            foreach (var c in moves)
            {
                if (c == 'R') countR++;
                if (c == 'L') countR--;
                if (c == 'U') countU++;
                if (c == 'D') countU--;


            }


            return (countR == 0 && countU == 0);
        }

        public bool JudgeCircle_Dic(string moves)
        {
            if (string.IsNullOrEmpty(moves)) return true;

            Dictionary<char, int> moveActionCountDic = new Dictionary<char, int>();
            moveActionCountDic.Add('R', 0);
            moveActionCountDic.Add('L', 0);
            moveActionCountDic.Add('U', 0);
            moveActionCountDic.Add('D', 0);

            foreach (var c in moves)
            {
                moveActionCountDic[c] = moveActionCountDic[c] + 1;
            }

            if (moveActionCountDic['R'] == moveActionCountDic['L'] && moveActionCountDic['U'] == moveActionCountDic['D'])
            {
                return true;
            }
            return false;
        }
    }

}
