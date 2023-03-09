using DesafioMxm.Model;
using DesafioMxm.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace DesafioMxm.Pages
{
    public class ConsultaModel : PageModel
    {

        public RespostaModel? Resposta { get; set; }

        public async Task<IActionResult?> OnGet()
        {
            if (TempData["User"] is null)
            {
                TempData["Erro"] = "Usuário Inválido";
                return RedirectToPage("./Erro");
            }

            var user = JsonSerializer.Deserialize<UserModel>(TempData["User"].ToString());
            var data = JsonSerializer.Deserialize<DataModel>(TempData["Data"].ToString());

            
            
            var jsonString = await AuxilarApi.FazerPedido(user, data);

            if (jsonString is null)
            {
                TempData["Erro"] = "Algo deu errado na consulta.";
                return RedirectToPage("./Erro");
            }

            Resposta = JsonSerializer.Deserialize<RespostaModel>(jsonString);

            return null;
        }

    }
}
