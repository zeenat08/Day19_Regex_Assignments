using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex_Assignments
{
    class UC4_Mobile_No
    {
        public static string Regex_MobileNumber = "^[0-9]{2}[ ][0-9]{10}$";

        public bool ValidatePhoneNumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, Regex_MobileNumber);
        }
    }
}
