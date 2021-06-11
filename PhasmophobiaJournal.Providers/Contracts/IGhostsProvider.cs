using PhasmophobiaJournal.Domain;
using System.Collections.Generic;

namespace PhasmophobiaJournal.Providers.Contracts
{
    public interface IGhostsProvider
    {
        List<Ghost> GetAllGhosts();
    }
}
