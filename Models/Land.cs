using System;

namespace TinyCreatures
{
    class Land
    {
        public Size ScreenSize { get; }

        public Land(Size size, ConsoleColor color)
        {
            Console.SetWindowSize(size.Width, (size.Height / 2));
            Console.BackgroundColor = color;
            Console.Clear();
            // Console.SetWindowPosition(3, 15);
        }
    }
}
