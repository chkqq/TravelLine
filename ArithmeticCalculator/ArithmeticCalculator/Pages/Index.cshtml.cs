using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ArithmeticCalculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string FirstNumber { get; set; } = string.Empty;

        [BindProperty]
        public string SecondNumber { get; set; } = string.Empty;

        [BindProperty]
        public string Operation { get; set; } = string.Empty;

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/Result", new { FirstNumber, SecondNumber, Operation});
        }
    }
}