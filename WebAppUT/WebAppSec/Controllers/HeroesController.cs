using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppSec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private static Hero[] Heroes = new []
        {
            new Hero(1, "Freezing"),
            new Hero(2, "Bracing"),
            new Hero(3, "Chilly"),
            new Hero(4, "Cool"),
            new Hero(5, "Mild"),

        };

        [HttpGet]
        public IEnumerable<Hero> GetAll()
        {
            return Heroes;
        }

        [HttpGet("{id}")]
        public Hero Get(int id)
        {
            return Heroes.SingleOrDefault(h => h.id == id);
        }

    }

    public class Hero
    {
        public int id { get; set; }
        public string name { get; set; }

        public Hero(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}