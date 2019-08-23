using System;
using System.Collections.Generic;

namespace ControleDeEstacionamento.Alunos
{
    class Veiculo
    {
        public string Placa { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }

        public Veiculo()
        {

        }

        public Veiculo(string placa, string fabricante, string modelo)
        {
            Placa = placa;
            Fabricante = fabricante;
            Modelo = modelo;
        }

        public void ConsultarVeiculo(List<Aluno> alunos)
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

    }
}