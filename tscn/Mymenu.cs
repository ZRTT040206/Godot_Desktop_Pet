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
		//InputEventMouse类型的实例可以用ButtonMask检测输入的变量
		if(mouse.IsPressed() && Input.IsActionPressed("click_left"))//Input.IsActionPressed("click_left")在键位映射中可以定义
		{
			GD.Print(mouse.ButtonMask);
		}
		//GD.Print(mouse.Position);
	}
}
