using DataAccess.Models.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class TelefoneViewModel : BaseViewModel
    {
        public TipoTelefone Tipo { get; set; }
        public int DDD { get; set; }
        public int Numero { get; set; }
    }
}
