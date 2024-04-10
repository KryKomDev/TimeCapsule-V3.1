using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeCapsuleV3._1.Models;
using TimeCapsuleV3._1.Services;

namespace TimeCapsuleV3._1.Pages;

public class HomeModel : PageModel {
    
    private readonly ILogger<HomeModel> _logger;
    public JsonFileLegacyService legacyService;
    public IEnumerable<Legacy>? legacies { get; private set; }

    public JsonFilePictureService pictureService;
    public IEnumerable<Picture>? pictures { get; private set; }

    public HomeModel(ILogger<HomeModel> logger, JsonFileLegacyService legacyService, JsonFilePictureService pictureService) {
        _logger = logger;
        this.legacyService = legacyService;
        this.pictureService = pictureService;
    }

    public void OnGet() {
        legacies = legacyService.GetLegacies();
        pictures = pictureService.GetPictures();
    }
}