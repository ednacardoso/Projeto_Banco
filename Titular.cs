using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco1
{
    
    
        public class Titular
        {
        public Titular()
        {
        }

        public Titular(string nome, int idade, string sexo, string profissao, string cpfpessoa)
            {
                Nome = nome;
                Idade = idade;
                Sexo = sexo;
                Profissao = profissao;
                CPFPessoa = cpfpessoa;
            }

            public int ID { get; set; }
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Sexo { get; set; }
            public string Profissao { get; set; }
            public string CPFPessoa { get; set; }

            public string ApresentarCliente()
            {
                return Nome;
            }

            public void FinalizarSessao(string nome)
            {
                if (nome == null)
                {
                    Console.WriteLine("Sessão encerrada");
                }
            }
        }
    }

