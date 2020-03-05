using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bugs
{
    class SOLUTION
    {
        public string Description { get; set; }
        public int Raiting { get; set; }
        public int ErrorId { get; set; }
        [ForeignKey("ErrorId")]
        public ERROR Error { get; set; }
        public string WorkerLogin { get; set; }
        [ForeignKey("WorkerLogin")]
        public WORKER Worker { get; set; }
    }
}
