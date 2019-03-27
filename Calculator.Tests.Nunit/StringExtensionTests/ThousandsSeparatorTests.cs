using Calculator.Library.Extensions;
using NUnit.Framework;

namespace Calculator.Tests.Nunit.StringExtensionTests
{
    [TestFixture]
    public class ThousandsSeparatorTests
    {
        [Test]
        public void Test_01_6900()
        {

            // Arrange            
            const string input = "6900";
            const string expected = "6,900";


            // Act
            var actual = input.FormatWithThousandsSeparator();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_02_4933dot786()
        {

            // Arrange            
            const string input = "4933.786";
            const string expected = "4,933.786";


            // Act
            var actual = input.FormatWithThousandsSeparator();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_03_100dot02()
        {

            // Arrange            
            const string input = "100.02";
            const string expected = "100.02";


            // Act
            var actual = input.FormatWithThousandsSeparator();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_04_0dot02()
        {

            // Arrange            
            const string input = "0.02";
            const string expected = "0.02";


            // Act
            var actual = input.FormatWithThousandsSeparator();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_05_Minus1000dot05()
        {

            // Arrange            
            const string input = "-1000.05";
            const string expected = "-1,000.05";


            // Act
            var actual = input.FormatWithThousandsSeparator();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_06_Minus0dot05()
        {

            // Arrange            
            const string input = "-0.05";
            const string expected = "-0.05";


            // Act
            var actual = input.FormatWithThousandsSeparator();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_07_Minus40dot05()
        {

            // Arrange            
            const string input = "-40.05";
            const string expected = "-40.05";


            // Act
            var actual = input.FormatWithThousandsSeparator();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_08_Minus440dot0()
        {

            // Arrange            
            const string input = "-440.0";
            const string expected = "-440.0";


            // Act
            var actual = input.FormatWithThousandsSeparator();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_09_0dot0()
        {

            // Arrange            
            const string input = "0.0";
            const string expected = "0.0";


            // Act
            var actual = input.FormatWithThousandsSeparator();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_10_0dot1()
        {

            // Arrange            
            const string input = "0.1";
            const string expected = "0.1";


            // Act
            var actual = input.FormatWithThousandsSeparator();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_11_Minus0dot()
        {

            // Arrange            
            const string input = "-0.";
            const string expected = "-0.";


            // Act
            var actual = input.FormatWithThousandsSeparator();


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
