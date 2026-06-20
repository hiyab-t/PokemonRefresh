using System.Text.Json;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Routing;
using MvcPokemon.Models;

namespace MvcPokemon.Services;

class PokemonApiResponse
{
    static readonly HttpClient client = new HttpClient();
    public async Task<PokemonDto> GetPokemon()
    {
        var ranNum = new Random();
        var id = ranNum.Next(1, 900);

        
        var poke = await client.GetFromJsonAsync<PokemonResponse>($"https://pokeapi.co/api/v2/pokemon/{id}/");
            
            if (poke == null)
                return new PokemonDto();
            
        return new PokemonDto
        {
            Name = poke?.Species?.Name,
            Latest = poke?.Cries?.Latest,
            Front_default = poke?.Sprites?.Front_default

        };
        
    }
}