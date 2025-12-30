using MiniRPG.Models;
using MiniRPG.Models.Abstracts;

bool VerificarVitoria(Personagem p)
{
    return p.Vida <= 0;
}

void ExibirVitoria(Personagem p)
{
    if (VerificarVitoria(p))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(p.Nome + " foi derrotado!");
        Console.ResetColor();
    }
}

void ExibirInfo(Personagem p)
{
    if(p.GetType() == typeof(Guerreiro))
        Console.ForegroundColor = ConsoleColor.Red;
    else
        Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(p);
    Console.ResetColor();
}

void ExibirRodada(int contador)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"RODADA {contador}");
    Console.ResetColor();
}

Guerreiro g = new Guerreiro("Jorge");
Mago m = new Mago("Charles");
int contadorRodadas = 1;

ExibirInfo(g);
ExibirInfo(m);

Console.WriteLine();

do
{
    Decimal ataqueGuerreiro = 0;
    Decimal ataqueMago = 0;

    Console.WriteLine("-------------------------------------------------------------------------------");
    ExibirRodada(contadorRodadas);

    ataqueGuerreiro = g.Atacar();
    Console.WriteLine(g.Nome + $" realizará um ataque de {ataqueGuerreiro} pontos de Vida.");

    m.SetVida(m.Vida - ataqueGuerreiro);

    Console.WriteLine();

    ExibirInfo(m);

    Console.WriteLine();

    ExibirVitoria(m);

    if (VerificarVitoria(m))
        break;

    Console.WriteLine();

    if(contadorRodadas % 2 == 0)
    {
        ataqueMago = m.Especial();
        Console.WriteLine(m.Nome + $" realizará um ataque especial de {ataqueMago} pontos de Vida.");
    }
    else
    {
        ataqueMago = m.Atacar();
        Console.WriteLine(m.Nome + $" realizará um ataque de {ataqueMago} pontos de Vida.");
    }

    g.SetVida(g.Vida - ataqueMago);

    Console.WriteLine();

    ExibirInfo(g);

    ExibirVitoria(g);

    contadorRodadas++;
} while (m.Vida > 0 && g.Vida > 0);

