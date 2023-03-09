using DesafioMxm.Model;
using DesafioMxm.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace DesafioMxm.Pages
{
    public class ConsultaModel : PageModel
    {
        private readonly AuxilarApiService _api;
        public RespostaApiModel? Resposta { get; set; }


        public ConsultaModel(AuxilarApiService api)
        {
            _api = api;
        }

        public async Task<IActionResult?> OnGet()
        {
            if (TempData["User"] is null)
                return RedirectToPage("./Erro", new { MensagemDeErro = "Usuário Inválido" });
            
            try
            {
                var user = JsonSerializer.Deserialize<UserModel>(TempData["User"].ToString());
                var data = JsonSerializer.Deserialize<DataModel>(TempData["Data"].ToString());

                Resposta = await _api.FazerPedido(user, data);
            }
            catch (Exception e)
            {
                return RedirectToPage("./Erro", new { MensagemDeErro = e.Message });
            }

            return Page();
        }

    }
}
