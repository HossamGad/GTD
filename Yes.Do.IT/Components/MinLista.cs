using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yes.Do.IT.Models;

namespace Yes.Do.IT.Components
{
    [Authorize]
    public class MinLista : ViewComponent
    {
        private readonly IMinListaRepository _minListaRepository;
        public MinLista (IMinListaRepository minListaRepository)
        {
            _minListaRepository = minListaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var Result = _minListaRepository.AllaListor.OrderBy(c => c.MinListaNamn);
            return View(Result);
        }
    }
	
	}

