using System.ComponentModel;

namespace PhasmophobiaJournal.Domain
{
    public enum Evidence
    {
        [Description("EMF Level 5")]
        EMFLevel5,

        [Description("Spirit Box")]
        SpiritBox,

        [Description("Fingerprints")]
        Fingerprints,

        [Description("Ghost Orb")]
        GhostOrb,

        [Description("Ghost Writing")]
        GhostWriting,

        [Description("Freezing Temperatures")]
        FreezingTemperatures
    }
}
