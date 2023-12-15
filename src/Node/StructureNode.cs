using System.IO;
using System.Xml.Serialization;
using F0.Config;
using Godot;

namespace F0.Node;

public partial class StructureNode : Node2D
{
    private readonly Schemas.Node _node;
    private readonly int _x;
    private readonly int _y;
    private readonly string tpe;

    public StructureNode(Configuration conf, string tpe, int x, int y)
    {
        var correctTpe = conf.Structures[tpe].Node;
        var serializer = new XmlSerializer(typeof(Schemas.Node));
        using var reader = new StreamReader("resources/" + correctTpe);
        _node = (Schemas.Node)serializer.Deserialize(reader);
        _x = x;
        _y = y;
        AssociatedStructure = conf.Structures[tpe];
        this.tpe = tpe;
    }

    public Structure AssociatedStructure { get; set; }

    public override void _Ready()
    {
        //Console.WriteLine(_node.Texture);
        //Console.WriteLine(_node.ToString());
        //Console.WriteLine(tpe);
        if (_node.HasNode() && _node.Texture == null) return;
        var texture = (Texture2D)GD.Load("resources" + _node.Texture.Replace("data/", "/"));
        var sprite = new Sprite2D();
        sprite.Texture = texture;
        AddChild(sprite);
        Position = new Vector2(_x, _y);
        base._Ready();
    }
}