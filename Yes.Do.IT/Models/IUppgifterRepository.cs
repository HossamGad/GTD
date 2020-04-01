using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yes.Do.IT.Models
{
	public interface IUppgifterRepository
	{
		IEnumerable<Uppgifter> AllaUppgifter { get; }

		Uppgifter GetUppgiftById(int UppgiftId);

		void CreateNewUppgiftAndAddToDatabase(Uppgifter nyUppgift);
		void UpdateUppgiftAndAddToDatabase(Uppgifter nyUppgift);
	}
}
