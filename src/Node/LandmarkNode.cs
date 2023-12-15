using System.IO;
using System.Xml.Serialization;
using F0.Config;
using Godot;

namespace F0.Node;

public partial class LandmarkNode : Node2D
{
    private readonly Schemas.Node _node;
    private readonly int _x;
    private readonly int _y;


    public LandmarkNode(Configuration config, string tpe, int x, int y)
    {
        var correctTpe = config.Landmarks[tpe].Node;
        var serializer = new XmlSerializer(typeof(Schemas.Node));
        using var reader = new StreamReader("resources/" + correctTpe);
        _node = (Schemas.Node)serializer.Deserialize(reader);
        _x = x;
        _y = y;
        AssociatedLandmark = config.Landmarks[tpe];
    }

    public Landmark AssociatedLandmark { get; set; }

    public override void _Ready()
    {
        var texture = (Texture2D)GD.Load("resources" + _node.Texture);
        var sprite = new Sprite2D();
        sprite.Texture = texture;
        AddChild(sprite);
        Position = new Vector2(_x, _y);
        base._Ready();
    }
}