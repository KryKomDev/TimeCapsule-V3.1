using System.Text.Json;
using TimeCapsuleV3._1.Models;

namespace TimeCapsuleV3._1.Services;

public class JsonFilePictureService (IWebHostEnvironment webHostEnvironment) {
    
    public IWebHostEnvironment WebHostEnvironment { get; } = webHostEnvironment;

    private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "pictures.json");
    
    public IEnumerable<Picture>? GetPictures() {
        using var jsonFileReader = File.OpenText(JsonFileName);
        
        return JsonSerializer.Deserialize<Picture[]> ( 
            jsonFileReader.ReadToEnd(), 
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );
    }
}