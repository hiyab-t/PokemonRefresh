using System.ComponentModel.DataAnnotations;

namespace MvcPokemon.Models;

public class PokeSpecies
{
    public string? Name { get; set; }
}

public class PokeSprites
{
    public string? Front_default { get; set; }
}

public class PokeCries
{
    public string? Latest { get; set; }
}
public class PokemonResponse
{
    public PokeSpecies? Species { get; set; }
    public PokeSprites? Sprites { get; set; }
    public PokeCries? Cries { get; set; }

}