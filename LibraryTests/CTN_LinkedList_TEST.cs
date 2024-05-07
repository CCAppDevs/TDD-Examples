using ClassLibraryExample;
using System.Runtime.CompilerServices;

namespace LibraryTests
{
    [TestClass]
    public class CTN_LinkedList_TEST
    {
        [TestMethod]
        public void LinkedList_Accepts_Strings_Returns_StringData()
        {
            //Arrange
            CTN_LinkedList ll = new();
            string result = string.Empty;
            //Act

            //Assert
            Assert.IsInstanceOfType(result, typeof(string));
        }
    }
}
