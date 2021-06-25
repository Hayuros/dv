using System;

namespace Model
{
    public class Veiculo
    {
        public string Marca { set; get; }

        public string Modelo { set; get; }

        public int Ano { set; get; }

        public double Preco { set; get; }

        protected Veiculo(string Marca, string Modelo, int Ano, double Preco)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Ano = Ano;
            this.Preco = Preco;
        }

        public override string ToString()
        {
            return "\nMarca:" + this.Marca +
            "\nModelo:" + this.Modelo +
            "\nAno:" + this.Ano +
            "\nPreço:" + String.Format("{0:c}", this.Preco);
        }
    }
}
