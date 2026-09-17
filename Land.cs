using System;

namespace TinyCreatures
{
    class Land
    {
        public Size ScreenSize { get; }

        public Land(Size size, ConsoleColor color)
        {
            ScreenSize = size;
            Console.SetWindowSize(ScreenSize.Width, (ScreenSize.Height / 2));
            Console.BackgroundColor = color;
            Console.Clear();
        }
    }
}
