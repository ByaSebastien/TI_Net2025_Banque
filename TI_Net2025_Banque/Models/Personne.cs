namespace TI_Net2025_Banque.Models
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Ddn { get; set; }

        public Personne() { }

        public Personne(string nom, string prenom, DateTime ddn)
        {
            Nom = nom;
            Prenom = prenom;
            Ddn = ddn;
        }
    }
}
