using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace exercicio7_classes
{
    internal class Filme
    {
        private string _titulo;
        private string _genero;
        private int _duracaoMinutos;
        private int _classificacao;
        public string Titulo
        {
            get { return _titulo; } 
            set { _titulo = value; }
        }
        public string Genero
        {
            get { return _genero; }
            set { _genero = value; } 
        }
        public int DuracaoMinutos
        {
            get { return _duracaoMinutos; }
            set { _duracaoMinutos = value; }
        }
        public int Classificacao
        {
            get { return _classificacao; }
            set { _classificacao = value; }
        }
        public Filme(string titulo, string genero, int duracaoMinutos, int classificacao)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentException("O Título não pode ficar vazio.");
            else
                _titulo = titulo;
            _genero = string.IsNullOrWhiteSpace(genero) ? "Não informado" : genero;
            _duracaoMinutos = duracaoMinutos <= 0 ? 1 : duracaoMinutos;
            _classificacao = classificacao < 0 ? 0 : classificacao;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {_titulo}");
            Console.WriteLine($"Gênero: {_genero}");
            Console.WriteLine($"Duração: {_duracaoMinutos} minutos");
            Console.WriteLine($"Classificação: {_classificacao} anos");
        }
        public bool EhpermitidoParaIdade(int idade)
        {
            if (idade < 0)
                throw new ArgumentException("A idade não pode ser negativa.");
            return idade >= _classificacao;
        }
        public void AlterarDuracao(int novaDuracao)
        {
            if (novaDuracao <= 0)
                throw new ArgumentException("A duração deve ser um número positivo.");
            _duracaoMinutos = novaDuracao;
        }
        public void ExibirResumo()
        {
            Console.WriteLine($"{_titulo} - {_genero} - {_duracaoMinutos} minutos - Classificação: {_classificacao} Anos");
        }

    }
}
