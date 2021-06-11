using System.ComponentModel;

namespace PhasmophobiaJournal.Domain
{
    public enum State
    {
        [Description("Current")]
        Current,

        [Description("Possible")]
        Possible,

        [Description("Excluded")]
        Excluded,

        [Description("Impossible")]
        Impossible
    }
}
