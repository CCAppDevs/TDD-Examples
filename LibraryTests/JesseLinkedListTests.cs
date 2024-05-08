using ClassLibraryExample;

namespace LibraryTests
{
    [TestClass]
    public class JesseLinkedListTests
    {
        // Creating a singly linked list that accepts strings

        [TestMethod]
        public void LinkedListAcceptsStrings_ReturnsStringData()
        {
            // arrange
            JesseLinkedList list = new JesseLinkedList();

            // act
            string result = list.Get(1);

            // assert
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        [DataRow("Toast")]
        public void LinkedListAcceptsAnItem_HeadReturnsTheItem(string input)
        {
            // arrange
            JesseLinkedList list = new JesseLinkedList();

            // act
                // add in some way to add the input item to the list
                list.Add(input);

            Node result = list.Head;

            // assert
            Assert.AreEqual(result, new Node() { Data = "Toast" });
        }
    }
}
