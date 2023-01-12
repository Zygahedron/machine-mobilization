
using SFML.Graphics;
using SFML.Window;
using System.Collections.Generic;

namespace Machine_Mobilization;

internal static class Game
{
	public static AssetManager AssetManager { get; } = new();

	public static RenderWindow Window { get; } =
		new(new VideoMode(800, 600), "Machine Mobilization", Styles.Close | Styles.Titlebar);

	public static List<Robot> Players = new(8);

	public static void Close()
	{
		Window.Close();
	}
}

