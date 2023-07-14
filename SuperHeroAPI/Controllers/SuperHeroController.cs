using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SuperHeroController : ControllerBase
	{
		private static List<SuperHero> superHeroes = new List<SuperHero>
			{
				new SuperHero{Id=1,
					Name="Spider-Man",
					FirstName="Peter",
					LastName="Parker",
					Place="New York"
				},
				new SuperHero{Id=2,
					Name="Iron Man",
					FirstName="Tony",
					LastName="Stark",
					Place="New York"
				}
			};

		[HttpGet]
		public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
		{
			
			return Ok(superHeroes);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<List<SuperHero>>> GetSingleHero(int id)
		{
			var hero = superHeroes.Find(x => x.Id == id);
			return Ok(hero);
		}//24:50
	}
}
