using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogNet.Data
{
    public class Comment
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [MaxLength(450)]
        public string AuthorId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public bool IsPublished { get; set; }

        [ForeignKey("AuthorId")]
        public ApplicationUser Author { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public Comment Parent { get; set; }
        public ICollection<Comment> Children { get; set; }
    }
}
