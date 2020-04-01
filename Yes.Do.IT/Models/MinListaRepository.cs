using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yes.Do.IT.Models
{
	public class MinListaRepository : IMinListaRepository
	{
        private readonly AppDbContext _appDbContext;

        public MinListaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<MinLista> AllaListor => _appDbContext.MinLista;
        public MinLista GetListById(int MinListaId)
        {
            return _appDbContext.MinLista.FirstOrDefault(p => p.MinListaId == MinListaId);
        }

        // lägg till ny category
        public void CreateNewListAndAddToDatabase(MinLista nyLista)
        {
            _appDbContext.MinLista.Add(nyLista);
            _appDbContext.SaveChanges();

        }
        public MinLista GetListByName(string currentList)
        {
            return _appDbContext.MinLista.FirstOrDefault(p => p.MinListaNamn == currentList);
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
