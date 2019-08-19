using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeEstacionamento.Menus
{
    class Login
    {
        public void Usuario() //futuramente terá que criar dois usuários: para cadastro e para consulta.
        {
            bool c = false;
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
        }

        public void UsuarioControleEstacionamento()
        {
            bool c = false;
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
                    c = true;
                }
                else
                {
                    Console.Write("Usuário ou senha incorreto!");
                    Console.ReadLine();
                }



            } while (!c);

        }
    }
}