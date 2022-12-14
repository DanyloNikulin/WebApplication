using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApplication.Interface;
using WebApplication.Models;
using WebApplication.Services;

namespace WebApplication.Controllers {
	[Route("reverse")]
	[ApiController]
	[Produces("application/json")]
	public class ReverseController : ControllerBase {
		private readonly IReverseService _reverseService;

		public ReverseController(IReverseService reverseService) {
			_reverseService = reverseService;
		}
		[HttpGet()]
		public ActionResult<ReverseGetResponce> Get(string data) {
			return _reverseService.Do(data);
		}
	}
}
