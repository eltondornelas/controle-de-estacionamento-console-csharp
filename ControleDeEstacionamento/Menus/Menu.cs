using System;
using System.Collections.Generic;
using ControleDeEstacionamento.Alunos;



namespace ControleDeEstacionamento.Menus
{
    class Menu
    {
        List<Aluno> alunos = new List<Aluno>();

        public void TelaInicialCadastro()
        {

            Veiculo veiculo;
            Veiculo padrao = new Veiculo(null, null, null);


            alunos.Add(new Aluno("Elton", "08251920485", "2009108453", "Programacao", "1º", padrao));
            alunos.Add(new Aluno("Brivaldo", "15008673491", "2009108450", "Contabilidade", "8º", veiculo = new Veiculo("PDJ4952", "Hyundai", "HB20")));
            alunos.Add(new Aluno("Everton", "1234567890", "2009108320", "Engenharia", "10º", padrao));
            alunos.Add(new Aluno("Paulo", "1345173491", "2009112450", "Nutricao", "5º", padrao));
            alunos.Add(new Aluno("Amanda", "1531233491", "20429108450", "Direito", "3º", padrao));

            Console.Clear();

            Console.WriteLine("[1] Cadastrar Veículo \n[2] Consultar Veículo\n[3] Sair");

            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    ConsultarAluno();
                    break;
                case 2:
                    ConsultarVeiculo();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }


        public void ConsultarAluno()
        {
            Console.Clear();

            Console.WriteLine("Deseja consultar por qual opção: ");
            Console.WriteLine("[1] Nome \n[2] CPF \n[3] Matricula");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    ConsultarNome();
                    break;
                case 2:
                    ConsultarCPF();
                    break;
                case 3:
                    ConsultarMatricula();
                    break;
            }

        }

        public void ConsultarNome()
        {
            Console.Clear();

            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();

            foreach (Aluno a in alunos)
                if (a.Nome == nome)
                {
                    Console.WriteLine("Aluno é Cadastrado!");
                    Console.WriteLine();
                    CadastrarVeiculo(a);
                    return;
                }

            Console.WriteLine("Aluno NÃO Cadastrado!");
            Console.ReadLine();
            TelaInicialCadastro();
        }

        public void ConsultarCPF()
        {
            Console.Clear();

            Console.Write("Informe o CPF do aluno: ");
            string cpf = Console.ReadLine();

            foreach (Aluno a in alunos)
                if (a.CPF == cpf)
                {
                    Console.WriteLine("Aluno é Cadastrado!");
                    Console.WriteLine();
                    CadastrarVeiculo(a);
                    return;
                }

            Console.WriteLine("Aluno NÃO Cadastrado!");
            Console.ReadLine();
            TelaInicialCadastro();

        }

        public void ConsultarMatricula()
        {
            Console.Clear();

            Console.Write("Informe a matrícula do aluno: ");
            string matricula = Console.ReadLine();

            foreach (Aluno a in alunos)
                if (a.Matricula == matricula)
                {
                    Console.WriteLine("Aluno é Cadastrado!");
                    Console.WriteLine();
                    CadastrarVeiculo(a);
                    return;
                }

            Console.WriteLine("Aluno NÃO Cadastrado!");
            Console.ReadLine();
            TelaInicialCadastro();
        }

        public void CadastrarVeiculo(Aluno aluno)
        {
            if (aluno.Veiculo.Placa == null)
            {
                Console.Clear();

                Console.WriteLine(aluno);
                Console.WriteLine();

                Console.WriteLine("[1] Cadastrar Veículo \n[2] Cancelar \n\n");
                int x = int.Parse(Console.ReadLine());
                if (x == 2)
                    TelaInicialCadastro();
                else
                {
                    Console.Clear();
                    Console.Write("Digite a placa do veículo: ");
                    aluno.Veiculo.Placa = Console.ReadLine();

                    Console.Write("Digite o fabricante do veículo: ");
                    aluno.Veiculo.Fabricante = Console.ReadLine();

                    Console.Write("Digite o modelo do veículo: ");
                    aluno.Veiculo.Modelo = Console.ReadLine();

                    Console.WriteLine("\nALUNO CADASTRADO COM SUCESSO! ");
                    Console.ReadLine();

                    TelaInicialCadastro();

                }
            }

            else
            {
                Console.Clear();

                Console.WriteLine(aluno);
                Console.WriteLine();

                Console.WriteLine("[1] Alterar Veículo \n[2] Remover Veículo \n[3] Cancelar \n");
                int x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 3:
                        TelaInicialCadastro();
                        break;

                    case 1:
                        AlterarVeiculo(aluno);
                        break;

                    case 2:
                        RemoverVeiculo(aluno);
                        break;
                }
            }

