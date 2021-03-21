using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class MAD
    {
        private double valeur;
        public MAD(double v)
        {
            this.valeur = v;
        }
        public override string ToString()
        {
            return valeur + " MAD";
        }
        public static MAD operator+(MAD M1,MAD M2)
        {

            return new MAD(M1.valeur + M2.valeur);
        }
        public static MAD operator -(MAD M1, MAD M2)
        {

            return new MAD(M1.valeur - M2.valeur);
        }
        public static bool  operator>(MAD M1, MAD M2)
        {

            return (M1.valeur - M2.valeur)>0 ? true :false;
        }
        public static bool operator <(MAD M1, MAD M2)
        {

            return (M1.valeur - M2.valeur) < 0 ? true : false;
        }
        public static bool operator >=(MAD M1, MAD M2)
        {

            return (M1.valeur - M2.valeur) >= 0 ? true : false;
        }
        public static bool operator <=(MAD M1, MAD M2)
        {

            return (M1.valeur - M2.valeur) <= 0 ? true : false;
        }
        public static MAD operator *(MAD M1, MAD M2)
        {

            return new MAD(M1.valeur * M2.valeur);
        }
        public static MAD operator /(MAD M1, MAD M2)
        {

            return new MAD(M1.valeur / M2.valeur);
        }
    }
}
