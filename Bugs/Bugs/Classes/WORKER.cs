using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bugs
{
    class WORKER
    {
        [Key]
        public string Login { get; set; }
        public bool Role { get; set; }
        public int Password { get; set; }
    }
}