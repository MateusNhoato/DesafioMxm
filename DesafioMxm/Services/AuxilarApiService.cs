using DesafioMxm.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DesafioMxm.Services
{
    public class AuxilarApiService
    {
        private readonly string _url =
            "https://h9146.mxmwebmanager.com.br/api/InterfacedoSubGrupoPatrimonial/ConsultaSubGrupoPatrimonial";
        public async Task<RespostaApiModel?> FazerPedido(UserModel user, DataModel? data)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, _url);
                requestMessage.Content = JsonContent.Create(new { AutheticationToken = user, Data = data });

                var response = await httpClient.SendAsync(requestMessage);
                var jsonString = await response.Content.ReadAsStringAsync();

                var respostaModel = JsonSerializer.Deserialize<RespostaApiModel>(jsonString);

                return respostaModel;
            }
            catch (Exception e)
            {
                throw new AuxiliarApiServiceException(e.Message);
               
            }
        }
    }
}
