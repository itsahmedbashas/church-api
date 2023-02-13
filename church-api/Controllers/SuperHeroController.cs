using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using church_api.Models;
using church_database;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace church_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;
        public SuperHeroController(DataContext context)
        {
                _context = context;
        }

        private static List<SuperHero> SuperHeroes = new List<SuperHero>()
            {
                new SuperHero
                {
                    Id = 123,
                    FirstName = "Ahmed",
                    LastName = "Shaik",
                    Place = "Kankipadu"
                },
                new SuperHero
                {
                    Id = 456,
                    FirstName = "Basha",
                    LastName = "Shaik",
                    Place = "Gosala"
                },
            };

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
                return Ok(null);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            SuperHeroes.Add(hero);
            return Ok(SuperHeroes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetById(int id)
        {
            var sprModel = SuperHeroes.Where(s => s.Id.Equals(id)).ToList();

            if (sprModel.Count > 0)
            {
                return Ok(sprModel);
            }
            else
            {
                return Ok("No Super Model Found");
            }
        }

        [HttpPut]
        public async Task<ActionResult<SuperHero>> UpdateSrModel(SuperHero hero)
        {
            var sprHero = SuperHeroes.Find(s => s.Id.Equals(hero.Id));

            if (sprHero != null)
            {
                sprHero.FirstName = hero.FirstName;
                sprHero.LastName = hero.LastName;
                sprHero.Place = hero.Place;
            }
            else
            {
                return Ok("No Super Model Found");
            }

            return Ok(sprHero);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHeros(int id) {

            var sprHero = SuperHeroes.Find(s => s.Id.Equals(id));

            if (sprHero != null)
            {
                SuperHeroes.Remove(sprHero);
            }
            else
            {
                return Ok("No Super Model Found");
            }

            return Ok(SuperHeroes);
        }
    }
}

