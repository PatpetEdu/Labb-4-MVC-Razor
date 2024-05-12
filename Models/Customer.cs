using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb_4___MVC___Razor.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Får inte vara längre än 50 tecken")]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Får inte vara längre än 50 tecken")]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Får inte vara längre än 50 tecken")]
        public string Email { get; set; }
        [StringLength(50, ErrorMessage = "Får inte vara längre än 50 tecken")]
        [Required]
        public string Address { get; set; }
        public ICollection<Loan>? Loans { get; set; }


    }
}
