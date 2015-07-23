using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLinkedListTest
{
    using System;
    using System.IO;

    using CustomLinkedList;

    [TestClass]
    public class LinkedListTest
    {
        private DynamicList<int> linkedListToTest;

        private DynamicList<string> linkedListToTestRefTypes;

        [TestInitialize]
        public void InitLinkedList()
        {
            this.linkedListToTest = new DynamicList<int>();
            this.linkedListToTestRefTypes = new DynamicList<string>();
        }

        [TestMethod]
        public void TestEmptyListsCount_ShouldBeZero()
        {
            Assert.AreEqual(0, this.linkedListToTest.Count, "Count is not zero");
        }

        [TestMethod]
        public void TestCountWhenNotEmpty_ShouldBeOne()
        {
            this.linkedListToTest.Add(1);
            Assert.AreEqual(1, this.linkedListToTest.Count, "Count is not one");
        }

        [TestMethod]
        public void TestAdd_ShouldAddToList()
        {
            int numberOfElements = 20;
            for (int i = 0; i < numberOfElements; i++)
            {
                this.linkedListToTest.Add(i);
            }

            Assert.AreEqual(0, this.linkedListToTest[0], "first element is not added to the list");
            Assert.AreEqual(19, this.linkedListToTest[numberOfElements - 1], "last element is not added to the list");
            Assert.AreEqual(numberOfElements, this.linkedListToTest.Count, "The linkedList count is not 20");
        }
        [TestMethod]
        public void TestAdd_WithReferenceType_ShouldAddToList()
        {
            string testWord = "This is test";
            this.linkedListToTestRefTypes.Add(testWord);

            Assert.IsInstanceOfType(this.linkedListToTestRefTypes[0], typeof(string), "added element is not string");
        }

        [TestMethod]
        public void TestRemoveWhenEmpty()
        {
            var removeIndex = this.linkedListToTest.Remove(3);
            Assert.AreEqual(-1, removeIndex, "removed index is not -1");
        }

        [TestMethod]
        public void TestRemoveWhenNotEmpty()
        {
            const int ItemsCount = 1000;
            for (int i = 0; i < ItemsCount; i++)
            {
                this.linkedListToTest.Add(i);
            }

            for (int i = ItemsCount - 1; i >= 0; i--)
            {
                this.linkedListToTest.Remove(i);
                Assert.AreEqual(i, this.linkedListToTest.Count);
            }

            Assert.AreEqual(0, this.linkedListToTest.Count, "Count is not zero");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Dont throw exception")]
        public void TestRemoveAtFromEmptyList_ShouldThrowException()
        {
            this.linkedListToTest.RemoveAt(1);
        }

        [TestMethod]
        public void TestRemoveAtFromNoEmptyList_ShouldRemoveElementAndReturnHisValue()
        {
            // Arrange
            var list = new DynamicList<string>();
            list.Add("te");
            list.Add("tes");
            list.Add("test");
            var removedElement = list.RemoveAt(1);
            // Assert
            Assert.AreSame("tes", removedElement);
            Assert.AreEqual(2, list.Count);
        }

        [TestMethod]
        public void TestIndexOfFromEmptyList_ShouldReturnMinus1()
        {
            // Arrange
            var list = new DynamicList<int>();
            // Act
            var a = list.IndexOf(2);
            // Assert
            Assert.AreEqual(-1, a);
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void TestIndexOfFromFullList_ShouldReturnindexOftheRequireElement()
        {
            // Arrange
            var list = new DynamicList<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            // Act
            var removed = list.IndexOf("a");
            var removeNotExisted = list.IndexOf("z");
            // Assert
            Assert.AreEqual(0, removed);
            Assert.AreEqual(-1, removeNotExisted);
            Assert.AreSame("b", list[1]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Dont throw ArgumentOutOfRangeEx")]
        public void TestGetIndexFromEmptyList_ShouldThrowExeception()
        {
            // Arrange
            var list = new DynamicList<int>();
            // Act
            var firstElement = list[0];
            var secondElement = list[1];
            // Assert
        }

        [TestMethod]
        public void TestSetIndex_ShouldReturnRequestedElement()
        {
            // Arrange
            var list = new DynamicList<string>();
            list.Add("ivan");
            list.Add("gosho");
            // Act
            list[1] = "koko";
            // Assert
            Assert.AreSame("koko", list[1], "element is not the requeested");
        }

        [TestMethod]
        public void TestContainsEmptyList_ShouldReturnFalse()
        {
            // Arrange
            var list = new DynamicList<int>();
            // Act
            bool contains = list.Contains(22);
            // Assert
            Assert.IsFalse(contains);
        }

        [TestMethod]
        public void TestContainsFullList_ShouldReturnTrue()
        {
            // Arrange
            var list = new DynamicList<int>();
            list.Add(3);
            list.Add(1);
            // Act
            bool contains = list.Contains(3);
            // Assert
            Assert.IsTrue(contains);
        }
    }
}
