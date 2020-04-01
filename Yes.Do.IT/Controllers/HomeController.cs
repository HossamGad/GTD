using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Yes.Do.IT.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yes.Do.IT.Controllers
{
    [Authorize]
    public class HomeController : Controller
	{
        private readonly IUppgifterRepository _uppgifterRepository;

        public HomeController(IUppgifterRepository uppgifterRepository)
        {
            _uppgifterRepository = uppgifterRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

