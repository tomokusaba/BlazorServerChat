using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerChat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Chat> Chats { get; set; }

    }
    public class Chat
    {
        [Key]
        public DateTime Time { get; set; } = DateTime.Now;
        public string Name { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;

    }

}