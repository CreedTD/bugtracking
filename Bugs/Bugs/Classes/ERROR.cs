using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bugs.Classes
{
    class ERROR
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
       
        public string Variety { get; set; }
        public DateTime Dataivremya { get; set; }
        public virtual ICollection<SOLUTION> Solutions { get; set; }
        public virtual ICollection<KEYWORD> Keyword { get; set; }
        public string WorkerLogin { get; set; }
        [ForeignKey("WorkerLogin")]
        public WORKER Worker { get; set; }
    }
}
