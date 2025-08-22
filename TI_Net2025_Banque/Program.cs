
using TI_Net2025_Banque.Models;

Personne albert = new Personne()
{
    Nom = "L'ancien",
    Prenom = "Albert",
    Ddn = new DateTime(1723,6,2),
};

Personne philippe = new Personne("Le roi","Philippe",new DateTime(1812,2,6));

Courant compteAlbert = new Courant("123",10000,5000,albert);
compteAlbert.LigneDeCredit = -5000;

Courant comptePhilippe = new Courant("456",20000,10000,philippe);

compteAlbert.Depot(10000);
comptePhilippe.Retrait(40000);

Banque belfius = new Banque("Belfius");

belfius.AjouterCompte(compteAlbert);
belfius.AjouterCompte(comptePhilippe);

Console.WriteLine(belfius["123"].Titulaire.Prenom);

