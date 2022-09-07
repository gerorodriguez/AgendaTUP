using AgendaApi.Entities;
using System.ComponentModel.DataAnnotations;

namespace AgendaApi.Models
{
    public class CreateContactDto
    {
        [Required]
        public string Name { get; set; }
        public int? CelularNumber { get; set; }
        public int? TelephoneNumber { get; set; }
        public string Description = String.Empty;
        public User? User;
    }
}
