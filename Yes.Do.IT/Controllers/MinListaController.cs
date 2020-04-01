using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yes.Do.IT.Models;

namespace Yes.Do.IT.Controllers
{


    [Authorize]
    public class MinListaController : Controller
    {
        private readonly IMinListaRepository _minsListaRepository;

        public MinListaController(IMinListaRepository minsListaRepository)
        {
            _minsListaRepository = minsListaRepository;
        }
        public ViewResult List()
        {
            return View();
        }
        public IActionResult NyLista()
        {

            return View();
        }

        [HttpPost]

        public IActionResult NyLista(MinLista nyLista)
        {

            if (nyLista.MinListaNamn == "")
            {
                ModelState.AddModelError("", "Skriv namn till listan");
            }

            if (ModelState.IsValid)
            {

                _minsListaRepository.CreateNewListAndAddToDatabase(nyLista);
                return RedirectToAction("Complete");
            }

            return View(nyLista);
        }

        public IActionResult Complete()
        {
            ViewBag.Complete = "Tack";
            return View();
        }
    }
}
