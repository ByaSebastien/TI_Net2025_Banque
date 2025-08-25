
using System.Threading.Channels;
using TI_Net2025_Banque;
using TI_Net2025_Banque.Models;

Personne albert = new Personne()
{
    Nom = "L'ancien",
    Prenom = "Albert",
    Ddn = new DateTime(1723,6,2),
};

Personne philippe = new Personne("Le roi","Philippe",new DateTime(1812,2,6));

Courant compteAlbert = new Courant("123",10000,5000,albert);

Courant comptePhilippe = new Courant("456",20000,10000,philippe);


Banque belfius = new Banque("Belfius");

belfius.AjouterCompte(compteAlbert);
belfius.AjouterCompte(comptePhilippe);

belfius["456"].Retrait(25000);

DemoDelegate demoDelegate = new DemoDelegate();

List<int> ints = new List<int>()
{
    1,2,3,4,5,6,7,8,9,
};

//ints.Where(nb => nb % 2 == 0).ToList().ForEach(Console.WriteLine);

ints.Take(5).Select(nb => nb * 2).ToList().ForEach(Console.WriteLine);

