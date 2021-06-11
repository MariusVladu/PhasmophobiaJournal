using PhasmophobiaJournal.Domain;
using PhasmophobiaJournal.Domain.Extensions;

namespace PhasmophobiaJournal.Mappers
{
    public class StateMapper
    {
        public State GetState(string stateDescription)
        {
            return EnumExtensions.GetEnumFromDescription<State>(stateDescription);
        }

        public string GetStateDescription(State state)
        {
            return state.GetDescription();
        }
    }
}
