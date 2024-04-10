using System.Text.Json;
using TimeCapsuleV3._1.Models;

namespace TimeCapsuleV3._1.Services;

public class JsonFileLegacyService (IWebHostEnvironment webHostEnvironment) {
    
    public IWebHostEnvironment WebHostEnvironment { get; } = webHostEnvironment;

    private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "legacies.json");
    
    public IEnumerable<Legacy>? GetLegacies() {
        using var jsonFileReader = File.OpenText(JsonFileName);
        
        return JsonSerializer.Deserialize<Legacy[]> ( 
            jsonFileReader.ReadToEnd(), 
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );
    }
}