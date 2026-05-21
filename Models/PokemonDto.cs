using System.ComponentModel.DataAnnotations;

namespace MvcPokemon.Models;

public class PokemonDto
{
    public string? Name { get; set; }
    public string? Latest { get; set; }
    public string? Front_default { get; set; }

}