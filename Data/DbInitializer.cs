using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolCommunityContext context)
        {
            context.Database.EnsureCreated();
        }

    }
}
