using System.Text.Json;

namespace TimeCapsuleV3._1.Models;

public class Legacy {
    
    public int id { get; set; }
    public string person { get; set; }
    public string message { get; set; }

    
    public override string ToString() => JsonSerializer.Serialize(this);
}