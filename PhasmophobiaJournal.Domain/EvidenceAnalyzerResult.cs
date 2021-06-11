using System.Collections.Generic;

namespace PhasmophobiaJournal.Domain
{
    public class EvidenceAnalyzerResult
    {
        public List<Evidence> CurrentEvidences { get; set; }
        public List<Evidence> ExcludedEvidences { get; set; }
        public List<Evidence> PossibleRemainingEvidences { get; set; }
        public List<Ghost> PossibleGhosts { get; set; }
    }
}
