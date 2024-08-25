using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SpicyRazorTemp.Models
{
    public class Category
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string Name { get; set; }

        [DisplayName("Description")]
        // [MaxLength(200)]

        public string Description { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Need to be within 1-100")]
        public int DisplayOrder { get; set; }
    }
}
