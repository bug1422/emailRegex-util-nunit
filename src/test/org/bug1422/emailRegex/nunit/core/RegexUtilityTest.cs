using NUnit.Framework;
using static Program.org.bug1422.emailRegex.nunit.core.RegexUtility;
namespace Main.src.test.org.bug1422.emailRegex.nunit.core
{
    [TestFixture]
    public class RegexUtilityTest
    {
        [SetUp]
        public void Setup()
        {
        }
        public void Test1()
        {
            Assert.AreEqual(true, isValid("abc@gmail.com"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(true, isValid("abc@fpt.edu.vn"));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, isValid("abcd"));
        }
    }
}
