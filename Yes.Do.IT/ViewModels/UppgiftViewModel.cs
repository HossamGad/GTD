using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yes.Do.IT.Models;

namespace Yes.Do.IT.ViewModels
{
	public class UppgiftViewModel
	{
		public Uppgifter UppgiftDetail { get; set; }

		public Uppgifter UppgiftId { get; set; }
		public List<NyUppgift> NyUppgift { get; set; }


		public string GradeAverage { get; set; }
	}
}
