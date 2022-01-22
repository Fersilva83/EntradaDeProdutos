using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return Nome 
               +" . $ "
             + Preco.ToString("F2", CultureInfo.InvariantCulture)
               + " , "
               + Quantidade
               + " unidade . total : $"
               + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }


    }
}
