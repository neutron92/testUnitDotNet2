using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice.inverseur
{
    public class InverseurTableauEntier
    {
        private int[] entiers;

        public InverseurTableauEntier( int[] entiers)
        {
            // Assigne l'argument à un membre privé
            // vérifier si l'argument est null (facultatif)
            if(entiers == null)
            {
                // lancer une exception ArgumentNullException
                throw new ArgumentNullException(nameof(entiers));
            }
            //Assigne l'argument à un membre privé
            this.entiers = entiers;
        }
        public int[] inverser()
        {

            int[] entiers1 = this.entiers;
            //Verifier si le tableau contien 0 ou 1 élément
            if (entiers1.Length<=1)
            {
                //si on a 0 ou 1 élément on retourne le même tableau
                return this.entiers;
            }
            // Déclarer un tableau pour la sortie
            // du même nombre d'éléments que e tableau d'entrée
            //int[] entiers2 = new int[this.entiers.Length];
            var entiers2 = new List<int>();
            // Boucle for 
            // Ou. utiliser une Liste<int> comme contenant pour l'inversion
            //for (int i = 0, j = this.entiers.Length-1; j>0; i++,j--)
            //{
            //    entiers2[i] = entiers[j];
            //}
            //return entiers2;
            //V2
            for (int i = this.entiers.Length -1; i >=0 ; i--)
            {
                entiers2.Add(entiers[i]);
            }

            return entiers2.ToArray();
        }
    }
}
