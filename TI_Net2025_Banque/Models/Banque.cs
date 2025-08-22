namespace TI_Net2025_Banque.Models
{
    public class Banque
    {
        private List<Courant> _comptes;
        public string Nom {  get; init; }

        public Banque(string nom)
        {
            Nom = nom;
        }

        public List<Courant> Comptes {
            get
            {
                if(_comptes == null)
                {
                    _comptes = new List<Courant>();
                }
                return _comptes;
                //return _comptes ??= new List<Courant>();
            }
        }

        public void AjouterCompte(Courant compte)
        {
            Comptes.Add(compte);
        }

        public Courant this[string numero]
        {
            get
            {
                foreach (Courant c in Comptes)
                {
                    if (c.Numero == numero)
                    {
                        return c;
                    }
                }
                return null;

                //return Comptes.FirstOrDefault(c => c.Numero == numero);
            }
        }
    }
}
