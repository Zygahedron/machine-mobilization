using System;
using SFML.Graphics;
using SFML.Window;

namespace Machine_Mobilization;

internal interface IMouseInteractable
{
	public IntRect BoundingBox { get; set; }

	public bool IsMouseOver(int mouseX, int mouseY) => this.BoundingBox.Contains(mouseX, mouseY);

	public void OnMouseEnter()                   { }
	public void OnMouseHover(TimeSpan deltaTime) { }
	public void OnMouseExit()                    { }

	public void OnMouseButtonDown(Mouse.Button button)                     { }
	public void OnMouseButtonHold(Mouse.Button button, TimeSpan deltaTime) { }
	public void OnMouseButtonUp(Mouse.Button button)                       { }

	public void OnMouseScroll(float deltaScroll) { }
}
