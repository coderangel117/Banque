using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class CompteE{
        private int TauxInteret;
        private int solde;
        CompteE(int UnTauxInteret, int Unsolde)
        {
            TauxInteret = UnTauxInteret;
            solde = Unsolde;
        }
        public int CalculInteret()
        {
            return solde * TauxInteret;
        }
    }
}
