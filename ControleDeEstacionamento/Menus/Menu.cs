using System;
using System.Collections.Generic;
using ControleDeEstacionamento.Alunos;
using ControleDeEstacionamento.Parking;

namespace ControleDeEstacionamento.Menus
{
    class Menu
    {
        List<Aluno> alunos = new List<Aluno>();
        Aluno A = new Aluno();
        Veiculo V = new Veiculo();       

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
                                V.ConsultarVeiculo(alunos);
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
                                A.ConsultarNome(alunos);
                                c = false;
                                break;
                            case 2:
                                A.ConsultarCPF(alunos);
                                c = false;
                                break;
                            case 3:
                                A.ConsultarMatricula(alunos);
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

        //------------------------------------------------------------------------------------------------------------------------//
        //trecho do código de verificação de entrada e saída de veículos

        int vagas = 3;
        List<string> veiculosEstacionados = new List<string>();
        Estacionamento park = new Estacionamento();

        public void TelaInicialConsulta()
        {
            bool c = true;
            int x;
            do
            {                   
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
                                park.Estacionados(veiculosEstacionados);
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
                            vagas = park.EntradaEstacionamentoPlaca(alunos, veiculosEstacionados, vagas);
                            c = false;                            
                        }

                        else if (x == 2)
                        {
                            vagas = park.EntradaEstacionamentoNome(alunos, veiculosEstacionados, vagas);
                            c = false;                            
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
                        vagas = park.SaidaEstacionamentoPlaca(veiculosEstacionados, vagas);
                        c = false;                        
                    }

                    else if (x == 2)
                    {
                        vagas = park.SaidaEstacionamentoNome(veiculosEstacionados, vagas);
                        c = false;                        
                    }                   
                }
                catch (Exception)
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA! 18");
                    Console.ReadLine();
                }

            } while (c);

        }             
    }
}