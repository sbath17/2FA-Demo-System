using System.ComponentModel.DataAnnotations;

namespace TwoFactorDemo.Models
{
    public class TwoFactorViewModel
    {
        [Required]
        [Display(Name = "Authentication Code")]
        public string Code { get; set; }
    }
}