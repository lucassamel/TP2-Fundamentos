using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TP2_Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Pessoa>();

            while (true)
            {

                Console.WriteLine("Escolha uma das opções a baixo: ");
                Console.WriteLine("1 - Pesquisar Pessoas");
                Console.WriteLine("2 - Adicionar Nova Pessoa");
                Console.WriteLine("Digite qualquer outra tecla para Sair");
                string opcao = Console.ReadLine();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(" ");

                if (opcao == "1")
                {
                    Console.WriteLine("Digite o nome, ou parte do nome, da pessoa que deseja encontrar: ");
                    string encontrar = Console.ReadLine();

                    List<Pessoa> resultQuery = lista.Where(x => x.nome.Contains(encontrar)).ToList();

                    int i = 0;
                    foreach (Pessoa pessoa in resultQuery)
                    {
                        Console.WriteLine(i + " -  Nome: " + pessoa.nome + " " + pessoa.sobrenome);
                        i += 1;                        
                    }

                    Console.Write("Selecione uma das opções para visualizar os dados de uma das pessoas encontradas: ");
                    string escolha = Console.ReadLine();
                    int x = Int16.Parse(escolha);

                    Console.WriteLine("Nome: " + resultQuery[x].nome + " " + resultQuery[x].sobrenome);
                    Console.WriteLine(resultQuery[x].aniversario);

                    DateTime niver = resultQuery[x].aniversario;

                    //DateTime niver = new DateTime(2010, 10, 01);

                    niver = new DateTime(DateTime.Now.Year, niver.Month, niver.Day);

                    if (niver < DateTime.Now.Date)
                        niver = niver.AddYears(1);

                    double dias = DateTime.Now.Date.Subtract(niver).TotalDays;
                    Console.WriteLine("Faltam " + (dias *-1) + " dias para o seu aniversário");


                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine(" ");
                }
                else if (opcao == "2")
                {
                    AddPessoa(lista);
                }
                else
                {
                    break;
                }

               

            }




        }

        private static void AddPessoa(List<Pessoa> lista)
        {
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o sobrenome da pessoa: ");
            string sobrenome = Console.ReadLine();
            Console.Write("Digite a data de aniversário da pessoa no formato DD/MM/YYYY : ");
            string data = Console.ReadLine();
            DateTime aniversario = Convert.ToDateTime(data);
            Pessoa pessoa = new Pessoa(nome, sobrenome, aniversario);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Os dados abaixo estão corretos?");
            Console.WriteLine("Nome: " + pessoa.nome + " " + pessoa.sobrenome);
            Console.WriteLine("Aniversário: " + pessoa.aniversario);
            Console.WriteLine("1 - SIM");
            Console.WriteLine("2 - NÃO");
            string escolha = Console.ReadLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(" ");

            if (escolha == "1")
            {
                Console.WriteLine("Dados adicionados com sucesso!");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(" ");

            }
            else
            {
                AddPessoa(lista);
            }
            lista.Add(pessoa);
        }
    }
}
