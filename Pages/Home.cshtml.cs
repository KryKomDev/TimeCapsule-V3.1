using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeCapsuleV3._1.Models;
using TimeCapsuleV3._1.Services;

namespace TimeCapsuleV3._1.Pages;

public class HomeModel : PageModel {
    
    private readonly ILogger<HomeModel> _logger;
    public JsonFileLegacyService legacyService;
    public IEnumerable<Legacy>? legacies { get; private set; }

    public HomeModel(ILogger<HomeModel> logger, JsonFileLegacyService legacyService) {
        _logger = logger;
        this.legacyService = legacyService;
        
        Console.WriteLine("Constructed!!!");
    }

    public void OnGet() {
        legacies = legacyService.GetLegacies();
        Console.WriteLine("Get!!!");
    }
}