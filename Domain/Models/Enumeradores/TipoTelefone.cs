using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models.Enumeradores
{
    public enum TipoTelefone
    {
        [Display(Name = "Residencial")]
        Residencial = 0,
        [Display(Name = "Celular")]
        Celular,
        [Display(Name = "Comercial")]
        Comercial
    }
}