            Console.ReadLine();

        }

        public void AlterarVeiculo(Aluno aluno)
        {
            Console.Clear();

            Console.WriteLine(aluno);
            Console.WriteLine();

            Console.Write("Digite a placa do novo veículo: ");
            aluno.Veiculo.Placa = Console.ReadLine();

            Console.Write("Digite o fabricante do novo veículo: ");
            aluno.Veiculo.Fabricante = Console.ReadLine();

            Console.Write("Digite o modelo do novo veículo: ");
            aluno.Veiculo.Modelo = Console.ReadLine();

            Console.WriteLine("\nALTERAÇÃO DE VEÍCULO EXECUTADA COM SUCESSO! ");
            Console.ReadLine();

            TelaInicialCadastro();
        }

        public void RemoverVeiculo(Aluno aluno)
        {
            Console.Clear();

            Console.WriteLine(aluno);
            Console.WriteLine();

            Console.WriteLine("Tem certeza que deseja remover este veículo desse Aluno? \n\n[1] Sim \n[2] Não");
            int x = int.Parse(Console.ReadLine());
            if (x == 2)
            {

                Console.WriteLine("\nOperação cancelada! ");
                Console.ReadLine();
                TelaInicialCadastro();
            }
            else
            {
                aluno.Veiculo.Placa = null;
                aluno.Veiculo.Fabricante = null;
                aluno.Veiculo.Modelo = null;

                Console.WriteLine("\nOPERAÇÃO REALIZADA COM SUCESSO! ");
                Console.ReadLine();

                TelaInicialCadastro();
            }
        }

        public void ConsultarVeiculo()
        {
            Console.Clear();

            Console.Write("Informe a placa a ser consultada: ");
            string placa = Console.ReadLine();

            foreach (Aluno a in alunos)
            {
                if (placa == a.Veiculo.Placa)
                {
                    Console.WriteLine("Veículo Cadastrado! \n");
                    Console.WriteLine(a);
                    Console.ReadLine();
                    TelaInicialCadastro();
                    return;
                }

            }

            Console.WriteLine("Veículo não é cadastrado!");
            Console.ReadLine();
            TelaInicialCadastro();
        }

        int vagas = 3;
        List<string> veiculosEstacionados = new List<string>();

        public void TelaInicialConsulta()
        {
            Veiculo veiculo;
            Veiculo padrao = new Veiculo(null, null, null);


            alunos.Add(new Aluno("Elton", "08251920485", "2009108453", "Programacao", "1º", padrao));
            alunos.Add(new Aluno("Brivaldo", "15008673491", "2009108450", "Contabilidade", "8º", veiculo = new Veiculo("PDJ4952", "Hyundai", "HB20")));
            alunos.Add(new Aluno("Everton", "1234567890", "2009108320", "Engenharia", "10º", padrao));
            alunos.Add(new Aluno("Paulo", "1345173491", "2009112450", "Nutricao", "5º", padrao));
            alunos.Add(new Aluno("Amanda", "1531233491", "20429108450", "Direito", "3º", padrao));


            int x = 0;
            do
            {
                Console.Clear();

                Console.WriteLine("VAGAS DISPONÍVEIS: " + vagas);
                Console.WriteLine("\n[1] Entrada \n[2] Saída \n[3] Visualizar Veiculos Estacionados \n[4] Fechar Programa");
                x = int.Parse(Console.ReadLine());
                if (x >= 1 && x <= 4)
                    break;

                Console.WriteLine("OPÇÃO INVÁLIDA!");
                Console.ReadLine();

            } while (x < 1 || x > 4);

            if (x == 4)
                Environment.Exit(0);


            if (x == 1)
            {
                int y = 0;
                do
                {
                    if (vagas == 0)
                    {
                        Console.WriteLine("Limite de vagas esgotado! \nAguardar saída de veículos!");
                        Console.ReadLine();
                        TelaInicialConsulta();
                    }

                    Console.WriteLine("\nEscolha a opção de consulta: ");
                    Console.WriteLine("\n[1] Placa \n[2] Nome");
                    y = int.Parse(Console.ReadLine());
                    if (y == 1 || y == 2)
                        break;

                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                    Console.ReadLine();

                } while (y < 1 || y > 2);

                if (y == 1)
                {
                    Console.Write("\nInforme a Placa do veículo: ");
                    string placa = Console.ReadLine();

                    bool v = ConfirmarPlaca(placa, alunos);

                    if (!v)
                    {
                        Console.WriteLine("\nVeículo não cadastrado, aluno deve porcurar o setor de cadastro de veículos!\nENTRADA NÃO AUTORIZADA ");
                        Console.ReadLine();
                        TelaInicialConsulta();
                    }

                    else
                    {

                        Entrada(veiculosEstacionados, placa);
                        vagas--;
                        TelaInicialConsulta();
                    }

                }

                if (y == 2)
                {

                    Console.Write("\nInforme o nome do aluno: ");
                    string nome = Console.ReadLine();

                    bool v = ConfirmarAluno(nome, alunos);

                    if (!v)
                    {
                        Console.WriteLine("\nAluno não cadastrado!! \nENTRADA NÃO AUTORIZADA");
                        Console.ReadLine();
                        TelaInicialConsulta();
                    }

                    else
                    {
                        Entrada(veiculosEstacionados, nome);
                        vagas--;
                        TelaInicialConsulta();
                    }

                }
            }

            if (x == 2)
            {
                int y = 0;
                do
                {
                    Console.WriteLine("\nEscolha a opção de consulta: ");
                    Console.WriteLine("\n[1] Placa \n[2] Nome");
                    y = int.Parse(Console.ReadLine());
                    if (y == 1 || y == 2)
                        break;

                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                    Console.ReadLine();

                } while (y < 1 || y > 2);

                if (y == 1)
                {
                    Console.Write("\nInforme a Placa do veículo: ");
                    string placa = Console.ReadLine();

                    bool v = ConfirmarPlacaSaida(placa, veiculosEstacionados);

                    if (!v)
                    {
                        Console.WriteLine("\nPlaca não encontrada \nSAÍDA NÃO AUTORIZADA ");
                        Console.ReadLine();
                        TelaInicialConsulta();
                    }

                    else
                    {
                        Saida(veiculosEstacionados, placa);
                        vagas++;
                        TelaInicialConsulta();
                    }


                }

                if (y == 2)
                {

                    Console.Write("\nInforme o nome do aluno: ");
                    string nome = Console.ReadLine();

                    bool v = ConfirmarAlunoSaida(nome, veiculosEstacionados);

                    if (!v)
                    {
                        Console.WriteLine("\nNome não encontrado! \nSAÍDA NÃO AUTORIZADA");
                        Console.ReadLine();
                        TelaInicialConsulta();
                    }

                    else
                    {
                        Saida(veiculosEstacionados, nome);
                        vagas++;
                        TelaInicialConsulta();
                    }


                }

            }

            if (x == 3)
            {
                Console.Clear();

                foreach (string list in veiculosEstacionados)
                {
                    Console.WriteLine(list);
                }

                Console.ReadLine();
                TelaInicialConsulta();
            }

        }

        public bool ConfirmarPlaca(string placa, List<Aluno> alunos)
        {
            foreach (Aluno a in alunos)
            {
                if (placa == a.Veiculo.Placa)
                {
                    return true;
                }
            }

            return false;
        }

        public bool ConfirmarAluno(string nome, List<Aluno> alunos)
        {
            foreach (Aluno a in alunos)
            {
                if (nome == a.Nome)
                {
                    return true;
                }
            }

            return false;
        }

        public void Entrada(List<string> veiculosEstacionados, string estacionar)
        {
            veiculosEstacionados.Add(estacionar);
            Console.WriteLine("ENTRADA AUTORIZADA! ");
            Console.ReadLine();

        }

        public void Saida(List<string> veiculosEstacionados, string estacionar)
        {
            veiculosEstacionados.Remove(estacionar);
            Console.WriteLine("SAÍDA AUTORIZADA! ");
            Console.ReadLine();

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

        //criar uma conferência se o aluno já estar estacionado
    }
}