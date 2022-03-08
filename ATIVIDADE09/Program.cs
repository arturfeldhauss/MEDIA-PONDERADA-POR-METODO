using System;

namespace ATIVIDADE09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mediaponderada media = new mediaponderada();
            media.peco1 = 4;
            media.peco2 = 6;
            media.nota1 = 3;
            media.nota2 = 5;
            Console.WriteLine("A media ponderada é: " + media.mediap());
            Console.ReadLine();

        }
    }
}
