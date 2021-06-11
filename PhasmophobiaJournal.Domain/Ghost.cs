using System;
using System.Collections.Generic;

namespace PhasmophobiaJournal.Domain
{
    public class Ghost
    {
        public string Type { get; set; }
        public string Strength { get; set; }
        public string Weakness { get; set; }
        public List<Evidence> Evidences { get; set; }
    }
}
