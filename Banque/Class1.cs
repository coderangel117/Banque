using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class CompteE{
        private int TauxInteret;
        private int solde;
        public CompteE(int UnTauxInteret, int Unsolde)
        {
            TauxInteret = UnTauxInteret;
            solde = Unsolde;
        }
        CompteE(int UnTauxInteret)
        {
            TauxInteret = UnTauxInteret;
            
        }
        public int CalculInteret()
        {
            return solde * TauxInteret;
        }
    }
}
