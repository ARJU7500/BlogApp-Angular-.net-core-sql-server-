using System.ComponentModel.DataAnnotations.Schema;

namespace BlogAppAPI.Entity
{
    [Table("BLOG_MASTER")]
    public class Blog
    {
        public int BlogId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public string? image { get; set; }
        public bool isFetured { get; set; }
        public int IategryId { get; set; }
        public Category Category { get; set; }
        public DateTime CreatrdOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime UpdatrdOn { get; set; }
    }
}
