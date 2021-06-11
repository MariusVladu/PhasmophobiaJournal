using PhasmophobiaJournal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhasmophobiaJournal.BusinessLogic.Helpers
{
    public static class Helper
    {
        public static List<Evidence> GetAllEvidences()
        {
            return Enum.GetValues(typeof(Evidence)).Cast<Evidence>().ToList();
        }
    }
}
