using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services.SuperHeroServices
{
	public class SuperHeroService : ISuperHeroService
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
					Name="Hulk",
					FirstName="Robert Bruce",
					LastName="Banner",
					Place="New York"
				},
				new SuperHero{Id=3,
					Name="Iron Man",
					FirstName="Tony",
					LastName="Stark",
					Place="New York"
				}
			};


		public List<SuperHero> GetAllHeroes()
		{
			throw new NotImplementedException();
		}

		public SuperHero GetSingleHero(int id)
		{
			throw new NotImplementedException();
		}

		public List<SuperHero> UpdateHero(int id, SuperHero requ_hero)
		{
			var hero = superHeroes.Find(x => x.Id == id);
			if (hero is null)
				return null;
			else
			{
				hero.FirstName = requ_hero.FirstName;
				hero.LastName = requ_hero.LastName;
				hero.Name = requ_hero.Name;
				hero.Place = requ_hero.Place;
			}


			return superHeroes;
		}
		public List<SuperHero> AddHero(SuperHero hero)
		{
			throw new NotImplementedException();
		}
		public List<SuperHero> DeleteHero(int id)
		{
			var hero = superHeroes.Find(x => x.Id == id);
			if (hero is null)
				return null;

			superHeroes.Remove(hero);
			return superHeroes;
		}

		
	}
}
