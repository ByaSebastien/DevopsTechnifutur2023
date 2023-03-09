using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Enums
{
    public class JeuDeCarte : ICommand
    {
        public string Name => "Jeu de cartes";

        public void Execute()
        {
            Carte[] cartes = new Carte[52];
            int i = 0;
            foreach(Couleurs c in Enum.GetValues<Couleurs>())
            {
                foreach(Valeurs v in Enum.GetValues<Valeurs>())
                {
                    cartes[i++] = new Carte(c, v);
                }
            }
            foreach(Carte c in cartes)
            {
                Console.WriteLine(c);
            }
        }
    }
    public enum Couleurs
    {
        Coeur,
        Carreau,
        Pique,
        Trefle,
    }
    public enum Valeurs
    {
        Deux = 2,
        Trois = 3,
        Quatre = 4,
        Cinq = 5,
        Six = 6,
        Sept = 7,
        Huit = 8,
        Neuf = 9,
        Dix = 10,
        Vallet = 11,
        Dame = 12,
        Roi = 13,
        As = 14,
    }
    public struct Carte
    {
        public Couleurs Couleur;
        public Valeurs Valeur;

        public Carte(Couleurs c,Valeurs v)
        {
            Couleur = c;
            Valeur = v;
        }

        public override string ToString()
        {
            return $"{Valeur} de {Couleur}";
        }
    }
}
