using ControleDeEstacionamento.Alunos;
using ControleDeEstacionamento.Menus;
using System;
using System.Collections.Generic;

namespace ControleDeEstacionamento
{
    class Program
    {
        //alt+63 (?) e alt+92 (\)

        static void Main(string[] args)
        {
            //Login l = new Login();
            //l.Usuario();
            
            Menu m = new Menu();
            m.Login();
            /*
            List<Aluno> alunos = new List<Aluno>();
            Veiculo veiculo;
            Veiculo padrao = new Veiculo(null, null,   );

            alunos.Add(new Aluno("Elton", "08251920485", "2009108453", "Programacao", "1º", veiculo = new Veiculo("PFX5107", "FORD", "FIESTA")));
            alunos.Add(new Aluno("Brivaldo", "15008673491", "2009108450", "Contabilidade", "8º", padrao));
            alunos.Add(new Aluno("Everton", "1234567890", "2009108320", "Engenharia", "10º", padrao));
            alunos.Add(new Aluno("Paulo", "1345173491", "2009112450", "Nutricao", "5º", padrao));
            alunos.Add(new Aluno("Amanda", "1531233491", "20429108450", "Direito", "3º", padrao));
            */

            /*
            int x;
            do
            {
                Console.Clear();

                Console.WriteLine("Deseja entrar em: \n\n[1] Sistema de Cadastro \n[2] Sistema de Controle de Entrada e Saída \n[3] Fechar Programa");
                x = int.Parse(Console.ReadLine());

                if (x == 3)
                    Environment.Exit(0);

                else if (x == 1)
                {
                    m.TelaInicialCadastro();
                }
                else if (x ==2)
                {
                    m.UsuarioControleEstacionamento();
                    m.TelaInicialConsulta();

                }

                Console.WriteLine("\nOpção Inválida!");
                Console.ReadLine();

            } while (x < 1 || x > 3);
            */
            //criar o controle do estacionamento.   
        }
    }
}