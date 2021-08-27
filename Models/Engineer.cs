using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEntity.Models
{
    public class Engineer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Architect> Architects { get; set; } = new List<Architect>();
    }
}
