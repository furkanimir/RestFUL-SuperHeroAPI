using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services.SuperHeroServices
{
	public interface ISuperHeroService
	{
		List<SuperHero> GetAllHeroes();
		SuperHero GetSingleHero(int id);
		List<SuperHero> UpdateHero(int id, SuperHero requ_hero);
		List<SuperHero> AddHero(SuperHero hero);
		List<SuperHero> DeleteHero(int id);

	}
}
