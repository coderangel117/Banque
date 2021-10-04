using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    public class CompteB { 
        private float  Solde = 0;
        private string titulaire;
        private string devise;
        private static int Nbcompte = 0;


        //CONSTRUCTOR
        public CompteB(float Unsolde, string Untitulaire, string Unedevise)
        {
            this.Solde = Unsolde;
            this.titulaire = Untitulaire;
            this.devise = Unedevise;
            CompteB.Nbcompte  ++;
        }

        public CompteB(string Untitulaire, string Unedevise)
        {
            this.Solde = 0;
            this.titulaire = Untitulaire;
            this.devise = Unedevise;
            CompteB.Nbcompte++;
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
        public static int GetNbCompte()
        {
            return CompteB.Nbcompte;
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
            this.Solde = this.Solde - UnMontant;
        }

    }
}
