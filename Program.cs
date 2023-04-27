using PBL_06.Domain;

namespace PBL_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calca calca = new Calca("M", "Preta", "Growth", "Treino Hardcore");
            calca.setPreco(45f);
            Console.WriteLine(calca.calcularPrecoFinal(5f));

            Vestido vestido = new Vestido("P", "Vermelho", "Fendi", "Vestido sexy rs");
            vestido.setPreco(45f);
            Console.WriteLine(vestido.calcularPrecoFinal(5f));

            Camisa camisa = new Camisa("M", "Branca", "Lacoste", "MD Chef");
            camisa.setPreco(45f);
            Console.WriteLine(camisa.calcularPrecoFinal(5f));
        }
    }
}