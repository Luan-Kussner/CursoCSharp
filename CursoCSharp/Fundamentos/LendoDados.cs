﻿using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seus salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
