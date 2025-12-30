namespace MiniRPG.Models.Abstracts;

public abstract class Personagem
{
    public String Nome { get; private set; }

    public Decimal ForcaBruta { get; private set; } = new Random().Next(1,20);

    public Decimal Vida { get; private set; } = new Random().Next(1, 200);

    protected Personagem(string nome)
    {
        this.Nome = nome;
    }

    public void SetVida(Decimal vida)
    {
        if(vida < 0)
            vida = 0;

        this.Vida = vida;
    }

    public virtual Decimal Atacar()
    {
        return new Random().Next(1,20);
    }

    public override string? ToString()
    {
        return $"Nome: {this.Nome}\n" +
            $"Força Bruta: {this.ForcaBruta}\n" +
            $"Vida: {this.Vida}\n";
    }
}
