using System.Text.Json;

namespace TimeCapsuleV3._1.Models;

public class Picture {
    
    public string name { get; set; }
    public string description { get; set; }
    
    public override string ToString() => JsonSerializer.Serialize(this);
}