using NUnit.Framework;
using static Program.org.bug1422.emailRegex.nunit.core.RegexUtility;
namespace Test
{
    [TestFixture]
    public class RegexUtilityDDTTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("example@fpt.edu.vn", ExpectedResult = true)]
        [TestCase("example.first.middle.lastname@email.com", ExpectedResult = true)]
        [TestCase("example@subdomain.email.com", ExpectedResult = true)]
        [TestCase("0987654321@example.com", ExpectedResult = true)]
        [TestCase("_______@email.com", ExpectedResult = true)]
        [TestCase("example.firstname-lastname@email.com", ExpectedResult = true)]
        [TestCase("abcde", ExpectedResult = false)]
        [TestCase("@#@@##@%^%#$@#$@#.com", ExpectedResult = false)]
        public bool Test1(string email)
        {
            return isValid(email);
        }
    }
}