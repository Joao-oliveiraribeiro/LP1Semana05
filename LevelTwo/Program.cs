using System;
using Spectre.Console;
using SoGoodLib;

namespace LevelTwo
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SoGoodClass.SoGoodMethod());

            string nomeImagem = "tux.jpg";
            int largura = 24;

            if (args.Length >=1)
            {
                nomeImagem = args[0];

            }
            if (args.Length >=2)
            {
                largura = int.Parse(args[1]);
            }

            mostrarImagem(nomeImagem, largura);
        }

        static void mostrarImagem(string imagem, int largura)
        {
            
            AnsiConsole.Image(image).Width(largura);
        }
    }
}
