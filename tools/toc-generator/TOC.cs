using System.Text.Json.Serialization;

[JsonDerivedType(typeof(TOCDirectory))]
[JsonDerivedType(typeof(TOCFile))]
public class TOC{
    [JsonPropertyOrder(1)]
    public int id{get;set;}
    [JsonPropertyOrder(3)]
    public string url{get;set;}="";
}

public class TOCDirectory : TOC{
    [JsonPropertyOrder(2)]
    public string listName{get;set;}="";
    [JsonPropertyOrder(4)]
    public List<TOC> innerList { get; set; } = new List<TOC>();
}

public class TOCFile : TOC{
    [JsonPropertyOrder(2)]
    public string title{get;set;}="";
}

