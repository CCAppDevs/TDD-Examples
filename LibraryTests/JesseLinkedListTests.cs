using ClassLibraryExample;

namespace LibraryTests
{
    [TestClass]
    public class JesseLinkedListTests
    {
        // Creating a singly linked list that accepts strings

        [TestMethod]
        [DataRow("Toast")]
        public void LinkedListAcceptsStrings_ReturnsStringData(string input)
        {
            // arrange
            JesseLinkedList list = new JesseLinkedList();

            // act
            list.AddToBack(input);
            string result = list.Get(0);

            // assert
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        [DataRow("Toast")]
        public void LinkedListAcceptsAnItem_HeadReturnsTheData(string input)
        {
            // arrange
            JesseLinkedList list = new JesseLinkedList();
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
            JesseLinkedList list = new JesseLinkedList();

            // act
            list.AddToBack(input);
            
            // assert
            Assert.IsInstanceOfType(list.Head, typeof(Node));
        }

        [TestMethod]
        public void WhenLinkedListIsCreated_HeadIsNull()
        {
            // arrange
            JesseLinkedList list = new JesseLinkedList();

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
            JesseLinkedList list = new JesseLinkedList();
            
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

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(10, 20, 3)]
        [DataRow(-1, 20, -3)]
        public void WhenLinkedListGetsIntegers_IntegersAreReturned(int one, int two, int three)
        {
            // arrange
            JesseLinkedList list = new JesseLinkedList();

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
