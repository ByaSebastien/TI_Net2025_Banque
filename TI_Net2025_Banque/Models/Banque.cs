namespace TI_Net2025_Banque.Models
{
    public class Banque
    {
        private List<Compte> _comptes;
        public string Nom {  get; init; }

        public Banque(string nom)
        {
            Nom = nom;
        }

        public List<Compte> Comptes {
            get
            {
                if (_comptes == null)
                {
                    _comptes = new List<Compte>();
                }
                return _comptes;
                //return _comptes ??= new List<Compte>();
            }
        }

        public void AjouterCompte(Compte compte)
        {
            if(compte is Courant)
            {
                compte.SubscribePassageEnNegatifEvent(PassageEnNegatifAction);
            }
            Comptes.Add(compte);
        }

        public Compte this[string numero]
        {
            get
            {
                foreach (Compte c in Comptes)
                {
                    if (c.Numero == numero)
                    {
                        return c;
                    }
                    c.Retrait(100);
                }
                return null;

                //return Comptes.FirstOrDefault(c => c.Numero == numero);
            }
        }

        private void PassageEnNegatifAction(Compte c)
        {
            Console.WriteLine($"{Nom} : Le compte numéro {c.Numero} vient de passer en négatif");
        }
    }
}
