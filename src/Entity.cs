using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Godot;
using Node = F0.Schemas.Node;

public partial class Entity : CharacterBody2D
{
    public const float Speed = 300.0f;
    public const float JumpVelocity = -400.0f;

    // Get the gravity from the project settings to be synced with RigidBody nodes.
    public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

    private void SetSpriteAnimation(string name, int startRange, int endRange, int spriteWidth, int sprintHeight,
        int xOffset, int yOffset, SpriteFrames spriteFrames, Texture2D texture, float fps = 12)
    {
        spriteFrames.AddAnimation(name);
        spriteFrames.SetAnimationLoop(name, true);
        foreach (var i in Enumerable.Range(startRange, endRange - startRange))
        {
            var atlas = new AtlasTexture();
            atlas.Atlas = texture;
            atlas.Region = new Rect2(xOffset + spriteWidth * i, yOffset, spriteWidth, sprintHeight);
            spriteFrames.AddFrame(name, atlas);
            spriteFrames.SetAnimationSpeed(name, fps);
        }
    }

    private void LoadTexture(Texture2D texture, int unitWidth, int unitHeight)
    {
        var textureWidth = texture.GetSize().X;
        var textureHeight = texture.GetSize().Y;
        var animSprite = new AnimatedSprite2D();
        animSprite.SpriteFrames = new SpriteFrames();
        var spriteFrames = animSprite.SpriteFrames;
        SetSpriteAnimation("idle", 1, 2, unitWidth, unitHeight, 0, 0, spriteFrames, texture);
        // Aruku style
        if (textureWidth.CompareTo(256) == 0 && textureHeight.CompareTo(256) == 0)
        {
            SetSpriteAnimation("down", 1, 4, unitWidth, unitHeight, 0, 0, spriteFrames, texture);
            SetSpriteAnimation("up", 1, 4, unitWidth, unitHeight, 0, unitHeight, spriteFrames, texture);
            SetSpriteAnimation("left", 1, 4, unitWidth, unitHeight, 0, unitHeight * 2, spriteFrames, texture);
            SetSpriteAnimation("right", 1, 4, unitWidth, unitHeight, 0, unitHeight * 3, spriteFrames, texture);
            SetSpriteAnimation("down_right", 1, 4, unitWidth, unitHeight, unitWidth, 0, spriteFrames, texture);
            SetSpriteAnimation("down_left", 1, 4, unitWidth, unitHeight, unitWidth, unitHeight, spriteFrames, texture);
            SetSpriteAnimation("up_right", 1, 4, unitWidth, unitHeight, unitWidth, unitHeight * 2, spriteFrames,
                texture);
            SetSpriteAnimation("up_left", 1, 4, unitWidth, unitHeight, unitWidth, unitHeight * 3, spriteFrames,
                texture);
        }

        animSprite.SpriteFrames = spriteFrames;
        animSprite.Play("idle");
        AddChild(animSprite);
    }

    public override void _Ready()
    {
        var collisionShape = new CollisionShape2D();
        var serializer = new XmlSerializer(typeof(Node));
        using var reader = new StreamReader("resources/node/unit/aruku.xml");
        var nodeUnit = (Node)serializer.Deserialize(reader);
        if (nodeUnit == null) throw new ArgumentNullException(nameof(nodeUnit));
        //var nodeUnit = Node.ReadFrom("resources/node/unit/aruku.xml");
        var newSize = new Vector2(nodeUnit.Mesh.Width, nodeUnit.Mesh.Width);
        var shape = new RectangleShape2D();

        shape.Size = newSize;
        collisionShape.Shape = shape;
        // var texture = new CompressedTexture2D();
        var texture = (Texture2D)GD.Load("resources" + nodeUnit.Texture);
        Console.Out.Write("resources" + nodeUnit.Texture);
        //texture.LoadPath = "resources" + nodeUnit.Texture;
        //Console.Out.Write(texture.LoadPath);
        LoadTexture(texture, nodeUnit.Mesh.Width, nodeUnit.Mesh.Height);
        AddChild(collisionShape);
    }

    public override void _PhysicsProcess(double delta)
    {
        return;
        var velocity = Velocity;

        // Add the gravity.
        if (!IsOnFloor())
            velocity.Y += gravity * (float)delta;

        // Handle Jump.
        if (Input.IsActionJustPressed("ui_accept") && IsOnFloor())
            velocity.Y = JumpVelocity;

        // Get the input direction and handle the movement/deceleration.
        // As good practice, you should replace UI actions with custom gameplay actions.
        var direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
        if (direction != Vector2.Zero)
            velocity.X = direction.X * Speed;
        else
            velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);

        Velocity = velocity;
        MoveAndSlide();
    }
}