using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaIf {
        public static void Executar() {
            bool bomCompartamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if(entrada == "S" || entrada == "s") {
            //    bomCompartamento = true;
            //}

            // bomComportamento = entrada == "S" || entrada = "s";
            bomCompartamento = entrada.ToLower() == "s";

            if(nota >= 9.0 && bomCompartamento) {
                Console.WriteLine("Quadro de honra!");
            }




        }
    }
}
