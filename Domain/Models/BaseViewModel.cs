using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class BaseViewModel
    {
        [Required]
        public string Id { get; set; }
    }
}