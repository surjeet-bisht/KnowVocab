using Microsoft.AspNetCore.Mvc;

namespace LearnWithFun.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class LoginController : ControllerBase
	{
		[HttpGet]
		public string Index()
		{
			return "";
		}
	}
}
