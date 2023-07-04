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
        [Test]
        public void Test1()
        {
            Assert.That(isValid("abc@gmail.com"), Is.EqualTo(true));
        }
        [Test]
        public void Test2()
        {
            Assert.That(isValid("abc@fpt.edu.vn"), Is.EqualTo(true));
        }
        [Test]
        public void Test3()
        {
            Assert.That(isValid("abcd"), Is.EqualTo(false));
        }
    }
}
