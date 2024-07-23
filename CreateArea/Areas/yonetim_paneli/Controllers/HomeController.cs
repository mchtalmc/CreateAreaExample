using Microsoft.AspNetCore.Mvc;

namespace CreateArea.Areas.yonetim_paneli.Controllers
{
	[Area("yonetim_paneli")]   // => Area attribute kullanarak hangi controller'in hangi area'da oldugunu bildirmem gerekmektedir.
	//Bulundugu area kulasoru icerisinde iss eo ismi vermek kavul edilen bir davranistir.
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
