using System.Collections.Generic;
using System.Xml.Serialization;

namespace F0.Schemas;

// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Level));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Level)serializer.Deserialize(reader);
// }

[XmlRoot(ElementName = "if_switch")]
public class IfSwitch
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
}

[XmlRoot(ElementName = "set_switch")]
public class SetSwitch
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }

    [XmlAttribute(AttributeName = "state")]
    public bool State { get; set; }
}

[XmlRoot(ElementName = "popup")]
public class Popup
{
    [XmlAttribute(AttributeName = "portrait")]
    public string Portrait { get; set; }

    [XmlAttribute(AttributeName = "text")] public string Text { get; set; }
}

[XmlRoot(ElementName = "set_objective")]
public class SetObjective
{
    [XmlAttribute(AttributeName = "text")] public string Text { get; set; }
}

[XmlRoot(ElementName = "wait")]
public class Wait
{
    [XmlAttribute(AttributeName = "time")] public int Time { get; set; }
}

[XmlRoot(ElementName = "cutscene")]
public class Cutscene
{
    [XmlAttribute(AttributeName = "portrait")]
    public string Portrait { get; set; }

    [XmlAttribute(AttributeName = "text")] public string Text { get; set; }
}

[XmlRoot(ElementName = "trigger")]
public class Trigger
{
    [XmlElement(ElementName = "if_has_artifact")]
    public List<IfHasArtifact> IfHasArtifact { get; set; }

    [XmlElement(ElementName = "if_not_event")]
    public IfNotEvent IfNotEvent { get; set; }

    [XmlElement(ElementName = "popup")] public Popup Popup { get; set; }

    [XmlElement(ElementName = "give")] public Give Give { get; set; }

    [XmlElement(ElementName = "wait")] public Wait Wait { get; set; }

    [XmlElement(ElementName = "set_event")]
    public SetEvent SetEvent { get; set; }

    [XmlAttribute(AttributeName = "i")] public string I { get; set; }

    [XmlElement(ElementName = "create")] public Create Create { get; set; }

    [XmlElement(ElementName = "focus")] public Focus Focus { get; set; }

    [XmlElement(ElementName = "set_switch")]
    public SetSwitch SetSwitch { get; set; }

    [XmlText] public string Text { get; set; }

    [XmlElement(ElementName = "if_switch")]
    public IfSwitch IfSwitch { get; set; }

    [XmlElement(ElementName = "if_group_empty")]
    public IfGroupEmpty IfGroupEmpty { get; set; }

    [XmlElement(ElementName = "inc_quest_counter")]
    public object IncQuestCounter { get; set; }
}

[XmlRoot(ElementName = "at_area")]
public class AtArea
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
}

[XmlRoot(ElementName = "activate_massive")]
public class ActivateMassive
{
    [XmlElement(ElementName = "structure")]
    public string Structure { get; set; }

    [XmlElement(ElementName = "at_area")] public AtArea AtArea { get; set; }
}

[XmlRoot(ElementName = "reveal_map")]
public class RevealMap
{
    [XmlElement(ElementName = "at_area")] public AtArea AtArea { get; set; }

    [XmlElement(ElementName = "radius")] public int Radius { get; set; }
}

[XmlRoot(ElementName = "join_group")]
public class JoinGroup
{
    [XmlElement(ElementName = "item")] public string Item { get; set; }

    [XmlElement(ElementName = "group")] public string Group { get; set; }

    [XmlElement(ElementName = "at_area")] public string AtArea { get; set; }
}

[XmlRoot(ElementName = "if_not_switch")]
public class IfNotSwitch
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
}

[XmlRoot(ElementName = "unlock_building")]
public class UnlockBuilding
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
}

[XmlRoot(ElementName = "tutorial")]
public class Tutorial
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
}

[XmlRoot(ElementName = "if_has")]
public class IfHas
{
    [XmlElement(ElementName = "at_area")] public AtArea AtArea { get; set; }

    [XmlElement(ElementName = "unit")] public object Unit { get; set; }
}

[XmlRoot(ElementName = "complete_tutorial")]
public class CompleteTutorial
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
}

[XmlRoot(ElementName = "scroll_view")]
public class ScrollView
{
    [XmlElement(ElementName = "at_area")] public AtArea AtArea { get; set; }
}

[XmlRoot(ElementName = "if_group_empty")]
public class IfGroupEmpty
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
}

[XmlRoot(ElementName = "complete_level")]
public class CompleteLevel
{
    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
}

[XmlRoot(ElementName = "unlock_level")]
public class UnlockLevel
{
    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
}

[XmlRoot(ElementName = "if_has_artifact")]
public class IfHasArtifact
{
    [XmlElement(ElementName = "item")] public Item Item { get; set; }
}

[XmlRoot(ElementName = "give_silent")]
public class GiveSilent
{
    [XmlElement(ElementName = "item")] public string Item { get; set; }
}

[XmlRoot(ElementName = "switch")]
public class Switch
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
}

[XmlRoot(ElementName = "add_item_use")]
public class AddItemUse
{
    [XmlElement(ElementName = "item")] public string Item { get; set; }

    [XmlElement(ElementName = "at_area")] public AtArea AtArea { get; set; }

    [XmlElement(ElementName = "switch")] public Switch Switch { get; set; }
}

[XmlRoot(ElementName = "create")]
public class Create
{
    [XmlElement(ElementName = "structure")]
    public string Structure { get; set; }

    [XmlElement(ElementName = "at_area")] public AtArea AtArea { get; set; }

