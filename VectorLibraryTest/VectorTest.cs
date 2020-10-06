using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using static VectorLibrary.Vector;

namespace VectorLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidationNaturalInt_7_returnedTrue()
        {
            //arrange
            int number = 7;
            bool expected = true;
            
            //actual
            bool actual = ValidationNaturalInt(number);
            
            //assert
            AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ValidationNaturalInt_0_returnedFalse()
        {
            //arrange
            int number = 0;
            bool expected = false;
            
            //actual
            bool actual = ValidationNaturalInt(number);
            
            //assert
            AreEqual(expected, actual);
        }
    }
}