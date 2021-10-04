using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class CompteB { 
        private float  Solde = 0;
        private string titulaire;
        private string devise;
        private int Nbcompte;
        private static int UnNombreCompte = 0; 


        //CONSTRUCTOR
        public CompteB(float Unsolde, string Untitulaire, string Unedevise, int UnNbcompte)
        {
            this.Solde = Unsolde;
            this.titulaire = Untitulaire;
            this.devise = Unedevise;
            this.Nbcompte = UnNombreCompte;
            CompteB.UnNombreCompte ++,;
        }

        public CompteB(string Untitulaire, string Unedevise, int UnNbcompte)
        {
            this.Solde = 0;
            this.titulaire = Untitulaire;
            this.devise = Unedevise;
            this.Nbcompte = UnNbcompte;
        }

        //SETTERS
        public void SetSolde(float Unsolde)
        {
            this.Solde = Unsolde;
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
        public float GetSolde()
        {
            return this.Solde;
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

        public float ConsulterSolde()
        {
            return this.Solde;
        }
        public void Crediter(int UnMontant)
        {
            this.Solde = this.Solde + UnMontant;
        }
        public void Debiter(int UnMontant)
        {
            this.Solde = this.Solde + UnMontant;
        }

    }
}
