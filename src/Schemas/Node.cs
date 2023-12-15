using System.IO;
using System.Xml.Serialization;

namespace F0.Schemas;

[XmlRoot(ElementName = "mesh")]
public class Mesh
{
    [XmlElement(ElementName = "width")] public int Width { get; set; }

    [XmlElement(ElementName = "height")] public int Height { get; set; }

    [XmlElement(ElementName = "anchory")] public int Anchory { get; set; }
}

[XmlRoot(ElementName = "animation")]
public class Animation
{
    [XmlElement(ElementName = "enabled")] public int Enabled { get; set; }

    [XmlElement(ElementName = "framebegin")]
    public int Framebegin { get; set; }

    [XmlElement(ElementName = "frameend")] public int Frameend { get; set; }

    [XmlElement(ElementName = "fps")] public int Fps { get; set; }

    [XmlElement(ElementName = "isplaying")]
    public int Isplaying { get; set; }
}

[XmlRoot(ElementName = "node")]
public class Node
{
    [XmlElement(ElementName = "node")] public Node NodeInternal { get; set; }
    [XmlElement(ElementName = "mesh")] public Mesh Mesh { get; set; }

    [XmlElement(ElementName = "texture")] public string Texture { get; set; }

    [XmlElement(ElementName = "animation")]
    public Animation Animation { get; set; }

    public static Node ReadFrom(string path)
    {
        Node node = null;
        var serializer = new XmlSerializer(typeof(Node));
        using var reader = new StreamReader(path);
        node = (Node)serializer.Deserialize(reader);

        return node;
    }

    public bool HasNode()
    {
        return NodeInternal != null;
    }
}