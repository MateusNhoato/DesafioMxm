namespace DesafioMxm.Model
{
    public class RespostaModel
    {

        public bool Success { get; set; }
        public List<Datum> Data { get; set; }
        public List<Mensagem?> Messages { get; set; }
        
        public class ClassificacoesEspecifica
        {
            public string CodigoClassificacaoEspecifica { get; set; }
            public string CodigoDoGrupo { get; set; }
            public string CodigoDoSubGrupo { get; set; }
        }

        public class Datum
        {
            public string Codigo { get; set; }
            public string Descricao { get; set; }
            public string CodigoGrupoPatrimonial { get; set; }
            public List<ClassificacoesEspecifica> ClassificacoesEspecificas { get; set; }
        }
        
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
}
