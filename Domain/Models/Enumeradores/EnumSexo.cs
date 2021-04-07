using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Enumeradores
{
    public enum EnumSexo
    {
        [Display(Name = "Masculino")]
        Masculino = 0,
        [Display(Name = "Feminino")]
        Feminino
    }
}
