using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;
using SuperHeroAPI.Services.SuperHeroServices;

namespace SuperHeroAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SuperHeroController : ControllerBase
	{
		private readonly ISuperHeroService _superHeroService;

		public SuperHeroController(ISuperHeroService superHeroService) 
		{
			_superHeroService = superHeroService;
		}
		

		[HttpGet]
		public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
		{
			
			return Ok(superHeroes);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
		{
			var hero = superHeroes.Find(x => x.Id == id);
			if(hero == null)
				return NotFound("This hero does not exist. <--message");
			return Ok(hero);
		}//24:50

		[HttpPost]
		public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
		{
			superHeroes.Add(hero);
			return Ok(hero);
		}//32:25

		[HttpPut("{id}")]
		public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero requ_hero)
		{
			var hero = _superHeroService.UpdateHero(id, requ_hero);
			if (hero == null)
				return NotFound("This hero does not exist. <--Update message");

			return Ok(hero);
		}////50.DAKİKA

		[HttpDelete("{id}")]
		public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
		{
			var result = _superHeroService.DeleteHero(id);
			if (result == null)
				return NotFound("silmek için id bulunamadı");

			return Ok(result);
		}

	}
}
