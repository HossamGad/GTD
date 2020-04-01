using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yes.Do.IT.Models
{
	public interface IMinListaRepository
	{
		IEnumerable<MinLista> AllaListor { get; }
		MinLista GetListtById(int ListId);

		void CreateNewListAndAddToDatabase(MinLista nyList);
		void UpdateListAndAddToDatabase(MinLista nyList);
		MinLista GetListByName(string currentList);
	}
}
