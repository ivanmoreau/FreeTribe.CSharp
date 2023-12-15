using System.Collections.Generic;
using System.Xml.Serialization;

namespace F0.Config;

// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(StructureData));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (StructureData)serializer.Deserialize(reader);
// }

[XmlRoot(ElementName = "structure")]
public class Structure
{
    [XmlElement(ElementName = "node")] public string Node { get; set; }

    [XmlElement(ElementName = "radius")] public int Radius { get; set; }

    [XmlElement(ElementName = "radarvalue")]
    public string Radarvalue { get; set; }

    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }

    [XmlText] public string Text { get; set; }

    [XmlElement(ElementName = "node2")] public string Node2 { get; set; }

    [XmlElement(ElementName = "radar_radius")]
    public int RadarRadius { get; set; }

    [XmlElement(ElementName = "radarvalue2")]
    public string Radarvalue2 { get; set; }

    [XmlElement(ElementName = "button")] public object Button { get; set; }

    [XmlElement(ElementName = "self_activate")]
    public object SelfActivate { get; set; }

    [XmlElement(ElementName = "on_activate")]
    public string OnActivate { get; set; }

    [XmlElement(ElementName = "on_destroy")]
    public string OnDestroy { get; set; }

    [XmlElement(ElementName = "on_destroy_land")]
    public string OnDestroyLand { get; set; }

    [XmlElement(ElementName = "sublayer")] public int Sublayer { get; set; }

    [XmlElement(ElementName = "floating")] public int Floating { get; set; }

    [XmlElement(ElementName = "floating_rate")]
    public int FloatingRate { get; set; }

    [XmlElement(ElementName = "radar_node")]
    public string RadarNode { get; set; }

    [XmlElement(ElementName = "no_optimize")]
    public object NoOptimize { get; set; }

    [XmlElement(ElementName = "grid_align")]
    public object GridAlign { get; set; }
}

[XmlRoot(ElementName = "structure.data")]
public class StructureData
{
    [XmlElement(ElementName = "structure")]
    public List<Structure> Structure { get; set; }
}