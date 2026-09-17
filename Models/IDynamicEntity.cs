using System.Collections.Generic;

namespace TinyCreatures
{
    interface IDynamicEntity : IEntity
    {
        Sound[] sounds { get; }

        void Animate(); // Delegates
        Direction SelectPossibleDirection(List<Position> currentEntitiesPositions);
        Position Move(Direction possibleDirection);
    }
}
