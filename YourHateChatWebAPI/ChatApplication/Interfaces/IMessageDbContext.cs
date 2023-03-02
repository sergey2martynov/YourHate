using ChatData.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatApplication.Interfaces
{
    public interface IMessageDbContext
    {
        public DbSet<Message> Message {get; set;}
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
