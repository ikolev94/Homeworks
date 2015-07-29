namespace UnitTestMatrix
{
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
    }
}
