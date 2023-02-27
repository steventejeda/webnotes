using Microsoft.EntityFrameworkCore;
using WebNotes.Models.Entities;

namespace WebNotes.Data
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions options) : base(options) 
        {
        } 

        public DbSet<Note> Notes { get; set; }

    }
}
