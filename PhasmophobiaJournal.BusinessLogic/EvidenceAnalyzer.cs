using PhasmophobiaJournal.BusinessLogic.Helpers;
using PhasmophobiaJournal.Domain;
using PhasmophobiaJournal.Providers.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace PhasmophobiaJournal.BusinessLogic
{
    public class EvidenceAnalyzer
    {
        private List<Ghost> allGhosts;
        private List<Evidence> allEvidences;

        private readonly IGhostsProvider ghostsProvider;

        public EvidenceAnalyzer(IGhostsProvider ghostsProvider)
        {
            this.ghostsProvider = ghostsProvider; 

            Initialize();
        }

        public EvidenceAnalyzerResult Analyze(List<Evidence> currentEvidences, List<Evidence> excludedEvidences)
        {
            var possibleGhosts = GetPossibleGhosts(currentEvidences, excludedEvidences);
            var possibleRemainingEvidences = GetPossibleRemainingEvidences(currentEvidences, excludedEvidences, possibleGhosts);

            return new EvidenceAnalyzerResult
            {
                CurrentEvidences = currentEvidences,
                ExcludedEvidences = excludedEvidences,
                PossibleGhosts = possibleGhosts,
                PossibleRemainingEvidences = possibleRemainingEvidences
            };
        }

        private List<Evidence> GetPossibleRemainingEvidences(List<Evidence> currentEvidences, List<Evidence> excludedEvidences, List<Ghost> possibleGhosts)
        {
            return allEvidences
                .Except(currentEvidences)
                .Except(excludedEvidences)
                .Where(e => possibleGhosts.Any(ghost => ghost.Evidences.Contains(e)))
                .ToList();
        }

        private List<Ghost> GetPossibleGhosts(List<Evidence> currentEvidences, List<Evidence> excludedEvidences)
        {
            return allGhosts
                .Where(ghost => currentEvidences.All(e => ghost.Evidences.Contains(e)) 
                                && excludedEvidences.All(e => !ghost.Evidences.Contains(e)))
                .ToList();
        }

        private void Initialize()
        {
            allGhosts = ghostsProvider.GetAllGhosts();

            allEvidences = Helper.GetAllEvidences();
        }
    }
}
