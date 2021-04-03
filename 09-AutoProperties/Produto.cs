using System;
using System.Collections.Generic;
using System.Text;

namespace _09_AutoProperties
{
    class Produto
    {

        private string _nome;
        public double Preco { get; private set; }
        public double Quantidade { get; set; }
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
    }
}
