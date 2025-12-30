# MiniRPG

**MiniRPG** é um jogo simples desenvolvido em C# que simula uma batalha entre dois personagens: um **Guerreiro** e um **Mago**. Cada personagem possui atributos como Força Bruta, Vida, e habilidades especiais. A batalha se desenrola em rodadas, onde os personagens atacam uns aos outros até que um deles tenha sua Vida reduzida a 0.

## Estrutura do Projeto

### Classes

1. **Personagem** (Abstract)
    - Classe base que representa um personagem no jogo.
    - Contém as propriedades:
        - `Nome`: Nome do personagem.
        - `ForcaBruta`: A força de ataque do personagem, gerada aleatoriamente entre 1 e 20.
        - `Vida`: A quantidade de vida do personagem, gerada aleatoriamente entre 1 e 200.
    - Métodos:
        - `SetVida(Decimal vida)`: Atualiza a vida do personagem.
        - `Atacar()`: Método virtual que simula um ataque e retorna o dano causado.
        - `ToString()`: Exibe as informações do personagem.

2. **Guerreiro** (Classe derivada de `Personagem`)
    - Representa o personagem Guerreiro.
    - Sobrescreve o método `Atacar()` para calcular o dano com base na `ForcaBruta`.

3. **Mago** (Classe derivada de `Personagem` e implementa a interface `IHabilidadeEspecial`)
    - Representa o personagem Mago.
    - Possui a propriedade `Mana` (valor gerado aleatoriamente entre 1 e 20).
    - Sobrescreve o método `Atacar()` para calcular o dano com base na `Mana`.
    - Implementa o método `Especial()`, que realiza um ataque especial baseado na `Mana`.

4. **IHabilidadeEspecial** (Interface)
    - Define o método `Especial()`, que é implementado por personagens com habilidades especiais (como o Mago).

### Funções de Jogo

1. **VerificarVitoria(Personagem p)**
    - Verifica se a vida de um personagem é menor ou igual a 0, indicando que o personagem foi derrotado.

2. **ExibirVitoria(Personagem p)**
    - Exibe uma mensagem informando se o personagem foi derrotado.

3. **ExibirInfo(Personagem p)**
    - Exibe as informações do personagem, colorindo a saída dependendo do tipo de personagem (vermelho para o Guerreiro, azul para o Mago).

4. **ExibirRodada(int contador)**
    - Exibe o número da rodada atual.

### Fluxo de Jogo

- O jogo começa com um **Guerreiro** e um **Mago** sendo instanciados.
- Em cada rodada, os personagens se atacam alternadamente:
  - O Guerreiro realiza um ataque baseado na sua **Força Bruta**.
  - O Mago alterna entre um ataque normal e um ataque especial (dependendo da rodada).
- O jogo continua até que um dos personagens tenha sua Vida reduzida a 0, e o vencedor é exibido.

## Como Executar

1. Clone ou baixe o repositório.
2. Abra o projeto em um IDE compatível com C# (como Visual Studio ou Visual Studio Code).
3. Compile e execute o projeto.
4. O jogo irá mostrar as rodadas e os ataques realizados por cada personagem até a vitória de um deles.

### Exemplo de Saída:

