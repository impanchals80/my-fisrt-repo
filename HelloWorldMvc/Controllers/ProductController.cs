using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMvc.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
