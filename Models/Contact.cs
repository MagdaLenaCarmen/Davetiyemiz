using System.ComponentModel.DataAnnotations;

namespace davetiyemiz.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Adınızı giriniz")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Soyadınızı giriniz")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email zorunlu")]
        [EmailAddress(ErrorMessage = "Geçerli bir email giriniz")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mesajınızı yazınız")]
        public string Message { get; set; } = string.Empty;
    }
}
