using System;
using System.Collections.Generic;

namespace BlogsV2.Models.Database;

public partial class Comment
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int BlogId { get; set; }

    public string Comment1 { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Blog Blog { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
