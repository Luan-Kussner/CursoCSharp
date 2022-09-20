﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() {

        }
    }

    internal class Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Modelo = "Corsa";
            carro1.Fabricante = "1.0";
            carro1.Ano = 2023;
            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

            var carro2 = new Carro("Clio", "1.0", 2013);
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

            var carro3 = new Carro() {
                Modelo = "Uno",
                Fabricante = "1.6",
                Ano = 1975
            };
            Console.WriteLine($"{carro3.Modelo} {carro3.Fabricante} {carro3.Ano}");
        }
    }
}
