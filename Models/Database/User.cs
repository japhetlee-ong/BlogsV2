using System;
using System.Collections.Generic;

namespace BlogsV2.Models.Database;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Usertype { get; set; }

    public DateTime DateCreated { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Role UsertypeNavigation { get; set; } = null!;
}
