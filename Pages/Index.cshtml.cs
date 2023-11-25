using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MWO3._1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string ApplicationVersion { get; set; }

        public void OnGet()
        {
            ApplicationVersion = System.IO.File.ReadAllText("version");
        }
    }
}