namespace DataAccess.Models
{
    public class Empresa : BaseModel
    {
        public string Nome { get; set; }
        public string Site { get; set; }
        public int QtdFuncionarios { get; set; }
    }
}