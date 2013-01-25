using System;

namespace tron.bob.nick
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (TronGame game = new TronGame())
            {
                game.Run();
            }
        }
    }
#endif
}

