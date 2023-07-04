using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program.org.bug1422.emailRegex.nunit.core
{
    public class RegexUtility
    {
        public static bool isValid(string emailaddress)
        {
            Regex pattern = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
            return pattern.IsMatch(emailaddress);
        }
    }
}
