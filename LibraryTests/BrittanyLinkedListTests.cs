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
            BrittanyLinkedList list = new();
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
            BrittanyLinkedList list = new BrittanyLinkedList();
            BrittanyNode expected = new BrittanyNode(input);
            //act
            list.AddToBack(input);
            BrittanyNode result = list.Head;
            //assert
            Assert.AreEqual(result.Data, expected.Data);
        }

        [TestMethod]
        [DataRow("Toast")]
        public void LinkedListAcceptsAnItem_CreatesANodeInTheHead(string input)
        {
            //arrange
            BrittanyLinkedList list = new();
            //act
            list.AddToBack(input);

            //assert
            Assert.IsInstanceOfType(list.Head, typeof(BrittanyNode));
        }

        [TestMethod]
        public void WhenLinkListIsCreated_HeadIsNull()
        {
            //arrange
            BrittanyLinkedList list = new();
            //act
            BrittanyNode? result = list.Head;
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
            BrittanyLinkedList list = new BrittanyLinkedList();
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
            BrittanyLinkedList list = new BritanyLinkedList();


            // act
            list.AddToBack(one);
            list.AddToBack(two);
            list.AddToBack(three);

            int result = list.Get(0);
            // assert
            Assert.AreEqual(result, one);

        }

    }
}
