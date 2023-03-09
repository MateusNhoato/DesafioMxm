using DesafioMxm.Model;


namespace DesafioMxm.Services
{
    public static class AuxilarApi
    {
        private static string _url = 
            "https://mxmsau01.mxmwebmanager.com.br/api/InterfacedoSubGrupoPatrimonial/ConsultaSubGrupoPatrimonial";

        public static async Task<string?> FazerPedido(UserModel user, DataModel? data)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, _url);
                requestMessage.Content = JsonContent.Create(new { AutheticationToken = user, Data = data });

                var response = await httpClient.SendAsync(requestMessage);
                var jsonString = await response.Content.ReadAsStringAsync();

                return jsonString;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
