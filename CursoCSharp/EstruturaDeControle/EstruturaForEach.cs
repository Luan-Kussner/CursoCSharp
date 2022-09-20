using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaForEach {
        public static void Executar() {
            var palavra = "Opa!";

            foreach (var item in palavra) {
                Console.WriteLine(item);
            }

            var alunos = new string[] { "Luan", "Kussner" };

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
