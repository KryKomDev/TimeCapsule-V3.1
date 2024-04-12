using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TimeCapsuleV3._1.Pages;

public class IndexModel : PageModel {
    private readonly ILogger<RozcestnikModel> _logger;
    private static readonly string password = "Landsdorfův Pahorek";

    public IndexModel(ILogger<RozcestnikModel> logger) {
        _logger = logger;
    }

    public void OnGet() {
    }

    public static string getPassword() {
        return password;
    }

    public static bool check(string s) {
        if (s == getPassword()) {
            return true;
        }

        return false;
    }
}