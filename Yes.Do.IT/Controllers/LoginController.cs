﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yes.Do.IT.Controllers
{
	public class LoginController : Controller
	{
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Contact()
		{
			ViewBag.Title = "Kontakt oss";
			return View();
		}
		
	}
}
