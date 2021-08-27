using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEntity.Models
{
    public class Architect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }

        public ArchitectProfile Profile { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }

        public List<Engineer> Engineers { get; set; } = new List<Engineer>();
    }
}
