using System.Collections.Generic;
using System.Xml.Serialization;

namespace F0.Config;

// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(LandmarkData));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (LandmarkData)serializer.Deserialize(reader);
// }

[XmlRoot(ElementName = "landmark")]
public class Landmark
{
    [XmlElement(ElementName = "node")] public string Node { get; set; }

    [XmlElement(ElementName = "radius")] public int Radius { get; set; }

    [XmlElement(ElementName = "passability")]
    public float Passability { get; set; }

    [XmlElement(ElementName = "radarvalue")]
    public string Radarvalue { get; set; }

    [XmlElement(ElementName = "sublayer")] public int Sublayer { get; set; }

    [XmlElement(ElementName = "grid_align")]
    public object GridAlign { get; set; }

    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }

    [XmlText] public string Text { get; set; }

    [XmlElement(ElementName = "water")] public object Water { get; set; }

    [XmlElement(ElementName = "no_shore")] public object NoShore { get; set; }

    [XmlElement(ElementName = "colored")] public object Colored { get; set; }

    [XmlElement(ElementName = "lava")] public object Lava { get; set; }
}

[XmlRoot(ElementName = "landmark.data")]
public class LandmarkData
{
    [XmlElement(ElementName = "landmark")] public List<Landmark> Landmark { get; set; }
}