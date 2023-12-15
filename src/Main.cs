using System.IO;
using System.Xml.Serialization;
using F0.Config;
using F0.Node;
using F0.Schemas;
using Godot;

namespace F0;

public partial class Main : Node2D
{
    public override void _Ready()
    {
        var conf = new Configuration();
        var serializer = new XmlSerializer(typeof(Level));
        using var reader = new StreamReader("resources/level/original/" + "level01a" + ".xml");
        var level = (Level)serializer.Deserialize(reader);
        level.Landmark.ConvertAll(a => new LandmarkNode(conf, a.Type, a.X, a.Y)).ForEach(a => AddChild(a));
        level.Structure.ConvertAll(a => new StructureNode(conf, a.Type, a.X, a.Y)).ForEach(a => AddChild(a));
        var entity = new Entity();
        AddChild(entity);
        entity.Position = new Vector2(level.PlayerBase.X, level.PlayerBase.Y);
        var camera = new LevelCamera(level.PlayerBase.X, level.PlayerBase.Y);
        AddChild(camera);
        base._Ready();
    }
}