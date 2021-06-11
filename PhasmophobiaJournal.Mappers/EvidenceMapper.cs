using PhasmophobiaJournal.Domain;
using PhasmophobiaJournal.Domain.Extensions;

namespace PhasmophobiaJournal.Mappers
{
    public class EvidenceMapper
    {
        public Evidence GetEvidence(string evidenceDescription)
        {
            return EnumExtensions.GetEnumFromDescription<Evidence>(evidenceDescription);
        }

        public string GetEvidenceDescription(Evidence evidence)
        {
            return evidence.GetDescription();
        }
    }
}
