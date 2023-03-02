using Devops.Exercices.Boucles;
using Devops.Exercices.Collections;
using Devops.Exercices.Conditions;
using Devops.Exercices.Variables;
using Logique;


int choix = -1;
String entree = "";

ICommand[] exercices = new ICommand[]
{
    new Addition(),
    new NbPair(),
    new Division(),
    new BBAN(),
    new IBAN(),
    new Fibonacci(),
    new Factoriel(),
    new Multiplication(),
    new Incrementation(),
    new NbPremier(),
    new NbPremierCollection(),
    new NbPremierCollectionGenerique(),
    new DeplacementTableau2D(),
    new DeplacementAlternatif(),
};

do
{

    for (int i = 0; i < exercices.Length; i++)
    {
        Console.WriteLine("{0,2} {1}", i + 1, exercices[i].Name);
    }
    Console.WriteLine("{0,2} {1}", 'q', "Quitter");
    Console.WriteLine("--------------");
    Console.Write("choix : ");
    entree = Console.ReadLine();

    if (Int32.TryParse(entree, out choix))
    {
        Console.Clear();
        try
        {
            if (choix > 0 && choix <= exercices.Length)
            {
                exercices[choix - 1].Execute();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        Console.ReadKey();
        Console.Clear();

    }
} while (entree != "q");