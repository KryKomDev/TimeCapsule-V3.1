using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeCapsuleV3._1.Models;
using TimeCapsuleV3._1.Services;

namespace TimeCapsuleV3._1.Pages;

public class RozcestnikModel : PageModel {
    private readonly ILogger<RozcestnikModel> _logger;

    public RozcestnikModel(ILogger<RozcestnikModel> logger) {
        _logger = logger;
    }

    public void OnGet() {
    }
}