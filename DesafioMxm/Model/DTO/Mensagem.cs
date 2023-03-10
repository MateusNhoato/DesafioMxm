namespace DesafioMxm.Model.DTO
{
    public class Mensagem
    {
        public string Message { get; set; }
        public string? Detail { get; set; }
        public int Type { get; set; }
        public string TypeMessage { get; set; }
        public int ErrorLevel { get; set; }
        public string? Code { get; set; }
    }
}
