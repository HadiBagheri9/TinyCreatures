using System.Collections.Generic;

namespace YellowCreatures
{
    abstract class Entity
    {
        public Position Position { get; set; }
        public Size Size { get; set; }

        public Entity(Size size)
        {
            Size = size;
        }
        
        private List<Position> FindPossiblePositions(List<Entity> currentEntitiesPositions)
        {
            List<Position> possiblePositions = new List<Position>();



            return possiblePositions;
        }
    }
}
