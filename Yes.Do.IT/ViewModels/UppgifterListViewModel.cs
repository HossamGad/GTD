using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yes.Do.IT.Models;

namespace Yes.Do.IT.ViewModels
{
	public class UppgifterListViewModel
	{
		public IEnumerable<Uppgifter> Uppgifter { get; set; }
		public string CurrentList { get; set; }
		public int MinListaId { get; set; }
	}
}
