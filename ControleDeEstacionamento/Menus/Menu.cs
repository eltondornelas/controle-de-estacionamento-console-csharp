using System;
using System.Collections.Generic;
using ControleDeEstacionamento.Alunos;


namespace ControleDeEstacionamento.Menus
{
    class Menu
    {
        List<Aluno> alunos = new List<Aluno>();

        public void Login() //futuramente terá que criar dois usuários: para cadastro e para consulta.
        {
            bool c = false;

            alunos.Add(new Aluno("Elton", "08251920485", "2009108453", "Programacao", "1º", new Veiculo("PFX5107", "FORD", "FIESTA")));
            alunos.Add(new Aluno("Brivaldo", "15008673491", "2009108450", "Contabilidade", "8º", new Veiculo("nenhum", "nenhum", "nenhum")));
            alunos.Add(new Aluno("Everton", "1234567890", "2009108320", "Engenharia", "10º", new Veiculo("nenhum", "nenhum", "nenhum")));
            alunos.Add(new Aluno("Paulo", "1345173491", "2009112450", "Nutricao", "5º", new Veiculo("nenhum", "nenhum", "nenhum")));
            alunos.Add(new Aluno("Amanda", "1531233491", "20429108450", "Direito", "3º", new Veiculo("nenhum", "nenhum", "nenhum")));


            do
            {
                Console.Clear();
                string user = "elton";
                string senha = "1234";

                Console.Write("Usuário: ");
                string u = Console.ReadLine();
                Console.Write("Senha: ");
                string s = Console.ReadLine();

                if (u != user || s != senha)
                {
                    Console.Write("Usuário ou senha incorreto!");
                    Console.ReadLine();
                }
                else
                    c = true;

            } while (!c);

            Usuario();
        }
        //paradigmas de programação estruturado e orientação a objetos
        public void Usuario()
        {
            bool c = true;
            int x;

            do
            {
                try
                {                    
                    Console.Clear();

                    Console.WriteLine("Deseja entrar em: \n\n[1] Sistema de Cadastro \n[2] Sistema de Controle de Entrada e Saída \n[3] Fechar Programa");
                    x = int.Parse(Console.ReadLine());

                    if (x < 1 || x > 3)
                    {
                        Console.WriteLine("\nOpção Inválida! 1");
                        Console.ReadLine();
                    }

                    else if (x == 3)
                        c = false;

                    else if (x == 1)
                    {
                        TelaInicialCadastro();
                    }
                    else if (x == 2)
                    {
                        UsuarioControleEstacionamento();
                        TelaInicialConsulta();
                        c = false;
                    }
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Opção inválida! 2");
                    Console.ReadLine();
                    
                }

            } while (c);
        }

        public void UsuarioControleEstacionamento()
        {
            bool c = true;
            do
            {
                Console.Clear();
                string user = "elton";
                string senha = "1234";

                string user2 = "porteiro";
                string senha2 = "porteiro";


                Console.Write("Usuário: ");
                string u = Console.ReadLine();
                Console.Write("Senha: ");
                string s = Console.ReadLine();
                
                if (u == user && s == senha || u == user2 && s == senha2)
                {
                    c = false;
                }
                else
                {
                    Console.Write("Usuário ou senha incorreto!");
                    Console.ReadLine();
                }

            } while (c);

        }

