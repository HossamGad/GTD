using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Yes.Do.IT.Models;


namespace Yes.Do.IT.Controllers
{
    [Authorize]
    public class NyUppgiftController : Controller
	{
        private readonly INyUppgiftRepository _NyUppgiftRepository;
        private readonly IUppgifterRepository _UppgifterRepository;
        private readonly IMinListaRepository _MinListaRepository;

        public NyUppgiftController(INyUppgiftRepository NyUppgiftRepository, IUppgifterRepository UppgifterRepository, IMinListaRepository MinListaRepository)
        {
            _NyUppgiftRepository = NyUppgiftRepository;
            _UppgifterRepository = UppgifterRepository;
            _MinListaRepository = MinListaRepository;
        }
    }
}

