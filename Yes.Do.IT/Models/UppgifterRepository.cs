using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yes.Do.IT.Models
{
	public class UppgifterRepository : IUppgifterRepository
	{
		private readonly AppDbContext _appDbContext;

		public UppgifterRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public IEnumerable<Uppgifter> AllaUppgifter
		{
			get
			{
				return _appDbContext.Uppgifter.Include(c => c.MinLista);
			}
		}

				
		public Uppgifter GetUppgiftById(int UppgiftId)
		{
			return _appDbContext.Uppgifter.FirstOrDefault(p => p.UppgiftId == UppgiftId);
		}

		
		public void CreateNewUppgiftAndAddToDatabase(Uppgifter nyUppgift)
		{
			_appDbContext.Uppgifter.Add(nyUppgift);
			_appDbContext.SaveChanges();

		}

	
		public void UpdateUppgiftAndAddToDatabase(Uppgifter nyUppgift)
		{
			_appDbContext.Uppgifter.Update(nyUppgift);
			_appDbContext.SaveChanges();

		}
	}
}
