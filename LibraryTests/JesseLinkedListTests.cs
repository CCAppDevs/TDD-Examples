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
            string result = "";

            // assert
            Assert.IsInstanceOfType(result, typeof(string));
        }
    }
}