        public void TelaInicialCadastro()
        {
            
            bool c = true;
            int x;
            do
            {
                try
                {                    
                    Console.Clear();

                    Console.WriteLine("[1] Cadastrar Veículo \n[2] Consultar Veículo\n[3] Tela Inicial");
                    x = int.Parse(Console.ReadLine());

                    if (x < 1 || x > 3)
                    {
                        Console.WriteLine("Opção inválida! 3");
                        Console.ReadLine();
                    }
                    else
                    {
                        switch (x)
                        {
                            case 3:
                                c = false;
                                //Environment.Exit(0);
                                break;
                            case 1:
                                ConsultarAluno();
                                break;
                            case 2:
                                ConsultarVeiculo();
                                break;                            
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Opção inválida! 4");
                    Console.ReadLine();                    
                }

            } while (c);
        }

        public void ConsultarAluno()
        {
            Console.Clear();

            bool c = true;
            int x;
            do
            {
                try
                {                    
                    Console.Clear();

                    Console.WriteLine("Deseja consultar por qual opção: ");
                    Console.WriteLine("[1] Nome \n[2] CPF \n[3] Matricula");
                    x = int.Parse(Console.ReadLine());

                    if (x < 1 || x > 3)
                    {
                        Console.WriteLine("Opção inválida! 5");
                        Console.ReadLine();
                    }
                    else
                    {
                        switch (x)
                        {
                            case 1:
                                ConsultarNome(alunos);
                                c = false;
                                break;
                            case 2:
                                ConsultarCPF(alunos);
                                c = false;
                                break;
                            case 3:
                                ConsultarMatricula(alunos);
                                c = false;
                                break;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Opção inválida! 6");
                    Console.ReadLine();                    
                }

            } while (c);

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


        public void ConsultarVeiculo()
        {
            Console.Clear();

            Console.Write("Informe a placa a ser consultada: ");
            string placa = Console.ReadLine();

            foreach (Aluno a in alunos)
            {
                if (placa.ToUpper() == a.Veiculo.Placa.ToUpper())
                {
                    Console.WriteLine("Veículo Cadastrado! \n");
                    Console.WriteLine(a);
                    Console.ReadLine();                    
                    return;
                }

            }

            Console.WriteLine("Veículo não é cadastrado!");
            Console.ReadLine();            
        }


        //-----------------------------------------------------------------------------------------------------//

        int vagas = 3;
        List<string> veiculosEstacionados = new List<string>();

        public void TelaInicialConsulta()
        {
            bool c = true;
            int x;
            do
            {
                //CORRIGIR A ENTRADA REPETIDA e mostrar todos os dados do aluno + veiculo. => ok
                //pensar numa melhoria de incluir a data e hora da entrada.
                //mesmo após a saída pensar em armazenar num outro banco de dados que ficaria com o histórico por 30 dias...
                //confirmar funcionamento do programa em chamar as funcções ao fim de alguns métodos, isso seria ruim?
                //colocar uma variável para ir somando os numeros dos erros

                try
                {
                    Console.Clear();

                    Console.WriteLine("VAGAS DISPONÍVEIS: " + vagas);
                    Console.WriteLine("\n[1] Entrada \n[2] Saída \n[3] Visualizar Veiculos Estacionados \n[4] Fechar Programa");
                    x = int.Parse(Console.ReadLine());

                    if (x < 1 || x > 4)
                    {
                        Console.WriteLine("OPÇÃO INVÁLIDA! 13");
                        Console.ReadLine();
                    }
                    else
                    {
                        switch (x)
                        {
                            case 4:
                                c = false;
                                break;

                            case 1:
                                Entrada();
                                break;

                            case 2:
                                Saida();
                                break;

                            case 3:
                                Estacionados();
                                break;
                        }
                    }                    
                }
                catch (Exception)
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA! 14");
                    Console.ReadLine();
                }

            } while (c);
        }

        public void Entrada()
        {
            bool c = true;
            int x;

            if (vagas == 0)
            {
                Console.WriteLine("Limite de vagas esgotado! \nAguardar saída de veículos!");
                Console.ReadLine();
            }
            else
            {
                do
                {
                    try
                    {
                        Console.Clear();

                        Console.WriteLine("\nEscolha a opção de consulta: ");
                        Console.WriteLine("\n[1] Placa \n[2] Nome");
                        x = int.Parse(Console.ReadLine());

                        if( x < 1 || x > 2)
                        {
                            Console.WriteLine("OPÇÃO INVÁLIDA! 15");
                            Console.ReadLine();
                            c = false;
                        }

                       else if (x == 1)
                        {
                            Console.Write("\nInforme a Placa do veículo: ");
                            string placa = Console.ReadLine().ToUpper();

                            bool v = ConfirmarPlaca(placa, alunos);
                            bool e = EstaEstacionadoPlaca(placa, alunos, veiculosEstacionados);

                            if (!v)
                            {
                                Console.WriteLine("\nVeículo não cadastrado, aluno deve porcurar o setor de cadastro de veículos!\nENTRADA NÃO AUTORIZADA ");
                                Console.ReadLine();
                                c = false;
                            }
                            else if (e)
                            {
                                Console.WriteLine("\nAluno se encontra 'estacionado' com outro veículo ou alguém com o veículo do Aluno entrou no estacionamento! !! \nENTRADA NÃO AUTORIZADA");
                                Console.ReadLine();
                                c = false;
                            }
                            else
                            {
                                veiculosEstacionados.Add(placa);
                                vagas--;
                                Console.WriteLine("\nENTRADA AUTORIZADA! ");
                                Console.ReadLine();
                                c = false;
                            }

                        }

                        else if (x == 2)
                        {

                            Console.Write("\nInforme o nome do aluno: ");
                            string nome = Console.ReadLine().ToUpper();

                            bool v = ConfirmarAluno(nome, alunos);
                            bool e = EstaEstacionadoNome(nome, alunos, veiculosEstacionados);

                            if (!v)
                            {
                                Console.WriteLine("\nAluno não cadastrado!! \nENTRADA NÃO AUTORIZADA");
                                Console.ReadLine();
                                c = false;
                            }
                            else if (e)
                            {
                                Console.WriteLine("\nAluno se encontra 'estacionado' com outro veículo ou alguém com o veículo do Aluno entrou no estacionamento! !! \nENTRADA NÃO AUTORIZADA");
                                Console.ReadLine();
                                c = false;
                            }
                            else
                            {
                                veiculosEstacionados.Add(nome);
                                vagas--;
                                Console.WriteLine("\nENTRADA AUTORIZADA! ");
                                Console.ReadLine();                                                    
                                c = false;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("OPÇÃO INVÁLIDA! 16");
                        Console.ReadLine();
                    }

                } while (c);
            }
        }

        public void Saida()
        {
            bool c = true;
            int x = 0;
            do
            {
                try
                {

                    Console.WriteLine("\nEscolha a opção de consulta: ");
                    Console.WriteLine("\n[1] Placa \n[2] Nome");
                    x = int.Parse(Console.ReadLine());

                    if(x < 1 || x > 2)
                    {
                        Console.WriteLine("OPÇÃO INVÁLIDA! 17");
                        Console.ReadLine();
                        c = false;
                    }

                    else if (x == 1)
                    {
                        Console.Write("\nInforme a Placa do veículo: ");
                        string placa = Console.ReadLine().ToUpper();

                        bool v = ConfirmarPlacaSaida(placa, veiculosEstacionados);
                        
                        if (!v)
                        {
                            Console.WriteLine("\nPlaca não encontrada \nSAÍDA NÃO AUTORIZADA ");
                            Console.ReadLine();
                            c = false;
                        }
                        else
                        {                            
                            veiculosEstacionados.Remove(placa);
                            vagas++;
                            c = false;
                        }
                    }

                    else if (x == 2)
                    {

                        Console.Write("\nInforme o nome do aluno: ");
                        string nome = Console.ReadLine();

                        bool v = ConfirmarAlunoSaida(nome, veiculosEstacionados);

                        if (!v)
                        {
                            Console.WriteLine("\nNome não encontrado! \nSAÍDA NÃO AUTORIZADA");
                            Console.ReadLine();
                            c = false;
                        }

                        else
                        {                            
                            veiculosEstacionados.Remove(nome);
                            vagas++;
                            c = false;
                        }
                    }                   
                }
                catch (Exception)
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA! 18");
                    Console.ReadLine();
                }

            } while (c);

        }


        public void Estacionados()
        {

            Console.Clear();

            foreach (string list in veiculosEstacionados)
            {
                Console.WriteLine(list);
            }

            Console.ReadLine();
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

            return false;
        }

        public bool EstaEstacionadoNome(string nome, List<Aluno> alunos, List<string> veiculosEstacionados)
        {
            foreach(Aluno a in alunos)
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
    }
}