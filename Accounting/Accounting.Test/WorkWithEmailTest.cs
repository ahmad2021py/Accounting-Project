using Accounting.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Accounting.Test
{
    [TestClass]
    public class CheckSizeOfFile
    {
        [TestMethod]
        public void IsValidateEmail_____Send__a_Correct_Email____Return_True()
        {
            ///arrange
            string emailAddress = "ahmadbh.mail@gmail.com";
            var expected = true;
            ///act
            bool actual = WorkWithEmail.IsValidateEmail(emailAddress);

            ///assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void IsValidateEmail_____Send__a_Wrong_Email____Return_False()
        {
            ///arrange
            string emailAddress = "ahmadbh.mailgmail.com";
            var expected = false;
            ///act
            bool actual = WorkWithEmail.IsValidateEmail(emailAddress);

            ///assert
            Assert.AreEqual(expected, actual);
        }






    }
}

