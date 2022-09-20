using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);
            Console.WriteLine(saudacao.Length);

            string valorImportante = null;
            // o ? é pra ele fazer uma pesquisa ver se nao é valor null, para nao gerar erro e deixar mais seguro o codigo
            Console.WriteLine(valorImportante?.Length); 
        }
    }
}
