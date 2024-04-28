using System;
using System.Collections.Generic;

namespace BlogsV2.Models.Database;

public partial class Blog
{
    public int Id { get; set; }

    public string BlogName { get; set; } = null!;

    public string BlogSlug { get; set; } = null!;

    public string BlogImage { get; set; } = null!;

    public int AuthorId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public bool IsPublished { get; set; }

    public bool IsDeleted { get; set; }

    public virtual User Author { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
