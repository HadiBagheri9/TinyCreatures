using System;
using System.Collections.Generic;

namespace TinyCreatures
{
    interface IEntity
    {
        Position Position { get; set; }
        Size Size { get; }


        List<Position> FindPossibleSpawnPoints(List<Position> currentEntitiesPositions);
        Position SelectSpawnPoint(List<Position> possiblePositions);
        void Spawn(Position position, ConsoleColor color);
    }
}
