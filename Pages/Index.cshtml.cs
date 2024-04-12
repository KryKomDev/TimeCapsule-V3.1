using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TimeCapsuleV3._1.Pages;

public class IndexModel : PageModel {
    private readonly ILogger<RozcestnikModel> _logger;

    public IndexModel(ILogger<RozcestnikModel> logger) {
        
        _logger = logger;
    }

    public void OnGet() {
    }

}