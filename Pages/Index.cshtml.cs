using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeCapsuleV3._1.Models;
using TimeCapsuleV3._1.Services;

namespace TimeCapsuleV3._1.Pages;

public class IndexModel : PageModel {
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger) {
        _logger = logger;
    }

    public void OnGet() {
    }
}