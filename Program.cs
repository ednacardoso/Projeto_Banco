

using Projeto_Banco1;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Projeto_Banco
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var contaBancaria = new ContaBancaria();
            contaBancaria.NomeConta = "Conta Um";
            contaBancaria.Agencia = 01;
            contaBancaria.NumeroConta = 1234;
            contaBancaria.Saldo = 1000;


            contaBancaria.Titular = new Titular()
            {
                Nome = "Michael Jackson da Silva",
                Idade = 34,
                Sexo = "masculino",
                Profissao = "Encarregado de TI",
                CPFPessoa = "12385298712",
            };

            Console.WriteLine($"O saldo atual é: {contaBancaria.VerSaldo()}");

            contaBancaria.Depositar(150);

            Console.WriteLine($"O saldo atual é: { contaBancaria.VerSaldo()}");

            contaBancaria.Sacar(900);

            Console.WriteLine($"O saldo atual é: {contaBancaria.VerSaldo()}");

            contaBancaria.Sacar(2000);

            Console.ReadKey();


        }
    }

    

    
}
