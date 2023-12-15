using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace F0.Config;

public class Configuration
{
    public Configuration()
    {
        var serializer = new XmlSerializer(typeof(LandmarkData));
        using var reader = new StreamReader("resources/cfg/landmark.xml");

        LandmarkData = (LandmarkData)serializer.Deserialize(reader);
        Landmarks = LandmarkData.Landmark.ToDictionary(x => x.Name, x => x);

        var serializer2 = new XmlSerializer(typeof(StructureData));
        using var reader2 = new StreamReader("resources/cfg/structure.xml");

        StructureData = (StructureData)serializer2.Deserialize(reader2);
        Structures = StructureData.Structure.ToDictionary(x => x.Name, x => x);

        var serializer3 = new XmlSerializer(typeof(TerrainData));
        using var reader3 = new StreamReader("resources/cfg/terrain.xml");

        TerrainData = (TerrainData)serializer3.Deserialize(reader3);
        Terrains = TerrainData.Terrain.ToDictionary(x => x.Name, x => x);
    }

    public TerrainData TerrainData { get; set; }
    public Dictionary<string, Terrain> Terrains { get; set; }

    public LandmarkData LandmarkData { get; set; }
    public Dictionary<string, Landmark> Landmarks { get; set; }
    public StructureData StructureData { get; set; }
    public Dictionary<string, Structure> Structures { get; set; }
}