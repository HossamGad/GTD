using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yes.Do.IT.Models
{
	public class NyUppgift
	{
        [Key]
        [Required]
        public int MinListaId { get; set; }
        public int UppgiftId { get; set; }
        public string Namn { get; set; }
        public string Text { get; set; }
       
    }
}
