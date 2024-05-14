using ClassLibraryExample;

namespace LibraryTests
{
    [TestClass]
    internal class KaiLinkedListTest
    {
        // Creating a singly linked list that accepts strings.
        // Primitive data types are basic things that exist.
        /*
            Shopping list
            
            Bread
            Milk
            Cheese
         
         */
        [TestMethod]
        [DataRow("Toast")]

        public void LinkedListAcceptsStrings_ReturnsStringData(string input)
        {
            // arrange
            KaiLinkedList list = new KaiLinkedList();

            // act
            list.AddToBack(input);
            string result = list.Get(0);

            // assert
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        [DataRow("Toast")] // Set what comes in and then what it expects.
        public void LinkedListAcceptsAnItem_HeadReturnsTheItem(string input)
        {
            // arrange
            KaiLinkedList list = new KaiLinkedList();
            Node expected = new Node(input);

            // act
            list.AddToBack(input);

            Node result = list.Head;

            // assert
            Assert.AreEqual(result.Data, expected.Data);
        }

        [TestMethod]
        [DataRow("Toast")]

        public void LinkedListAcceptsAnItem_CreatesANodeInTheHead(string input)
        {
            // arrange
            KaiLinkedList list = new KaiLinkedList();

            // act
            list.AddToBack(input);

            // assert
            Assert.IsInstanceOfType(list.Head, typeof(Node));
        }

        [TestMethod]

        public void WhenLinkedListIsCreated_HeadIsNull()
        {
            // arrange
            KaiLinkedList list = new KaiLinkedList();

            // act
            Node? result = list.Head;

            // assert
            Assert.IsNull(result);
        }

        [TestMethod]
        [DataRow("Foo", "Bar", "Baz")]
        [DataRow("Toast", "Jelly", "Peanut Butter")]

        public void WhenLinkedListGetsMultipleItems_ItemsAreInCorrectPosition(string one, string two, string three)
        {
            // arrange
            KaiLinkedList list = new KaiLinkedList();

            // act
            list.AddToBack(one);
            list.AddToBack(two);
            list.AddToBack(three);

            string? resultone = list.Get(0);
            string? resulttwo = list.Get(1);
            string? resultthree = list.Get(2);

            // assert
            Assert.AreEqual(resultone, one);
            Assert.AreEqual(resulttwo, two);
            Assert.AreEqual(resultthree, three);
        }

    }
}
