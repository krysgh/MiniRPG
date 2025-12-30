using MiniRPG.Models.Abstracts;

namespace MiniRPG.Models;

public class Guerreiro : Personagem
{
    public Guerreiro(string Nome) : base(Nome)
    {
    }

    public override Decimal Atacar()
    {
        return base.Atacar() * (1/base.ForcaBruta);
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
