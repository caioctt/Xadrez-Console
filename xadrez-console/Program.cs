using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);

            Console.WriteLine("Posição: "+P);
        }
    }
}
