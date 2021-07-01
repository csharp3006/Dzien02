using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Prostokat
    {
        // pola w klasie
        private double bokA;
        private double bokB;

        // pole publiczne
        protected double obwod;

        public Prostokat(double bokA, double bokB)
        {
            this.bokA = bokA;
            this.bokB = bokB;
        }

        public Prostokat(double bok)
        {
            bokA = bok;
            bokB = bok;
        }

        public double ObliczObwod()
        {
            return 2 * bokA + 2 * bokB;
        }

        public double ObliczPole()
        {
            return bokA * bokB;
        }

        public bool CzyKwadrat()
        {
            return bokA == bokB;
        }
    }
}
