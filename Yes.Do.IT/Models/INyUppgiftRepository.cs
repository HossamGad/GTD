using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yes.Do.IT.Models
{
	public interface INyUppgiftRepository
	{
        IEnumerable<NyUppgift> AllaNyaUppgifter { get; }

        IEnumerable<NyUppgift> GetAllNewUppgift();
        IEnumerable<NyUppgift> GetNewUppgiftByUppgiftId(int MinListaId);
        IEnumerable<NyUppgift> GetNewUppgiftById(int UppgiftId);

        IEnumerable<NyUppgift> GetNewUppgiftByUppgiftName(string Namn);
        IEnumerable<NyUppgift> GetNewUppgiftByUppgiftText(string Text);
       

        void CreateNewUppgiftAndAddToDatabase(NyUppgift nyUppgift);

    }
}
