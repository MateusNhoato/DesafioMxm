using DesafioMxm.Model;
using DesafioMxm.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace DesafioMxm.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public UserModel? UserModel { get; set; } = new();
        [BindProperty]
        public DataModel? DataModel { get; set; }

        public void OnGet()
        {
         
        }

        public ActionResult OnPost()
        {
            TempData["User"] = JsonSerializer.Serialize(UserModel);
            TempData["Data"] = JsonSerializer.Serialize(DataModel);

            return RedirectToPage("./Consulta");
        }

    }
}