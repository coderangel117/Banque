using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class CompteE  {
        private double TauxInteret;
        private double Solde;
        public CompteE (double UnTauxInteret, double UnSolde)
        {
            this.Solde = UnSolde;
            TauxInteret = UnTauxInteret;
        }
        CompteE(double UnTauxInteret)
        {
            TauxInteret = UnTauxInteret;
        }
        public double CalculInteretAnnuel()
        {
            return Solde * TauxInteret;
        }
    }
}
