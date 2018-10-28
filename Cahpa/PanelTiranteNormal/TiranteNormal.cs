using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cahpa.PanelTiranteNormal
{ 
    class TiranteNormal
    {
        private Double n, Q, b, s;

        public TiranteNormal(double n,double Q,double b,double s)
        {
            this.b = b;
            this.n = n;
            this.Q = Q;
            this.s = s;
        }

        public TiranteNormal(){;}

        public double tiranteNormalRectangular()
        {
            int i = 0;
            double y = 0;
            double y1 = 1;
            double error = y1 - y;

            while(error!=0 && i < 100)
            {
                i++;
                double resultado= Math.Pow((n * Q * Math.Pow(b + 2 * y1, 0.666666666666)) / (Math.Pow(b, 1.6666666666666) * Math.Pow(s, 0.5)), 0.6);
                y = resultado;

                if (error == 0)
                {
                    Console.WriteLine("Aproximacion Optmima: "+y);
                    break;
                }else
                {
                    y1 = y;
                    if (i > 100)
                    {
                        break;
                    }
                }
            }
            return y;
        }
    }
}
