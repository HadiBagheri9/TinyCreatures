using System;
using System.Collections.Generic;

namespace TinyCreatures
{
    abstract class DynamicEntity : IDynamicEntity
    {
        public Position Position { get; set; }
        public Size Size { get; }
        public Sound[] sounds { get; }



        // ****** Spawn ******

        public List<Position> FindPossibleSpawnPoints(List<Position> currentEntitiesPositions)
        {
            throw new NotImplementedException(); // Linq
        }
        public Position SelectSpawnPoint(List<Position> possiblePositions)
        {
            Random r = new Random();
            return possiblePositions[r.Next(0, possiblePositions.Count)];
        }
        public void Spawn(Position position, ConsoleColor color)
        {
            throw new NotImplementedException();
        }



        // ****** Movement ******

        public Direction SelectPossibleDirection(List<Position> currentEntitiesPositions)
        {
            throw new NotImplementedException(); // Linq
        }
        public Position Move(Direction possibleDirection)
        {
            throw new NotImplementedException();
        }
        public abstract void Animate(); // Delegates
    }
}
