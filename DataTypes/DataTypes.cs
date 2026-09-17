using System;

namespace TinyCreatures
{
    class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
    class Position
    {
        public uint PosX { get; set; }
        public uint PosY { get; set; }
    }
    enum Direction
    {
        Left, Up, Right, Down
    }
    class Sound
    {
        public int Frequency { get; }
        public int Duration { get; }

        public void Play()
        {
            Console.Beep(Frequency, Duration);
        }
        public Sound(int frequency, int duration)
        {
            Frequency = frequency;
            Duration = duration;
        }
    }
}
