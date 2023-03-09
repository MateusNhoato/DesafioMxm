using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DesafioMxm.Pages
{
    public class ErroModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public string MensagemDeErro { get; set; }
        public void OnGet()
        {
            
        }
    }
}
