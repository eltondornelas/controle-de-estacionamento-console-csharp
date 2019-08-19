using System;
using System.Collections.Generic;
using System.Text;
using ControleDeEstacionamento.Menus;

namespace ControleDeEstacionamento.Alunos
{
    class ControleVeiculos
    {
        Menu m = new Menu();

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
                    m.TelaInicialCadastro();
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

                    m.TelaInicialCadastro();

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
                        m.TelaInicialCadastro();
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

            m.TelaInicialCadastro();
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
                m.TelaInicialCadastro();
            }
            else
            {
                aluno.Veiculo.Placa = null;
                aluno.Veiculo.Fabricante = null;
                aluno.Veiculo.Modelo = null;

                Console.WriteLine("\nOPERAÇÃO REALIZADA COM SUCESSO! ");
                Console.ReadLine();

                m.TelaInicialCadastro();
            }
        }
    }
}