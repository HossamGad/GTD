using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yes.Do.IT.Models
{
	public class MockUppgifterRepository : IUppgifterRepository
	{
        private readonly IMinListaRepository _minListaRepository = new MockMinListaRepository();

        public IEnumerable<Uppgifter> AllaUppgifter =>
            new List<Uppgifter>
            {
                new Uppgifter {UppgiftId = 1, UppgiftNamn="Idag", Text="Uppgifter som ska görs idag", MinLista = _minListaRepository.AllaListor.ToList()[0]},
                new Uppgifter {UppgiftId = 2, UppgiftNamn="Imorgon", Text="Uppgifter som ska görs Imorgon",  MinLista = _minListaRepository.AllaListor.ToList()[1]},
                new Uppgifter {UppgiftId = 3, UppgiftNamn="Nästa Vecka", Text="Uppgifter som ska görs nästa vecka", MinLista = _minListaRepository.AllaListor.ToList()[0]},
            };

       

        public Uppgifter GetUppgiftById(int UppgiftId)
        {
            return AllaUppgifter.FirstOrDefault(p => p.UppgiftId == UppgiftId);
        }

        public void CreateNewUppgiftAndAddToDatabase(Uppgifter nyUppgift)
        {

        }

        public void UpdateUppgiftAndAddToDatabase(Uppgifter nyUppgift)
        {

        }
    }
}
