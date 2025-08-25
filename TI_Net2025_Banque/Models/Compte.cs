
namespace TI_Net2025_Banque.Models
{
    public abstract class Compte
    {
        private event Action<Compte> passageEnNegatifEvent; 

        private string _numero;
        private long _solde;
        private Personne _titulaire;

        public Compte() { }

        public Compte(string numero, long solde, Personne titulaire)
        {
            Numero = numero;
            Solde = solde;
            Titulaire = titulaire;
        }

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public long Solde
        {
            get { return _solde; }
            private set 
            { 
                if(_solde >= 0 && value < 0)
                {
                    RaisePassageEnNegatifEvent();
                }
                _solde = value; 
            }
        }

        public Personne Titulaire
        {
            get { return _titulaire; }
            set { _titulaire = value; }
        }

        public void Depot(long montant)
        {
            if (montant < 0)
            {
                Console.WriteLine("Montant négatif");
                return;
            }

            //Solde = Solde + montant;
            Solde += montant;
        }

        public virtual void Retrait(long montant)
        {
            if (montant < 0)
            {
                Console.WriteLine("Montant négatif");
                return;
            }
            Solde -= montant;
        }

        public static long operator +(Compte c1 , Compte c2)
        {
            return c1.Solde + c2.Solde;
        }

        public static bool operator ==(Compte c1, Compte c2)
        {
            return c1.Numero == c2.Numero;
        }

        public static bool operator !=(Compte c1, Compte c2)
        {
            return !(c1 == c2);
        }

        public void RaisePassageEnNegatifEvent()
        {
            passageEnNegatifEvent?.Invoke(this);
        }

        public void SubscribePassageEnNegatifEvent(Action<Compte> action)
        {
            passageEnNegatifEvent += action;
        }
    }
}
