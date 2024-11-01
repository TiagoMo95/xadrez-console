using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 9));
            tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 0));

            Tela.ImprimirTabuleiro(tab);
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
