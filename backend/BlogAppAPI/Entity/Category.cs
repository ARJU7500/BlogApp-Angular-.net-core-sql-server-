using System.ComponentModel.DataAnnotations.Schema;

namespace BlogAppAPI.Entity
{
    [Table("BLOG_CATEGORY")]
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategotyName { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatrdOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatrdOn { get; set; }
    }
}
