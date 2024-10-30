using Microsoft.AspNetCore.Mvc;
using WebapiPokemons.Entidades;

namespace WebapiPokemons.Controllers
{
    [ApiController]
    [Route("api/pokemons")]
    public class PokemonsController: ControllerBase
    {

        [HttpGet]
        public ActionResult<List<Pokemon>> Get()
        {
            return new List<Pokemon>()
            {
                new Pokemon() { Id = 1, Nombre = "Felipe"},
                new Pokemon() { Id = 2, Nombre = "Joan"}
            };
        }

    }
}
