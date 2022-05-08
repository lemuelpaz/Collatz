using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_D1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Maxseq(1000000);    //Estabelecido;            

        }

        public static void Maxseq(uint num)
        {
            uint Valor = 0;
            uint Quantidade = 0;

            for (uint i = 1; i <= num; i++)
            {
                uint QuantidadeAtual = qtseq(i); //Calculando a quantidade de sequencias;
                if (QuantidadeAtual > Quantidade)
                {
                    Valor = i;
                    Quantidade = QuantidadeAtual;
                }
            }

            Console.WriteLine($"Qual foi o número com maior sequencia? {Valor:n}");
            Console.WriteLine($"Sequência que foi registrada: {Quantidade:n}");
        }

        public static uint Formula(uint num)
        {
            if (num % 2 == 0)          //Equação;
                return num / 2;

            return num * 3 + 1;        //Equação;
        }

        public static uint qtseq(uint num)
        {
            ushort AvaliaçãoQuant = 0;

            for (ushort i = 1; num != 1; i++)
            {
                num = Formula(num);
                AvaliaçãoQuant += 1;
            }
            return AvaliaçãoQuant;

        }

    }
}
