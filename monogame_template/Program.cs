using System;

namespace monogame_template
{
    public class Program
    {
        static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
}
