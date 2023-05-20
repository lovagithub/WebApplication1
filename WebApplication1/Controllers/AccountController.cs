using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
	public class AccountController : Controller

	{
		public IActionResult Register()
		{  

			return View();
		}
		[HttpPost]

		public IActionResult Register(RegisterViewModel registerViewModel)
		{
			

			return View(registerViewModel);
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
