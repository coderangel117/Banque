using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class CompteB { 
        private int  solde;
        private string titulaire;
        private string devise;
        private int Nbcompte;


        //CONSTRUCTOR
        public CompteB(int Unsolde, string Untitulaire, string Unedevise, int UnNbcompte)
        {
            this.solde = Unsolde;
            this.titulaire = Untitulaire;
            this.devise = Unedevise;
            this.Nbcompte = UnNbcompte;
        }


        //SETTERS
        public void SetSolde(int Unsolde)
        {
            this.solde = Unsolde;
        }
        public void SetTitulaire(string UnTitulaire)
        {
            this.titulaire = UnTitulaire;
        }
        public void SetDevise(string UneDevise)
        {
            this.devise = UneDevise;

        }
        public void SetNBCompte(int UnNbCompte)
        {
            this.Nbcompte = UnNbCompte;

        }


        //GETTERS
        public int ConsulterSolde()
        {
            return this.solde;
        }
        public string GetTitulaire()
        {
            return this.titulaire;
        }
        public string GetDevise()
        {
            return this.devise;
        }
        public int GetNbCompte()
        {
            return this.Nbcompte;
        }


        //METHDOES
        public void Crediter(int UnMontant)
        {
            this.solde = this.solde + UnMontant;
        }
        public void Debiter(int UnMontant)
        {
            this.solde = this.solde + UnMontant;
        }

    }
}
