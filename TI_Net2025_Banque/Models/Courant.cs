namespace TI_Net2025_Banque.Models
{
    public class Courant
    {
        private string _numero;
        private long _solde;
        private long _ligneDeCredit;
        private Personne _titulaire;

        public Courant() { }

        public Courant(string numero, long solde, long ligneDeCredit, Personne titulaire)
        {
            Numero = numero;
            Solde = solde;
            LigneDeCredit = ligneDeCredit;
            Titulaire = titulaire;
        }

        public string Numero { 
            get{ return _numero; }
            set{ _numero = value; }
        }

        public long Solde
        {
            get { return _solde; }
            private set { _solde = value; }
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

        public Personne Titulaire
        {
            get { return _titulaire; }
            set { _titulaire = value; }
        }

        public void Depot(long montant)
        {
            if(montant < 0)
            {
                Console.WriteLine("Montant négatif");
                return;
            }

            //Solde = Solde + montant;
            Solde += montant;
        }

        public void Retrait(long montant)
        {
            if (montant < 0)
            {
                Console.WriteLine("Montant négatif");
                return;
            }
            if(Solde + LigneDeCredit < montant)
            {
                Console.WriteLine("Solde insufisant");
                return;
            }
            Solde -= montant;
        }
    }
}
