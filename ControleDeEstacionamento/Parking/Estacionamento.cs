using System;
using System.Collections.Generic;
using ControleDeEstacionamento.Alunos;

namespace ControleDeEstacionamento.Parking
{
    class Estacionamento
    {
        public int EntradaEstacionamentoPlaca(List<Aluno> alunos, List<string> veiculosEstacionados, int vagas)
        {
            Console.Write("\nInforme a Placa do veículo: ");
            string placa = Console.ReadLine().ToUpper();

            bool v = ConfirmarPlaca(placa, alunos);
            bool e = EstaEstacionadoPlaca(placa, alunos, veiculosEstacionados);

            if (!v)
            {
                Console.WriteLine("\nVeículo não cadastrado, aluno deve porcurar o setor de cadastro de veículos!\nENTRADA NÃO AUTORIZADA ");
                Console.ReadLine();
            }
            else if (e)
            {
                Console.WriteLine("\nAluno ou Veículo já se encontra estacionado! \nENTRADA NÃO AUTORIZADA");
                Console.ReadLine();
            }
            else
            {
                veiculosEstacionados.Add(placa);
                vagas--;
                Console.WriteLine("\nENTRADA AUTORIZADA! ");
                Console.ReadLine();
            }

            return vagas;
        }

        public int EntradaEstacionamentoNome(List<Aluno> alunos, List<string> veiculosEstacionados, int vagas)
        {
            Console.Write("\nInforme o nome do aluno: ");
            string nome = Console.ReadLine().ToUpper();

            bool v = ConfirmarAluno(nome, alunos);
            bool e = EstaEstacionadoNome(nome, alunos, veiculosEstacionados);

            if (!v)
            {
                Console.WriteLine("\nAluno não cadastrado!! \nENTRADA NÃO AUTORIZADA");
                Console.ReadLine();
            }
            else if (e)
            {
                Console.WriteLine("\nAluno ou Veículo já se encontra estacionado! \nENTRADA NÃO AUTORIZADA");
                Console.ReadLine();
            }
            else
            {
                veiculosEstacionados.Add(nome);
                vagas--;
                Console.WriteLine("\nENTRADA AUTORIZADA! ");
                Console.ReadLine();
            }

            return vagas;
        }

        public int SaidaEstacionamentoPlaca(List<string> veiculosEstacionados, int vagas)
        {
            Console.Write("\nInforme a Placa do veículo: ");
            string placa = Console.ReadLine().ToUpper();

            bool v = ConfirmarPlacaSaida(placa, veiculosEstacionados);

            if (!v)
            {
                Console.WriteLine("\nPlaca não encontrada \nSAÍDA NÃO AUTORIZADA ");
                Console.ReadLine();                
            }
            else
            {
                veiculosEstacionados.Remove(placa);
                vagas++;
            }

            return vagas;
        }

        public int SaidaEstacionamentoNome(List<string> veiculosEstacionados, int vagas)
        {
            Console.Write("\nInforme o nome do aluno: ");
            string nome = Console.ReadLine();

            bool v = ConfirmarAlunoSaida(nome, veiculosEstacionados);

            if (!v)
            {
                Console.WriteLine("\nNome não encontrado! \nSAÍDA NÃO AUTORIZADA");
                Console.ReadLine();                
            }

            else
            {
                veiculosEstacionados.Remove(nome);
                vagas++;
            }

            return vagas;
        }

        public bool ConfirmarPlaca(string placa, List<Aluno> alunos)
        {
            foreach (Aluno a in alunos)
            {
                if (placa == a.Veiculo.Placa.ToUpper())
                {
                    Console.WriteLine("\n" + a);
                    return true;
                }
            }

            return false;
        }

        public bool ConfirmarAluno(string nome, List<Aluno> alunos)
        {
            foreach (Aluno a in alunos)
            {
                if (nome == a.Nome.ToUpper())
                {
                    Console.WriteLine(a);
                    return true;
                }
            }

            return false;
        }

        public bool EstaEstacionadoPlaca(string placa, List<Aluno> alunos, List<string> veiculosEstacionados)
        {//função que verifica uma falha nas premissas de entrar com nome e placa, para evitar que alguém com outro carro entre e outra pessoa esse carro cadastrado também entre.
            foreach (Aluno a in alunos)
            {
                if (placa == a.Veiculo.Placa.ToUpper())
                    foreach (string s in veiculosEstacionados)
                    {
                        if (a.Nome.ToUpper() == s.ToUpper())
                            return true;
                    }                
            }

            foreach(string s in veiculosEstacionados)
            {
                if (s.ToUpper() == placa)
                    return true;
            }

            return false;
        }

        public bool EstaEstacionadoNome(string nome, List<Aluno> alunos, List<string> veiculosEstacionados)
        {
            foreach (string s in veiculosEstacionados)
            {
                if (s.ToUpper() == nome)
                    return true;
            }

            foreach (Aluno a in alunos)
            {
                if (nome == a.Nome.ToUpper())
                    foreach (string s in veiculosEstacionados)
                    {
                        if (a.Veiculo.Placa.ToUpper() == s.ToUpper())
                            return true;
                    }
            }            

            return false;
        }

        public bool ConfirmarPlacaSaida(string placa, List<string> veiculosEstacionados)
        {
            foreach (string ve in veiculosEstacionados)
            {
                if (placa == ve)
                {
                    return true;
                }
            }

            return false;
        }

        public bool ConfirmarAlunoSaida(string nome, List<string> veiculosEstacionados)
        {
            foreach (string ve in veiculosEstacionados)
            {
                if (nome == ve)
                {
                    return true;
                }
            }

            return false;
        }

        public void Estacionados(List<string> veiculosEstacionados)
        {

            Console.Clear();

            foreach (string list in veiculosEstacionados)
            {
                Console.WriteLine(list);
            }

            Console.ReadLine();
        }

    }
}
