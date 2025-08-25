using System;
using System.Collections.Generic;
namespace TI_Net2025_Banque.Models
{
    public class Epargne: Compte
    {
        private DateTime _dateDernierRetrait;

        public Epargne() { }

        public Epargne(string numero, long solde, Personne titulaire) : base(numero, solde, titulaire)
        {
        }

        public DateTime DateDernierRetrait
        {
            get
            {
                return _dateDernierRetrait;
            }
            set
            {
                _dateDernierRetrait = value;
            }
        }

        public override void Retrait(long montant)
        {
            if (Solde < montant)
            {
                Console.WriteLine("Solde insufisant");
                return;
            }
            DateDernierRetrait = DateTime.Now;
            base.Retrait(montant);
        }
    }
}
