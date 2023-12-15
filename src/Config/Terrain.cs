using System.Collections.Generic;
using System.Xml.Serialization;

namespace F0.Config;

// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(TerrainData));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (TerrainData)serializer.Deserialize(reader);
// }

[XmlRoot(ElementName = "terrain")]
public class Terrain
{
    [XmlElement(ElementName = "node")] public string Node { get; set; }

    [XmlElement(ElementName = "radarvalue")]
    public string Radarvalue { get; set; }

    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }

    [XmlText] public string Text { get; set; }

    [XmlElement(ElementName = "impassable")]
    public object Impassable { get; set; }
}

[XmlRoot(ElementName = "terrain.data")]
public class TerrainData
{
    [XmlElement(ElementName = "terrain")] public List<Terrain> Terrain { get; set; }
}