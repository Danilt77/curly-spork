﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Rootobject
    {
        public Parsedresult[] ParsedResults { get; set; }
        public int OCRExitCode { get; set; }
        public bool IsErroredOnProcessing { get; set; }
        public string ProcessingTimeInMilliseconds { get; set; }
        public string SearchablePDFURL { get; set; }
    }

    public class Parsedresult
    {
        public Textoverlay TextOverlay { get; set; }
        public string TextOrientation { get; set; }
        public int FileParseExitCode { get; set; }
        public string ParsedText { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetails { get; set; }
    }

    public class Textoverlay
    {
        public object[] Lines { get; set; }
        public bool HasOverlay { get; set; }
        public string Message { get; set; }
    }
}
