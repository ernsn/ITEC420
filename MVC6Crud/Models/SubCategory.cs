using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC6Crud.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }

        public string SubCategoryName { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
