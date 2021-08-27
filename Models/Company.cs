using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEntity.Models
{
    [Table("RenamedCompany")]
    public class Company
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Column("BuildingBuild", TypeName = "nvarchar(40)")]
        [MaxLength(40)]
        public int Build { get; set; }

        public List<Architect> Architects { get; set; } = new List<Architect>();
    }
}
