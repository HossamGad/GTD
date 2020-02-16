using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yes.Do.IT.Models;

namespace Yes.Do.IT.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MinListaController : ControllerBase
	{
		private readonly IMinListaRepository _repository;
		public MinListaController(IMinListaRepository repository)
		{
			_repository = repository;
			
		}
		[HttpGet]
		
		 public async Task<ActionResult<MinLista[]>> Get()
		{
			
		}
	}
}
