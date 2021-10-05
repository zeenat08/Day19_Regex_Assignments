﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex_Assignments
{
    class UC5_6_7_8_Password
    {
        public static string Regex_PSWD = "^([a-zA-Z0-9]*[A-Z]{1,}[0-9]{1,}[$#.%+@-~!]{1}){8,}$";

            public bool ValidatePassword(string password)
            {
                return Regex.IsMatch(password, Regex_PSWD);
            }
    }
}
