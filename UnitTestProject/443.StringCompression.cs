using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest443
    {
        [TestMethod]
        public void TestStringCompression()
        {

            var result = Compress(new[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });//a2b2c3
            Assert.IsTrue((result) == 6);


            result = Compress(new[] { 'a' });//a
            Assert.IsTrue((result) == 1);

            result = Compress(new[] { 'a', 'a', 'b' });//a2b
            Assert.IsTrue((result) == 3);

            result = Compress(new[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' });//ab12
            Assert.IsTrue((result) == 4);
        }



        public int Compress(char[] chars)
        {
            int writeIndex = 0, nextIndex = 0;
            for (int currentIndex = 0; currentIndex < chars.Length;)
            {
                nextIndex = currentIndex + 1;
                if (nextIndex >= chars.Length)
                {
                    chars[writeIndex] = chars[currentIndex];
                    writeIndex++;
                    break;
                }
                while (nextIndex <= chars.Length - 1 && chars[nextIndex] == chars[currentIndex])
                {
                    nextIndex++;
                }

                chars[writeIndex] = chars[currentIndex];
                writeIndex++;
                if (nextIndex != currentIndex + 1)
                { 
                    var charCount = (nextIndex - currentIndex).ToString().ToCharArray();
                    foreach (var c in charCount)
                    {
                        chars[writeIndex] = c;
                        writeIndex++;
                    }
                }
                currentIndex = nextIndex;
            }
            Console.WriteLine("chars:" + new string(chars));
            Console.WriteLine("count:" + writeIndex);
            return writeIndex;
        }


    }
}
