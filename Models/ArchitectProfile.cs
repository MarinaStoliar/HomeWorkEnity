using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEntity.Models
{
    public class ArchitectProfile
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public int ArchitectRecordId { get; set; }
        public Architect ArchitectRecord { get; set; }
    }
}
