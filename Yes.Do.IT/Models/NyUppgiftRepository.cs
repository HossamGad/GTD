using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yes.Do.IT.Models
{
	public class NyUppgiftRepository : INyUppgiftRepository
    {
        private readonly AppDbContext database;


        public NyUppgiftRepository(AppDbContext appDbContext)
        {
            database = appDbContext;
        }

        // hämta alla kommentarer
        public IEnumerable<NyUppgift> AllaNyaUppgifter
        {
            get { return database.DbNyUppgift.Include(a => a.Namn); }

        }

        
        public IEnumerable<NyUppgift> GetAllNewUppgifter()
        {
            return database.DbNyUppgift;

        }
        public IEnumerable<NyUppgift> GetNewUppgiftByUppgiftName(string Namn)
        {
            return database.DbNyUppgift.Where(c => c.Namn == Namn);
        }
        public IEnumerable<NyUppgift> GetNewUppgiftById(int UppgiftId)
        {
            return database.DbNyUppgift.Where(c => c.UppgiftId == UppgiftId);
        }
        public IEnumerable<NyUppgift> GetNewUppgiftByUppgiftText(string Text)
        {
            return database.DbNyUppgift.Where(c => c.Text == Text);
        }

       
        public void CreateNewUppgiftAndAddToDatabase(NyUppgift nyUppgift)
        {
            database.DbNyUppgift.Add(nyUppgift);
            database.SaveChanges();

        }


        public IEnumerable<NyUppgift> GetNewUppgifterByUppgiftId(int MinListaId)
        {
            return database.DbNyUppgift.Where(p => p.MinListaId == MinListaId);
        }

        public IEnumerable<NyUppgift> GetAllNewUppgift()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NyUppgift> GetNewUppgiftByUppgiftId(int MinListaId)
        {
            throw new NotImplementedException();
        }
    }
}
