using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yes.Do.IT.Models
{
	public class MinListaRepository
	{
		public IEnumerable<MinLista> Minlista => new List<MinLista> 
		{
			 new MinLista { Name = "uppgift 1", Beskrivning = "Kolla på arbetsuppgifter"},
			 new MinLista { Name = "uppgift 2", Beskrivning = "Planera din dag"},
			 new MinLista { Name = "uppgift 3", Beskrivning = "Klara arbetsuppgifter"},

		};

	}
	public interface IMinListaRepository
	{ 
		void Add<T>(T entity) where T : class;
		void Delete<T>(T entity) where T : class;
		Task<bool> SaveChangesAsync();
		
	};


	public class MinLista
	{
		public string Name { get; set; }
		public string Beskrivning { get; set; }
		public ICollection<MinLista> Uppgifter { get; set; }

	}
}
