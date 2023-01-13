using SFML.Graphics;
using SFML.Window;
using System.Collections.Generic;
using SFML.System;

namespace Machine_Mobilization;

internal static class Game
{
	public static readonly Vector2u Resolution = new(800, 600);

	public static AssetManager AssetManager { get; } = new();

	public static RenderWindow Window { get; } =
		new(new VideoMode(Resolution.X, Resolution.Y), "Machine Mobilization", Styles.Close | Styles.Titlebar);

	public static List<Robot> Robots { get; set; } = new(8);

	public static void Init() { }

	public static void Close()
	{
		Window.Close();
	}
}
