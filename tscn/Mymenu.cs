using Godot;
using System;

public partial class Mymenu : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}
	
	public override void _Input(InputEvent @event)
	{
		InputEventMouse mouse  = @event as InputEventMouse;
		if(mouse.IsPressed())
		{
			GD.Print(mouse.ButtonMask);
		}
		//GD.Print(mouse.Position);
	}
}
