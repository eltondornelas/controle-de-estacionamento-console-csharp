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
            Login l = new Login();
            l.Usuario();

            Menu m = new Menu();

            Console.WriteLine("Deseja entrar em: \n\n[1] Sistema de Cadastro \n[2] Sistema de Controle de Entrada e Saída");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                m.TelaInicialCadastro();
            }
            else
            {
                l.UsuarioControleEstacionamento();
                m.TelaInicialConsulta();

            }
            //criar o controle do estacionamento.   
        }
    }
}