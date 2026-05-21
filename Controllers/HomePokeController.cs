using Microsoft.AspNetCore.Mvc;
using MvcPokemon.Services;
using System.Text.Encodings.Web;

namespace MvcPokemon.Controllers;

public class HomePokeController : Controller
{
    public async Task<IActionResult> Index()
    {
        var service = new Services.PokemonApiResponse();
        
        var pokemon = await service.GetPokemon();
        
        return View(pokemon);

    }

}
