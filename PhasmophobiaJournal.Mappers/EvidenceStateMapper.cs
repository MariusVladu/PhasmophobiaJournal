using PhasmophobiaJournal.Domain;
using PhasmophobiaJournal.Domain.ViewModels;

namespace PhasmophobiaJournal.Mappers
{
    public class EvidenceStateMapper
    {
        private readonly EvidenceMapper evidenceMapper;
        private readonly StateMapper stateMapper;

        public EvidenceStateMapper()
        {
            evidenceMapper = new EvidenceMapper();
            stateMapper = new StateMapper();
        }

        public EvidenceState GetEvidenceState(EvidenceStateVM evidenceStateVM)
        {
            return new EvidenceState
            {
                Evidence = evidenceMapper.GetEvidence(evidenceStateVM.Evidence),
                State = stateMapper.GetState(evidenceStateVM.State)
            };
        }

        public EvidenceStateVM GetEvidenceStateVM(EvidenceState evidenceState)
        {
            return new EvidenceStateVM
            {
                Evidence = evidenceMapper.GetEvidenceDescription(evidenceState.Evidence),
                State = stateMapper.GetStateDescription(evidenceState.State)
            };
        }
    }
}
