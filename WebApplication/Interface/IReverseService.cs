using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Interface {
	public interface IReverseService {
		public ActionResult<ReverseGetResponce> Do(string data);
	}
		
}
