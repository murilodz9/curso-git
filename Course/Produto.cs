using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    public class Produto
    {
        //public string Nome;
        //public double Preco;
        //public int Quantidade;

        //private string _nome;
        //private double _preco;
        //private int _quantidade;

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        public Produto()
        {
            Quantidade = 10;
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

        //public string GetName()
        //{
        //    return _nome;
        //}

        //public void SetNome(string nome)
        //{
        //    if (nome != null && nome.Length > 1)
        //    {
        //        _nome = nome;
        //    }
        //}

        //public double Preco
        //{
        //    get { return _preco; }
        //}

        //public double GetPreco()
        //{
        //    return _preco;
        //}

        //public int Quantidade
        //{
        //    get { return _quantidade; }
        //}

        //public int GetQuantidade()
        //{
        //    return _quantidade;
        //}

        public double ValorTotalEMEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEMEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
