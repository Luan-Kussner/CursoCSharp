using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Luan Kussner";
            sicrano.Idade = 22;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");
            sicrano.ApresentarConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Kussner";
            fulano.Idade = 13;

            var apresentacaoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoFulano.Length);
            Console.WriteLine(apresentacaoFulano);
        }
    }
}
