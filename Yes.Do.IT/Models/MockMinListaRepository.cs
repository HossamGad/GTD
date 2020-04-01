using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yes.Do.IT.Models
{
	public class MockMinListaRepository : IMinListaRepository
	{
       
            public IEnumerable<MinLista> AllaListor =>
                new List<MinLista>
                {
                new MinLista{MinListaId=1, MinListaNamn="Idag", Beskrivning="Uppgifter ska görs idag"},
                new MinLista{MinListaId=2, MinListaNamn="Imorgon", Beskrivning="Uppgifter ska görs imorgon"},
                new MinLista{MinListaId=3, MinListaNamn="Nästa Vecka", Beskrivning="Uppgifter ska görs nästa vecka"}
                };

            public MinLista GetListById(int MinListaId)
            {
                return AllaListor.FirstOrDefault(p => p.MinListaId == MinListaId);
            }

            public void CreateNewListAndAddToDatabase(MinLista nyLista)
            {

            }
            public MinLista GetListByName(string currentList)
            {
                return AllaListor.FirstOrDefault(p => p.MinListaNamn == currentList);
            }

        public MinLista GetListtById(int ListId)
        {
            throw new NotImplementedException();
        }

        public void UpdateListAndAddToDatabase(MinLista nyList)
        {
            throw new NotImplementedException();
        }
    }
    
}
