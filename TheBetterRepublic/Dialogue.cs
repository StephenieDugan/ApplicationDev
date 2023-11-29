﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterRepublic.Utilities
{
    internal class Dialogue
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public Action<int> OnOptionSelected { get; set; }
    }
}
