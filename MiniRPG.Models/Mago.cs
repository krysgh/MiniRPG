using MiniRPG.Models.Abstracts;
using MiniRPG.Models.Interfaces;

namespace MiniRPG.Models;

public class Mago : Personagem, IHabilidadeEspecial
{
    public Decimal Mana { get; private set; } = new Random().Next(1, 20);

    public Mago(string Nome) : base(Nome)
    {
    }

    public override Decimal Atacar()
    {
        return base.Atacar() * (1/this.Mana);
    }

    public Decimal Especial()
    {
        return base.Atacar() * this.Mana;
    }

    public override string? ToString()
    {
        return base.ToString() + $"Mana: {this.Mana}";
    }
}
