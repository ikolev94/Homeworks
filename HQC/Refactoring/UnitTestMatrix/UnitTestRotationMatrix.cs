namespace UnitTestMatrix
{
    using System;
    using System.IO;
    using System.Text;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestRotationMatrix
    {
        [TestMethod]
        public void TestSize2()
        {
            int[,] expectedMatrix = 
            {
                { 1, 4 },
                { 3, 2 }
            };

            var actualMatrix = ClockwiseRotationMatrix.WalkInMatrica.FillMartix(2);

            CollectionAssert.AreEqual(expectedMatrix, actualMatrix);
        }

        [TestMethod]
        public void TestSize6()
        {
            int[,] expectedMatrix = 
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15,  2, 27, 28, 29, 21 },
                { 14, 31,  3, 26, 30, 22 },
                { 13, 36, 32,  4, 25, 23 },
                { 12, 35, 34, 33,  5, 24 },
                { 11, 10,  9, 8, 7, 6 }
            };

            var actualMatrix = ClockwiseRotationMatrix.WalkInMatrica.FillMartix(6);

            CollectionAssert.AreEqual(expectedMatrix, actualMatrix);
        }


        [TestMethod]
        public void TestMainWithSize3()
        {
            StringBuilder expectedOutput = new StringBuilder();
            expectedOutput.AppendLine("Enter a positive number ");
            expectedOutput.AppendLine("  1  7  8");
            expectedOutput.AppendLine("  6  2  9");
            expectedOutput.AppendLine("  5  4  3");

            StringReader inputReader = new StringReader("3" + Environment.NewLine);
            Console.SetIn(inputReader);
            StringWriter actualOutput = new StringWriter();
            Console.SetOut(actualOutput);
            ClockwiseRotationMatrix.WalkInMatrica.Main();
           Assert.AreEqual(expectedOutput.ToString(), actualOutput.ToString());
        }
    }
}
