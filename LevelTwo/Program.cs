using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
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
            var image = new Spectre.Console.Image(imagem);

            image = image.WithWidht(largura);
            AnsiConsole.Write(image);
        }
    }
}
