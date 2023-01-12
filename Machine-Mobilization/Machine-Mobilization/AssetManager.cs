using System.Collections.Generic;
using SFML.Graphics;

namespace Machine_Mobilization;

internal class AssetManager
{
	public Texture? GetTexture(string name) =>
		this._textures.TryGetValue(name, out Texture? texture) ? texture : null;

	public Texture? LoadTexture(string name, string filename)
	{
		var texture = new Texture(filename);

		if (this._textures.ContainsKey(name))
			this._textures[name] = texture;
		else
			this._textures.Add(name, texture);

		return this._textures[name];
	}

	public void UnloadTexture(string name) => this._textures.Remove(name);
	public void ClearTextures()            => this._textures.Clear();

	private readonly Dictionary<string, Texture> _textures = new();
}
