using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos" , Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos" , VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos" , Inferencia.Executar},
                {"Interpolação - Fundamentos" , Interpolacao.Executar},
                {"Notação Ponto - Fundamentos" , NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos" , LendoDados.Executar},
                {"Formatando Número - Fundamentos" , FormatandoNumero.Executar},
                {"Corversões - Fundamentos" , Conversoes.Executar},
                {"Operadores Aritmericos - Fundamentos" , OperadoresAritmericos.Executar},
                {"Operadores Relacionais - Fundamentos" , OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos" , OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos" , OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos" , OperadoresUnarios.Executar},
                {"Operadores Ternário - Fundamentos" , OperadorTernario.Executar},

                // Estrutura de Controle
                {"Estrutura IF - Estrutura de Controle" , EstruturaIf.Executar},
                {"Estrutura IF/Else - Estrutura de Controle" , EstruturaIfElse.Executar},
                {"Estrutura IF/ElseIf - Estrutura de Controle" , EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle" , EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle" , EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de Controle" , EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle" , EstruturaFor.Executar},
                {"Estrutura ForEach - Estrutura de Controle" , EstruturaForEach.Executar},

                // Classes e Metodos
                {"Membros - Classes e Metodos" , Membros.Executar},
                {"Construtores - Classes e Metodos" , Construtores.Executar},
                {"Metodos Com Retorno - Classes e Metodos" , MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Metodos" , MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Metodos" , AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos" , DesafioAtributo.Executar},
                {"Params - Classes e Metodos" , Params.Executar},
                {"Parametros Nomeados - Classes e Metodos" , ParametrosNomeados.Executar},
                {"Get e Set - Classes e Metodos" , GetSet.Executar},
                {"Props - Classes e Metodos" , Props.Executar},
                {"Readonly - Classes e Metodos" , Readonly.Executar},
                {"Exemplo Enum - Classes e Metodos" , ExemploEnum.Executar},
                {"Struct - Classes e Metodos" , ExemploStruct.Executar},
                {"Struct Vs Classes - Classes e Metodos" , StructVsClasse.Executar},
                {"Valor Vs Referência - Classes e Metodos" , ValorVsReferencia.Executar},
                {"Parametros Por Referência - Classes e Metodos" , ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Metodos" , ParametroPadrao.Executar},

                // Coleções
                {"Array - Coleções" , Colecoes.Array.Executar},
                {"List - Coleções" , ColecoesList.Executar},
                {"Array List - Coleções" , ColecoesArrayList.Executar},
                {"Set - Coleções" , ColecoesSet.Executar},
                {"Queue - Coleções" , ColecoesQueue.Executar},

                //OO
                {"Herança - OO" , Heranca.Executar},
                {"Construtor This - OO" , ConstrutorThis.Executar},
                {"Encapsulamento - OO" , OO.Encapsulamento.Executar},
                {"Polimorfismo - OO" , Polimorfismo.Executar},
                {"Abstract - OO" , Abstract.Executar},
                {"Interface - OO" , Interface.Executar},
                {"Sealed - OO" , Sealed.Executar},

                // Metodos & Funções
                {"Exemplo Lambda - Metodos & Funções" , ExemploLambda.Executar},
                {"Lambdas Delegate - Metodos & Funções" , LambdasDelegate.Executar},
                {"Usando Delegate - Metodos & Funções" , UsandoDelegate.Executar},
                {"Delegate com Funções Anonimas - Metodos & Funções" , DelegateFuncAnonima.Executar},
                {"Delegate com Parametros - Metodos & Funções" , DelegatesComParametros.Executar},
                {"Metodos de Extensão - Metodos & Funções" , MetodosDeExtensao.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}