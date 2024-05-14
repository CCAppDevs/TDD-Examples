using ClassLibraryExample;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Runtime.CompilerServices;

namespace LibraryTests
{
    [TestClass]
    public class CTN_LinkedList_TEST
    {
        [TestMethod]
        [DataRow("Toast")]
        public void LinkedList_ACEEPTS_Strings_RETURNS_String(string input)
        {
            //Arrange
            CTN_LinkedList ll = new();
            //Act
            ll.PushFront(input);
            string result = ll.Get(0);
            //Assert
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        [DataRow("Toast")]
        public void LinkedList_ACEEPTS_Item_RETURNS_HeadItem(string input)
        {
            //Arrange
            CTN_LinkedList ll = new();
            CTN_Node expected = new CTN_Node(input);
            //Act
            ll.PushFront(input);
            CTN_Node result = ll.head;
            //Assert
            Assert.AreEqual(result.data, expected.data);
        }

        [TestMethod]
        public void LinkedListCreatedHead_IS_Null()
        {
            //Arrange
            CTN_LinkedList ll = new();

            //Act
            CTN_Node? result = ll.head;

            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        [DataRow("Juan", "Tooh", "Tree")]
        [DataRow("Toast", "Jelly", "Crunchy PB")]
        public void LinkedList_ACCEPTS_Strings_CHECKS_InRightPlaces(string one, string two, string three)
        {
            //Arrange
            CTN_LinkedList ll = new();

            //Act
            ll.PushBack(one);
            ll.PushBack(two);
            ll.PushBack(three);

            string? resultOne = ll.Get(0);
            string? resultTwo = ll.Get(1);
            string? resultThree = ll.Get(2);

            //Assert
            Assert.AreEqual(resultOne, one);
            Assert.AreEqual(resultTwo, two);
            Assert.AreEqual(resultThree, three);
        }
    }
}
