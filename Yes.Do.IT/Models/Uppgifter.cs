using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yes.Do.IT.Models
{
	public class Uppgifter
	{
		[Key]
		public int UppgiftId { get; set; }
		public string UppgiftNamn { get; set; }
		public string Text { get; set; }
		public MinLista MinLista { get; set; }
		public int MinListaId { get; set; }


	}
}
