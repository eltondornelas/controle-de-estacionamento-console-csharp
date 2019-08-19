using System;
using System.Collections.Generic;
using System.Text;

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
            if (Veiculo.Placa == null)
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


    }
}