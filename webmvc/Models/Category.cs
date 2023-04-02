using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace webmvc.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [DisplayName("Your Name")]
        public string Name { get; set; }

    }

}
