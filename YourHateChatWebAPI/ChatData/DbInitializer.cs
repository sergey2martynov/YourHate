using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatData
{
    public class DbInitializer
    {
        public static void Initialize(MessageDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
