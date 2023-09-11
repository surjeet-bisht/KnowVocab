using LearnWithFun.Data.IRepository;
using LearnWithFun.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LearnWithFun.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

		private readonly ICategoryRepository _ICategoryRepository;

		public WeatherForecastController(ICategoryRepository ICategoryRepository)
		{
			_ICategoryRepository = ICategoryRepository;
		}

		[HttpGet]
		public IEnumerable<WeatherForecast> Get()
		{
			var test = _ICategoryRepository.GetCategories();
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}
	}
}