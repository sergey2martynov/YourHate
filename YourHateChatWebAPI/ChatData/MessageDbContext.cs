using ChatApplication.Interfaces;
using ChatData.EntityTypeConfiguration;
using ChatData.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatData
{
    public class MessageDbContext : DbContext, IMessageDbContext
    {
        public DbSet<Message> Message { get ; set ; }
        public MessageDbContext(DbContextOptions<MessageDbContext> options) : base(options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
