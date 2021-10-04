using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class CompteE{
        private float TauxInteret;
        private float solde;
        public CompteE(float UnTauxInteret, float Unsolde)
        {
            TauxInteret = UnTauxInteret;
            solde = Unsolde;
        }
        CompteE(float UnTauxInteret)
        {
            TauxInteret = UnTauxInteret;
            
        }
        public float CalculInteret()
        {
            return solde * TauxInteret;
        }
    }
}
