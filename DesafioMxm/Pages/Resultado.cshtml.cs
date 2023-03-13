using DesafioMxm.Model;
using DesafioMxm.Model.DTO;
using DesafioMxm.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace DesafioMxm.Pages
{
    public class ResultadoModel : PageModel
    {
        private readonly AuxilarApiService _api;
        public RespostaApiDTO? Resposta { get; set; }


        public ResultadoModel(AuxilarApiService api)
        {
            _api = api;
        }

        public async Task<IActionResult?> OnGet()
        {
            try
            {
                if (TempData["User"] is null)
                    throw new Exception("Usuário Inválido");

                var user = GetUserModel();
                var data = GetDataModel();

                Resposta = await _api.ConsultarPatrimonioSubGrupo(user, data);

                if (Resposta is null)
                    throw new Exception("Houve um problema com a resposta");
            }
            catch (Exception e)
            {
                return RedirectToPage("./Erro", new { MensagemDeErro = e.Message });
            }

            return Page();
        }

        private UserModel GetUserModel()
        {
            return JsonSerializer.Deserialize<UserModel>(TempData["User"].ToString());
        }

        private DataModel? GetDataModel() 
        {
            return JsonSerializer.Deserialize<DataModel>(TempData["Data"].ToString());
        }
    }
}
