using PhasmophobiaJournal.Domain;
using PhasmophobiaJournal.Providers.Contracts;
using System.Collections.Generic;

namespace PhasmophobiaJournal.Providers
{
    public class PhasmophobiaGhostsProvider : IGhostsProvider
    {
        public List<Ghost> GetAllGhosts()
        {
            return new List<Ghost>
            {
                new Ghost
                {
                    Type = "Spirit",
                    Strength = "Nothing",
                    Weakness = "Using Smudge Sticks on a Spirit will stop it attacking for a long period of time",
                    Evidences = new List<Evidence>
                    {
                        Evidence.Fingerprints,
                        Evidence.GhostWriting,
                        Evidence.SpiritBox
                    }
                },
                new Ghost
                {
                    Type = "Wraith",
                    Strength = "Wraiths almost never touch the ground meaning it can’t be tracked by footsteps",
                    Weakness = "Wraiths have a toxic reaction to Salt",
                    Evidences = new List<Evidence>
                    {
                        Evidence.Fingerprints,
                        Evidence.FreezingTemperatures,
                        Evidence.SpiritBox
                    }
                },
                new Ghost
                {
                    Type = "Phantom",
                    Strength = "Looking at a Phantom will considerably drop your sanity",
                    Weakness = "Taking a photo of the Phantom will make it temporarily disappear",
                    Evidences = new List<Evidence>
                    {
                        Evidence.EMFLevel5,
                        Evidence.FreezingTemperatures,
                        Evidence.GhostOrb
                    }
                },
                new Ghost
                {
                    Type = "Poltergeist",
                    Strength = "A Poltergeist can throw huge amounts of objects at once",
                    Weakness = "A Poltergeist is almost ineffective in an empty room",
                    Evidences = new List<Evidence>
                    {
                        Evidence.Fingerprints,
                        Evidence.GhostOrb,
                        Evidence.SpiritBox
                    }
                },
                new Ghost
                {
                    Type = "Banshee",
                    Strength = "A Banshee will only target one person at a time",
                    Weakness = "Banshees fear the Crucifix and will be less aggressive when near one",
                    Evidences = new List<Evidence>
                    {
                        Evidence.EMFLevel5,
                        Evidence.Fingerprints,
                        Evidence.FreezingTemperatures
                    }
                },
                new Ghost
                {
                    Type = "Jinn",
                    Strength = "A Jinn will travel at a faster speed if it’s victim is far away",
                    Weakness = "Turning off the locations power source will prevent the Jinn from using it’s ability",
                    Evidences = new List<Evidence>
                    {
                        Evidence.EMFLevel5,
                        Evidence.GhostOrb,
                        Evidence.SpiritBox
                    }
                },
                new Ghost
                {
                    Type = "Mare",
                    Strength = "A Mare will have an increased chance to attack in the dark",
                    Weakness = "Turning the lights on around the Mare will lower it’s chance to attack",
                    Evidences = new List<Evidence>
                    {
                        Evidence.FreezingTemperatures,
                        Evidence.GhostOrb,
                        Evidence.SpiritBox
                    }
                },
                new Ghost
                {
                    Type = "Revenant",
                    Strength = "A Revenant will travel at a significantly faster speed when hunting a victim",
                    Weakness = "Hiding from the Revenant will cause it to move very slowly",
                    Evidences = new List<Evidence>
                    {
                        Evidence.EMFLevel5,
                        Evidence.Fingerprints,
                        Evidence.GhostWriting
                    }
                },
                new Ghost
                {
                    Type = "Shade",
                    Strength = "Being shy means the Ghost will be harder to find",
                    Weakness = "The Ghost will not enter hunting mode if there is multiple people nearby",
                    Evidences = new List<Evidence>
                    {
                        Evidence.EMFLevel5,
                        Evidence.GhostOrb,
                        Evidence.GhostWriting
                    }
                },
                new Ghost
                {
                    Type = "Demon",
                    Strength = "Demons will attack more often then any other Ghost",
                    Weakness = "Asking a Demon successful questions on the Ouija Board won’t lower the users sanity",
                    Evidences = new List<Evidence>
                    {
                        Evidence.FreezingTemperatures,
                        Evidence.GhostWriting,
                        Evidence.SpiritBox
                    }
                },
                new Ghost
                {
                    Type = "Yurei",
                    Strength = "Yureis have been known to have a stronger effect on people’s sanity",
                    Weakness = "Smudging the Yurei’s room will cause it to not wander around the location for a long time",
                    Evidences = new List<Evidence>
                    {
                        Evidence.FreezingTemperatures,
                        Evidence.GhostOrb,
                        Evidence.GhostWriting
                    }
                },
                new Ghost
                {
                    Type = "Oni",
                    Strength = "Oni’s are more active when people are nearby and have been seen moving objects at great speed",
                    Weakness = "Being more active will make the Oni easier to find and identify",
                    Evidences = new List<Evidence>
                    {
                        Evidence.EMFLevel5,
                        Evidence.GhostWriting,
                        Evidence.SpiritBox
                    }
                },
                new Ghost
                {
                    Type = "Yokai",
                    Evidences = new List<Evidence>
                    {
                        Evidence.SpiritBox,
                        Evidence.GhostOrb,
                        Evidence.GhostWriting
                    }
                },
                new Ghost
                {
                    Type = "Hantu",
                    Evidences = new List<Evidence>
                    {
                        Evidence.Fingerprints,
                        Evidence.GhostOrb,
                        Evidence.GhostWriting
                    }
                },
            };
        }
    }
}
