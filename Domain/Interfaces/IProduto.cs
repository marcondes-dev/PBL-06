using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_06.Domain.Interfaces
{
    public interface IProduto
    {
        string getNome();
        string getMarca();
        float getPreco();
        void setPreco(float preco);
    }
}
