using System;
using System.Collections.Generic;
using System.Text;
using ControleDeEstacionamento.Menus;


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

        public bool Comparar(Aluno aluno, string nome)
        {
            return aluno.Nome == nome;
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

        /*
        public void ConsultarAluno(List<Aluno> alunos)
        {
            Console.Clear();

            Console.WriteLine("Deseja consultar por qual opção: ");
            Console.WriteLine("[1] Nome \n[2] CPF \n[3] Matricula");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    ConsultarNome(alunos);
                    break;
                case 2:
                    ConsultarCPF(alunos);
                    break;
                case 3:
                    ConsultarMatricula(alunos);
                    break;
            }

        }

        public void ConsultarNome(List<Aluno> alunos)
        {
            Console.Clear();

            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();

            foreach (Aluno a in alunos)
                if (a.Nome == nome)
                {                  
                    Console.WriteLine("Aluno é Cadastrado!");
                    Console.WriteLine();
                    cv.CadastrarVeiculo(a);
                    m.TelaInicialCadastro();
                    return;
                }

            Console.WriteLine("Aluno NÃO Cadastrado!");
            Console.ReadLine();
            m.TelaInicialCadastro();
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
                    Console.WriteLine();
                    cv.CadastrarVeiculo(a);
                    return;
                }

            Console.WriteLine("Aluno NÃO Cadastrado!");
            Console.ReadLine();
            m.TelaInicialCadastro();

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
                    Console.WriteLine();
                    cv.CadastrarVeiculo(a);
                    return;
                }

            Console.WriteLine("Aluno NÃO Cadastrado!");
            Console.ReadLine();
            m.TelaInicialCadastro();
        }

    */
    }
}