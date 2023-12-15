using Godot;

namespace F0;

public partial class LevelCamera : Camera2D
{
    private const float Speed = 400.0f;
    private Vector2 _direction = Vector2.Zero;

    public LevelCamera(float startX, float startY)
    {
        Position = new Vector2(startX, startY);
    }

    public override void _PhysicsProcess(double delta)
    {
        // Move the camera.
        var velocity = _direction * Speed;
        Position += velocity * (float)delta;
    }

    public override void _Input(InputEvent @event)
    {
        if (@event.IsActionPressed("Right") || @event.IsActionPressed("Left"))
            _direction.X = (@event.IsActionPressed("Left") ? 1 : 0) - (@event.IsActionPressed("Right") ? 1 : 0);
        else if (@event.IsActionReleased("Right") || @event.IsActionReleased("Left"))
            _direction.X = (@event.IsActionPressed("Left") ? 1 : 0) - (@event.IsActionPressed("Right") ? 1 : 0);
        if (@event.IsActionPressed("Down") || @event.IsActionPressed("Up"))
            _direction.Y = (@event.IsActionPressed("Down") ? 1 : 0) - (@event.IsActionPressed("Up") ? 1 : 0);
        else if (@event.IsActionReleased("Down") || @event.IsActionReleased("Up"))
            _direction.Y = (@event.IsActionPressed("Down") ? 1 : 0) - (@event.IsActionPressed("Up") ? 1 : 0);
    }
}