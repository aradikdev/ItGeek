using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ItGeek.DAL.Entities;

namespace ItGeek.Web.Data
{
    public class ItGeekWebContext : DbContext
    {
        public ItGeekWebContext (DbContextOptions<ItGeekWebContext> options)
            : base(options)
        {
        }

        public DbSet<ItGeek.DAL.Entities.Category> Category { get; set; } = default!;

        public DbSet<ItGeek.DAL.Entities.Author> Author { get; set; } = default!;

        public DbSet<ItGeek.DAL.Entities.AuthorsSocial> AuthorsSocial { get; set; } = default!;

        public DbSet<ItGeek.DAL.Entities.Comment> Comment { get; set; } = default!;

        public DbSet<ItGeek.DAL.Entities.Menu> Menu { get; set; } = default!;

        public DbSet<ItGeek.DAL.Entities.MenuItem> MenuItem { get; set; } = default!;

        public DbSet<ItGeek.DAL.Entities.Post> Post { get; set; } = default!;

        public DbSet<ItGeek.DAL.Entities.Role> Role { get; set; } = default!;

        public DbSet<ItGeek.DAL.Entities.Tag> Tag { get; set; } = default!;

        public DbSet<ItGeek.DAL.Entities.User> User { get; set; } = default!;
    }
}
