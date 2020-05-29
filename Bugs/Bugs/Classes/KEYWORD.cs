using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bugs.Classes
{
    public class KEYWORD
    {
        [Key]
        public int Id { get; set; }
        public int ErrorId { get; set; }
        [ForeignKey("ErrorId")]
        public ERROR Error { get; set; }
        public string Name { get; set; }
    }
}
