using PBL_06.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_06.Domain
{
    public class Camisa : Roupa
    {
        public Camisa(string tamanho, string cor, string marca, string nome) : base(tamanho, cor, marca, nome)
        {
        }

        public override float calcularPrecoFinal(float acrescimo)
        {
            return (getPreco() + acrescimo) * 0.8f;
        }

    }
}
