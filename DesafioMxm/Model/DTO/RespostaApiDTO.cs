namespace DesafioMxm.Model.DTO
{
    public class RespostaApiDTO
    {
        public bool Success { get; set; }
        public List<Datum> Data { get; set; }
        public List<Mensagem?> Messages { get; set; }
    }
}
