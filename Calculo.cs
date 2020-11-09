using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace POO_DolarComIOF
{
    class Calculo
    {
        public double CotDolar;
        public int QtdDolar;
        public double QtdReal;

        public double ValorCompra()
        {
            double totalDolar = QtdDolar * CotDolar;    //Valor sem IOF
            return totalDolar + totalDolar * 6 / 100.0;     //Valor com IOF
        }

        public override string ToString()
        {
            return QtdReal
                +" Valor a ser pago em Reais = "
                + ValorCompra().ToString("F2", CultureInfo.InvariantCulture);
        }

    }


}
    
