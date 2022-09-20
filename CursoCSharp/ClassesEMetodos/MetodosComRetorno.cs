using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b; 
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }
        public int Divisao(int a, int b) {
            return a / b;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }

    internal class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var ressultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(ressultado);
            Console.WriteLine(calculadoraComum.Subtrair(9, 4));
            Console.WriteLine(calculadoraComum.Multiplicar(5, 10)); ;
            Console.WriteLine(calculadoraComum.Divisao(10, 2));

            var calculadoraCadeia = new CalculadoraCadeia();
            Console.WriteLine(calculadoraCadeia.Somar(10).Multiplicar(2).Imprimir().Limpar().Imprimir());
        }
    }
}
