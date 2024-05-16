using ClassLibraryExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTests
{
    [TestClass]
    public class BrittanyLinkedListTests
    {
        // Creating a singly linked list that accepts strings


        [TestMethod]
        [DataRow("Toast")]

        public void LinkedListAcceptsStrings_ReturnsStringData(string input)
        {
            // arrange
            BrittanyLinkedList<string> list = new();
            // act
            list.AddToBack(input);
            string result = list.Get(0);

            // assert
            Assert.IsInstanceOfType(result, typeof(string));

        }

        [TestMethod]
        [DataRow("Toast")]
        public void LinkedListAcceptsAnItem_HeadReturnsTheItem(string input)
        {
            //arrange
            BrittanyLinkedList<string> list = new BrittanyLinkedList<string>();
            BrittanyNode<string> expected = new BrittanyNode<string>(input);
            //act
            list.AddToBack(input);
            BrittanyNode<string> result = list.Head;
            //assert
            Assert.AreEqual(result.Data, expected.Data);
        }

        [TestMethod]
        [DataRow("Toast")]
        public void LinkedListAcceptsAnItem_CreatesANodeInTheHead(string input)
        {
            //arrange
            BrittanyLinkedList<string> list = new();
            //act
            list.AddToBack(input);

            //assert
            Assert.IsInstanceOfType(list.Head, typeof(BrittanyNode<string>));
        }

        [TestMethod]
        public void WhenLinkListIsCreated_HeadIsNull()
        {
            //arrange
            BrittanyLinkedList<string> list = new();
            //act
            BrittanyNode<string>? result = list.Head;
            //assert
            Assert.IsNull(result);
        }

        //[DataRow("Toast", typeof(Node))]
        [TestMethod]
        [DataRow("Foo", "Bar", "Baz")]
        [DataRow("Toast", "Jelly", "Peanut Butter")]
        public void WhenLinkListGetsMultipleItems_ItemsAreInCorrectPosition(string one, string two, string three)
        {
            //arrange
            BrittanyLinkedList<string> list = new BrittanyLinkedList<string>();
            list.AddToBack(one);
            list.AddToBack(two);
            list.AddToBack(three);

            //act
            string? resultOne = list.Get(0);
            string? resultTwo = list.Get(1);
            string? resultThree = list.Get(2);

            //assert
            Assert.AreEqual(resultOne, one);
            Assert.AreEqual(resultTwo, two);
            Assert.AreEqual(resultThree, three);
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(10, 20, 30)]
        [DataRow(-1, 20, -3)]

        public void WhenLinkedListGetsIntegers_IntegersAreReturned(int one, int two, int three)
        {
            // arrange
            BrittanyLinkedList<int> list = new BrittanyLinkedList<int>();


            // act
            list.AddToBack(one);
            list.AddToBack(two);
            list.AddToBack(three);

            int result = list.Get(0);
            // assert
            Assert.AreEqual(result, one);

        }

        [TestMethod]
        [DataRow(true, false, true, true)]
        public void WhenLinkedListGetsBooleans_BooleansAreReturned(bool one, bool two, bool three, bool four)
        {
            BrittanyLinkedList<bool> list = new BrittanyLinkedList<bool>();
            list.AddToBack(one);
            list.AddToBack(two);
            list.AddToBack(three);
            list.AddToBack(four);

            bool result = list.Get(0);
            bool result2 = list.Get(1);
            bool result3 = list.Get(2);
            bool result4 = list.Get(3);

            Assert.AreEqual(result, one);
            Assert.AreEqual(result2, two);
            Assert.AreEqual(result3, three);
            Assert.AreEqual(result4, four);


        }

    }
}
