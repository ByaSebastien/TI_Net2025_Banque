namespace TI_Net2025_Banque.Models
{
    public class Courant: Compte
    {
        private long _ligneDeCredit;

        public Courant() { }

        public Courant(string numero, long solde, long ligneDeCredit, Personne titulaire) : base(numero, solde, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
        }

        public long LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set 
            { 
                if(value < 0)
                {
                    Console.WriteLine("Impossible de set une valeur négative");
                    return;
                }
                _ligneDeCredit = value; 
            }
        }

        public override void Retrait(long montant)
        {
            if(Solde + LigneDeCredit < montant)
            {
                Console.WriteLine("Solde insufisant");
                return;
            }
            base.Retrait(montant);
        }
    }
}