    [XmlElement(ElementName = "item")] public string Item { get; set; }

    [XmlElement(ElementName = "group")] public string Group { get; set; }

    [XmlElement(ElementName = "unit")] public string Unit { get; set; }

    [XmlElement(ElementName = "side")] public string Side { get; set; }
}

[XmlRoot(ElementName = "destroy")]
public class Destroy
{
    [XmlElement(ElementName = "structure")]
    public string Structure { get; set; }

    [XmlElement(ElementName = "at_area")] public AtArea AtArea { get; set; }
}

[XmlRoot(ElementName = "item")]
public class Item
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }

    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

    [XmlAttribute(AttributeName = "x")] public int X { get; set; }

    [XmlAttribute(AttributeName = "y")] public int Y { get; set; }

    [XmlAttribute(AttributeName = "sub_id")]
    public int SubId { get; set; }
}

[XmlRoot(ElementName = "if_not_event")]
public class IfNotEvent
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
}

[XmlRoot(ElementName = "set_event")]
public class SetEvent
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
}

[XmlRoot(ElementName = "give")]
public class Give
{
    [XmlElement(ElementName = "item")] public Item Item { get; set; }
}

[XmlRoot(ElementName = "focus")]
public class Focus
{
    [XmlElement(ElementName = "group")] public string Group { get; set; }

    [XmlElement(ElementName = "at_area")] public AtArea AtArea { get; set; }
}

[XmlRoot(ElementName = "triggers")]
public class Triggers
{
    [XmlElement(ElementName = "trigger")] public List<Trigger> Trigger { get; set; }
}

[XmlRoot(ElementName = "options")]
public class Options
{
    [XmlElement(ElementName = "id")] public int Id { get; set; }
}

[XmlRoot(ElementName = "size")]
public class Size
{
    [XmlAttribute(AttributeName = "x")] public int X { get; set; }

    [XmlAttribute(AttributeName = "y")] public int Y { get; set; }
}

[XmlRoot(ElementName = "player_base")]
public class PlayerBase
{
    [XmlAttribute(AttributeName = "x")] public int X { get; set; }

    [XmlAttribute(AttributeName = "y")] public int Y { get; set; }
}

[XmlRoot(ElementName = "landmark")]
public class Landmark
{
    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

    [XmlAttribute(AttributeName = "x")] public int X { get; set; }

    [XmlAttribute(AttributeName = "y")] public int Y { get; set; }
}

[XmlRoot(ElementName = "structure")]
public class Structure
{
    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

    [XmlAttribute(AttributeName = "x")] public int X { get; set; }

    [XmlAttribute(AttributeName = "y")] public int Y { get; set; }

    [XmlAttribute(AttributeName = "hint")] public string Hint { get; set; }
}

[XmlRoot(ElementName = "unit")]
public class Unit
{
    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

    [XmlAttribute(AttributeName = "x")] public int X { get; set; }

    [XmlAttribute(AttributeName = "y")] public int Y { get; set; }

    [XmlAttribute(AttributeName = "owner")]
    public string Owner { get; set; }
}

[XmlRoot(ElementName = "area")]
public class Area
{
    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }

    [XmlAttribute(AttributeName = "owner")]
    public string Owner { get; set; }

    [XmlAttribute(AttributeName = "radius")]
    public int Radius { get; set; }

    [XmlAttribute(AttributeName = "x")] public int X { get; set; }

    [XmlAttribute(AttributeName = "y")] public int Y { get; set; }
}

[XmlRoot(ElementName = "magic")]
public class Magic
{
    [XmlAttribute(AttributeName = "owner")]
    public string Owner { get; set; }

    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

    [XmlAttribute(AttributeName = "x")] public int X { get; set; }

    [XmlAttribute(AttributeName = "y")] public int Y { get; set; }
}

[XmlRoot(ElementName = "ambient")]
public class Ambient
{
    [XmlAttribute(AttributeName = "owner")]
    public string Owner { get; set; }

    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

    [XmlAttribute(AttributeName = "x")] public int X { get; set; }

    [XmlAttribute(AttributeName = "y")] public int Y { get; set; }
}

[XmlRoot(ElementName = "waypoint")]
public class Waypoint
{
    [XmlAttribute(AttributeName = "x")] public int X { get; set; }

    [XmlAttribute(AttributeName = "y")] public int Y { get; set; }
}

[XmlRoot(ElementName = "level")]
public class Level
{
    [XmlElement(ElementName = "triggers")] public Triggers Triggers { get; set; }

    [XmlElement(ElementName = "options")] public Options Options { get; set; }

    [XmlElement(ElementName = "size")] public Size Size { get; set; }

    [XmlElement(ElementName = "player_base")]
    public PlayerBase PlayerBase { get; set; }

    [XmlElement(ElementName = "terrain")] public string Terrain { get; set; }

    [XmlElement(ElementName = "landmark")] public List<Landmark> Landmark { get; set; }

    [XmlElement(ElementName = "structure")]
    public List<Structure> Structure { get; set; }

    [XmlElement(ElementName = "unit")] public List<Unit> Unit { get; set; }

    [XmlElement(ElementName = "item")] public List<Item> Item { get; set; }

    [XmlElement(ElementName = "area")] public List<Area> Area { get; set; }

    [XmlElement(ElementName = "magic")] public List<Magic> Magic { get; set; }

    [XmlElement(ElementName = "ambient")] public List<Ambient> Ambient { get; set; }

    [XmlElement(ElementName = "waypoint")] public List<Waypoint> Waypoint { get; set; }
}