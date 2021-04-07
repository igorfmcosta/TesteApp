using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class EmpresaViewModel : BaseViewModel
    {
        [Required(ErrorMessage ="Informe o nome da empresa.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o site da empresa.")]
        [Url(ErrorMessage ="Site informado incorreto.")]
        public string Site { get; set; }
        [Required(ErrorMessage = "Informe a quantidade de funcionários da empresa.")]
        public int QtdFuncionarios { get; set; }
    }
}
