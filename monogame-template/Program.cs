using System;
using System.Collections.Generic;

namespace MonoGameTemplate {
	static class Program {
		private static Game1 game;

		[STAThread]
		static void Main() {
			game = new Game1();
			game.Run();
		}
	}
}