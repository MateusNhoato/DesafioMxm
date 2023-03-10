namespace DesafioMxm.Model.DTO
{
    public class Datum
    {

        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string CodigoGrupoPatrimonial { get; set; }
        public List<ClassificacoesEspecifica> ClassificacoesEspecificas { get; set; }

    }
}
