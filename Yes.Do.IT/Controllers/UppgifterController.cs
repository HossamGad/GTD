using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yes.Do.IT.Models;
using Yes.Do.IT.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yes.Do.IT.Controllers
{
	public class UppgifterController : Controller
	{
        private readonly IUppgifterRepository _uppgifterRepository;
        private readonly IMinListaRepository _minListaRepository;

        public UppgifterController(IUppgifterRepository uppgifterRepository, IMinListaRepository minListaRepository)
        {
            _uppgifterRepository = uppgifterRepository;
            _minListaRepository = minListaRepository;

        }


        public ViewResult List(string MinLista)
        {
            IEnumerable<Uppgifter> Uppgifter;
            string CurrentList;

            if (string.IsNullOrEmpty(MinLista))
            {
                Uppgifter = _uppgifterRepository.AllaUppgifter.OrderBy(p => p.UppgiftId);
                CurrentList = " ";
            }
            else
            {
                Uppgifter = _uppgifterRepository.AllaUppgifter.Where(p => p.MinLista.MinListaNamn == MinLista)
                    .OrderBy(p => p.UppgiftId);
                CurrentList = _minListaRepository.AllaListor.FirstOrDefault(c => c.MinListaNamn == MinLista)?.MinListaNamn;
            }

            return View(new UppgifterListViewModel
            {
                Uppgifter = Uppgifter,
                CurrentList = CurrentList
            });
        }


        public IActionResult Details(int id)
        {
            var Uppgifter = _uppgifterRepository.GetUppgiftById(id);
            if (Uppgifter == null)
                return NotFound();

            return View(Uppgifter);
        }

        public IActionResult NyUppgift1(string currentList)
        {
           Uppgifter nyUppgift = new Uppgifter();
            var MinLista = _minListaRepository.GetListByName(currentList);
            nyUppgift.MinListaId = MinLista.MinListaId;

            return View(nyUppgift);
        }

        [HttpPost]
        public IActionResult NyProdukt1(Uppgifter nyUppgift)
        {
            if (nyUppgift.UppgiftNamn == "")
            {
                ModelState.AddModelError("", "Uppgift namn:");
            }

            if (ModelState.IsValid)
            {

                _uppgifterRepository.CreateNewUppgiftAndAddToDatabase(nyUppgift);
                return RedirectToAction("Klart");
            }

            return View(nyUppgift);
        }

        public IActionResult Complete()
        {
            ViewBag.Complete = "Tack";
            return View();
        }

        public IActionResult UpdateUppgift1(int UppgiftId)
        {
            var Uppgift = _uppgifterRepository.GetUppgiftById(UppgiftId);

            return View(Uppgift);
        }

        [HttpPost]



        public IActionResult UpdateProdukt1(int UppgiftId, Uppgifter nyUppgift)
        {
            nyUppgift.UppgiftId = UppgiftId;

            if (nyUppgift.UppgiftNamn == "")
            {
                ModelState.AddModelError("", "Uppgift namn");
            }

            if (ModelState.IsValid)
            {

                _uppgifterRepository.UpdateUppgiftAndAddToDatabase(nyUppgift);
                return RedirectToAction("UpdateComplete");
            }

            return View(nyUppgift);
        }

        public IActionResult UpdateComplete()
        {
            ViewBag.UpdateComplete = "Uppdateringen är klar";
            return View();
        }
    }
}
