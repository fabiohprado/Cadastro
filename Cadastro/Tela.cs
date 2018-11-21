using System;

namespace Cadastro
{
    class Tela
    {
        public string nome { get; set; }
        public double cpf { get; set; }
        public string endereco { get; set; }

        public Tela(string nome, double cpf, string endereco)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;

        }

        public override string ToString()
        {
            return "Nome: "
                + nome
                + ", CPF: "
                + cpf
                + ", Endereco: "
                + endereco;
        }

    }
}
