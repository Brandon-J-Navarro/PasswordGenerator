﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Model
{
    internal class PasswordGeneratorModel
    {
        public bool ChkIncludeLowerChar { get; set; }
        public bool ChkIncludeUpperChar { get; set; }
        public bool ChkIncludeNumbers { get; set; }
        public bool ChkIncludeSymbols { get; set; }
        public bool ChkExcludeAmbiguous { get; set; }
        public bool ChkExcludeSimilar { get; set; }
        public string StrengthStatus { get; set; }
        public string PasswordLengthInput { get; set; }
        public string Password { get; set; }
    }
}
