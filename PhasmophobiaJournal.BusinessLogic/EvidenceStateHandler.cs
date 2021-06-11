using PhasmophobiaJournal.BusinessLogic.Helpers;
using PhasmophobiaJournal.Domain;
using System.Collections.Generic;
using System.Linq;

namespace PhasmophobiaJournal.BusinessLogic
{
    public class EvidenceStateHandler
    {
        private readonly List<Evidence> allEvidences;

        public EvidenceStateHandler()
        {
            allEvidences = Helper.GetAllEvidences();
        }

        public List<EvidenceState> GetInitialEvidenceStates()
        {
            return allEvidences
                .Select(evidence => new EvidenceState
                {
                    Evidence = evidence,
                    State = State.Possible
                })
                .ToList();
        }

        public List<EvidenceState> GetEvidencesState(EvidenceAnalyzerResult evidenceAnalyzerResult)
        {
            return allEvidences
                .Select(evidence => new EvidenceState
                {
                    Evidence = evidence,
                    State = GetState(evidence, evidenceAnalyzerResult)
                })
                .ToList();
        }

        private State GetState(Evidence evidence, EvidenceAnalyzerResult evidenceAnalyzerResult)
        {
            if (evidenceAnalyzerResult.CurrentEvidences.Contains(evidence))
                return State.Current;

            if (evidenceAnalyzerResult.ExcludedEvidences.Contains(evidence))
                return State.Excluded;

            if (evidenceAnalyzerResult.PossibleRemainingEvidences.Contains(evidence))
                return State.Possible;

            return State.Impossible;
        }
    }
}
