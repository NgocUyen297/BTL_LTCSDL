﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CuaHangVatTu.Common.Request
{
    public class SearchVatTuRequest
    {
        public string Keyword { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
