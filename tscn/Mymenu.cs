using Godot;
using System;
public partial class Mymenu : Node2D
{
	private Vector2 pos;
	private bool IsDragging = false;
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
			pos = mouse.Position;
			IsDragging = true;
			pos = mouse.Position;
			GD.Print(pos);
			//GetTree().Root.Position+=pos;
		}
		else{
			IsDragging = false;
		}
		if(IsDragging)
		{
			Vector2 poss = GetViewport().GetWindow().GetPosition() + (mouse.Position - pos);
			GD.Print(poss);
			Vector2I poss2 = new Vector2I((int)poss.X,(int)poss.Y);
			GD.Print(poss2);
			GetViewport().GetWindow().SetPosition(poss2);
		}	
		//GD.Print(mouse.Position);
	}
	public void closeAll()
	{
		GetTree().Quit();
		// Node Roots= GetNode("/root");
		// Roots.QueueFree();
	}
}
