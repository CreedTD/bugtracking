using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Bugs.Classes
{
    class UserContext :DbContext
    {
        public UserContext()
        :base ("DbConnection")
    {}
        public DbSet<SOLUTION> Solutions { get; set; }
        public DbSet<ERROR> Errors { get; set; }
        public DbSet<KEYWORD> Keywords { get; set; }
        public DbSet<WORKER> Workers { get; set; }
    }
}
