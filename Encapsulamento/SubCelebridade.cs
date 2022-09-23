using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class SubCelebridade {
        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // herança
        protected string CorDoOlho = "Verde";

        // mesmo projeto (assembly)
        internal ulong NumeroCelular = 5541995807878;

        // herança
        protected internal string JeitoDeFalar = "Uso muitas girias";

        // mesma class ou herança no memso projeto
        private protected string SegredoFamilia = "Bla Bla";

        // private é o padrao

        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
