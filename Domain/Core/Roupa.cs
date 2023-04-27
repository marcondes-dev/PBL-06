using PBL_06.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_06.Domain.Core
{
    public abstract class Roupa : IProduto
    {

        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public float Preco { get; private set; }
        public string Nome { get; set; }

        public Roupa( string tamanho, string cor, string marca, string nome)
        {
            Tamanho = tamanho;  
            Cor = cor;
            Marca = marca;
            Nome = nome;
        }
        public string getMarca()
        {
            return Marca;
        }

        public string getNome()
        {
            return Nome;
        }
        public float getPreco()
        {
            return Preco;
        }

        public  void setPreco(float preco)
        {
            this.Preco = preco;
        }

        public abstract float calcularPrecoFinal(float acrescimo);
    }
}
