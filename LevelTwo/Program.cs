using System;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
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
        }
    }
}
