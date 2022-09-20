using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Array {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Luan";
            alunos[1] = "Gio";
            alunos[2] = "Bia";
            alunos[3] = "Carla";
            alunos[4] = "Leo";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatoria = 0;
            double[] notas = { 9.1, 8.5, 4.1, 9.9, 9.8};

            foreach (var nota in notas) {
                somatoria += nota;
            }

            double media = somatoria / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
