using DesafioMxm.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace DesafioMxm.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public UserModel UserModel { get; set; } = new();
        [BindProperty]
        public DataModel? DataModel { get; set; }

        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {
            if (UserModel == null)
                return RedirectToPage("./Error", new { MensagemDeErro = "Usuário Inválido" });

            TempData["User"] = JsonSerializer.Serialize(UserModel);
            TempData["Data"] = JsonSerializer.Serialize(DataModel);

            return RedirectToPage("./Resultado");
        }

    }
}