using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb_4___MVC___Razor.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Får inte vara längre än 50 tecken")]
        public string Title { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Får inte vara längre än 50 tecken")]
        public string Description { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Får inte vara längre än 50 tecken")]
        public string Author { get; set; }
        [Required]
        public DateTime PublishedYear { get; set;}
        public ICollection<Loan>? Loans { get; set; }

    }
}
