using Microsoft.EntityFrameworkCore;
using NotesAPI.Models.Entities;

namespace NotesAPI.Data
{
    //DbContext will help to communicate with the database
    public class NotesDBContext : DbContext
    {
        public NotesDBContext(DbContextOptions options) : base(options)
        {
        }

        //This will act as Table in database
       public DbSet<Note> Notes  { get; set; }
    }
}
