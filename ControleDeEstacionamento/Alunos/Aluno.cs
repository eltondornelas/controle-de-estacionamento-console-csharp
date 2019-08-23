using System;
using System.Collections.Generic;


namespace ControleDeEstacionamento.Alunos
{
    class Aluno
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public string Periodo { get; set; }
        public Veiculo Veiculo { get; set; }
        //public Menu m = new Menu();
        //public CadastroVeiculos cv = new CadastroVeiculos();

        public Aluno()
        {

        }

        public Aluno(string nome, string cpf, string matricula, string curso, string periodo, Veiculo veiculo)
        {
            Nome = nome;
            CPF = cpf;
            Matricula = matricula;
            Curso = curso;
            Periodo = periodo;
            Veiculo = veiculo;
        }

        public override string ToString()
        {
            if (Veiculo.Placa == "0")
            {
                return "Nome: " + Nome
                    + "\nCPF: " + CPF
                    + "\nMatricula: " + Matricula
                    + "\nCurso:  " + Curso
                    + "\nPeriodo: " + Periodo
                    + "\nVeiculo: Nenhum";
            }
            else
            {
                return "Nome: " + Nome
                   + "\nCPF: " + CPF
                   + "\nMatricula: " + Matricula
                   + "\nCurso:  " + Curso
                   + "\nPeriodo: " + Periodo
                   + "\n\nVeiculo Placa: " + Veiculo.Placa
                   + "\nVeiculo Fabricante: " + Veiculo.Fabricante
                   + "\nVeiculo Modelo: " + Veiculo.Modelo;
            }

        }

        public void ConsultarNome(List<Aluno> alunos)
        {
            Console.Clear();

            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();

            foreach (Aluno a in alunos)
                if (nome.ToUpper() == a.Nome.ToUpper())
                {
                    Console.WriteLine("Aluno é Cadastrado!");
                    Console.ReadLine();
                    CadastrarVeiculo(a);
                    return;
                }

            Console.WriteLine("Aluno NÃO Cadastrado!");
            Console.ReadLine();
        }

        public void ConsultarCPF(List<Aluno> alunos)
        {
            Console.Clear();

            Console.Write("Informe o CPF do aluno: ");
            string cpf = Console.ReadLine();

            foreach (Aluno a in alunos)
                if (a.CPF == cpf)
                {
                    Console.WriteLine("Aluno é Cadastrado!");
                    Console.ReadLine();
                    CadastrarVeiculo(a);
                    return;
                }

            Console.WriteLine("Aluno NÃO Cadastrado!");
            Console.ReadLine();
        }

        public void ConsultarMatricula(List<Aluno> alunos)
        {
            Console.Clear();

            Console.Write("Informe a matrícula do aluno: ");
            string matricula = Console.ReadLine();

            foreach (Aluno a in alunos)
                if (a.Matricula == matricula)
                {
                    Console.WriteLine("Aluno é Cadastrado!");
                    Console.ReadLine();
                    CadastrarVeiculo(a);
                    return;
                }

            Console.WriteLine("Aluno NÃO Cadastrado!");
            Console.ReadLine();

        }


        public void CadastrarVeiculo(Aluno aluno)
        {
            if (aluno.Veiculo.Placa == "nenhum")
            {
                int x;
                bool c = true;
                do
                {
                    try
                    {
                        Console.Clear();

                        Console.WriteLine(aluno);
                        Console.WriteLine();

                        Console.WriteLine("[1] Cadastrar Veículo \n[2] Cancelar \n\n");
                        x = int.Parse(Console.ReadLine());

                        if (x < 1 || x > 2)
                        {
                            Console.WriteLine("Opção inválida! 7");
                            Console.ReadLine();
                        }
                        else if (x == 2)
                        {
                            c = false;
                        }

                        else if (x == 1)
                        {
                            Console.Clear();
                            Console.Write("Digite a placa do veículo: ");
                            aluno.Veiculo.Placa = Console.ReadLine().ToUpper();

                            Console.Write("Digite o fabricante do veículo: ");
                            aluno.Veiculo.Fabricante = Console.ReadLine().ToUpper();

                            Console.Write("Digite o modelo do veículo: ");
                            aluno.Veiculo.Modelo = Console.ReadLine().ToUpper();

                            Console.WriteLine("\nALUNO CADASTRADO COM SUCESSO! ");

                            Console.ReadLine();
                            c = false;
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Opção inválida! 8");
                        Console.ReadLine();
                    }

                } while (c);
            }

            else
            {
                bool c = true;
                int x;
                do
                {
                    try
                    {
                        Console.Clear();

                        Console.WriteLine(aluno);
                        Console.WriteLine();

                        Console.WriteLine("[1] Alterar Veículo \n[2] Remover Veículo \n[3] Cancelar \n");
                        x = int.Parse(Console.ReadLine());

                        if (x < 1 || x > 3)
                        {
                            Console.WriteLine("Opção inválida! 9");
                            Console.ReadLine();
                        }
                        else
                        {
                            switch (x)
                            {
                                case 3:
                                    c = false;
                                    break;

                                case 1:
                                    AlterarVeiculo(aluno);
                                    c = false;
                                    break;

                                case 2:
                                    RemoverVeiculo(aluno);
                                    c = false;
                                    break;
                            }
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Opção inválida! 10");
                        Console.ReadLine();
                    }

                } while (c);
            }

        }

        public void AlterarVeiculo(Aluno aluno)
        {
            Console.Clear();

            Console.WriteLine(aluno);
            Console.WriteLine();

            Console.Write("Digite a placa do novo veículo: ");
            aluno.Veiculo.Placa = Console.ReadLine().ToUpper();

            Console.Write("Digite o fabricante do novo veículo: ");
            aluno.Veiculo.Fabricante = Console.ReadLine().ToUpper();

            Console.Write("Digite o modelo do novo veículo: ");
            aluno.Veiculo.Modelo = Console.ReadLine().ToUpper();

            Console.WriteLine("\nALTERAÇÃO DE VEÍCULO EXECUTADA COM SUCESSO! ");
            Console.ReadLine();
        }

        public void RemoverVeiculo(Aluno aluno)
        {
            bool c = true;
            int x;

            do
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine(aluno);
                    Console.WriteLine();

                    Console.WriteLine("Tem certeza que deseja remover este veículo desse Aluno? \n\n[1] Sim \n[2] Não");
                    x = int.Parse(Console.ReadLine());
                    if (x < 1 || x > 2)
                    {
                        Console.WriteLine("Opção inválida! 11");
                        Console.ReadLine();
                    }

                    else if (x == 2)
                    {
                        Console.WriteLine("\nOperação cancelada! ");
                        Console.ReadLine();
                        c = false;
                    }
                    else if (x == 1)
                    {
                        aluno.Veiculo.Placa = "nenhum";
                        aluno.Veiculo.Fabricante = "nenhum";
                        aluno.Veiculo.Modelo = "nenhum";

                        Console.WriteLine("\nOPERAÇÃO REALIZADA COM SUCESSO! ");
                        Console.ReadLine();
                        c = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Opção inválida! 12");
                    Console.ReadLine();
                }

            } while (c);
        }

    }
}