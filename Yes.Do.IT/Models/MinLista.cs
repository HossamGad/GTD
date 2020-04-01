using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yes.Do.IT.Models
{
	
	public class MinLista
	{
		public int MinListaId { get; set; }
		public string MinListaNamn { get; set; }
		public string Beskrivning { get; set; }
		public List<Uppgifter> Uppgifter { get; set; }

	}
}
