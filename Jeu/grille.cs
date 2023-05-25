using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
{
    public class Grille
    {
        private int Nb_Coups_Jouer = 0;
        private List<string> Nom_Joueurs = new List<string>();
        private int[,] grille;
        private int Lignes;
        private int Colonnes;
        private bool Tour;

        public Grille(int l, int c)
        {
            Lignes = l;
            Colonnes = c;
            Nom_Joueurs.Add("Alice"); Nom_Joueurs.Add("Connor");
            Tour = true;
            grille = new int[Lignes, Colonnes];
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; l++)
                {
                    grille[i, j] = 0;
                }
            }
        }
        public void ProchainTour()
        {
            Tour = !Tour;
        }
        public void pose_pion(int l, int c)
        {
            if (Tour)
            {
                grille[l, c] = 1;
            }
            else
            {
                grille[l, c] = 2;
            }
            Nb_Coups_Jouer += 1;
        }
        public int case_la_plus_basse(int c)
        {
            int l = -1;
            while (grille[l + 1, c] == 0 && l + 1 < Lignes - 1)
            {
                l += 1;
            }
            return l;
        }
        public int verification(int l, int c)
        {
            int k = 1;
            int Pion_Align = 1;
            int deb_L = l - 3;
            int fin_L = l + 3;
            int deb_C = c - 3;
            int fin_C = c + 3;

            if (deb_L < 0) { deb_L = 0; }
            if (deb_C < 0) { deb_C = 0; }
            if (fin_L > Lignes - 1) { fin_L = Lignes - 1; }
            if (fin_C > Colonnes - 1) { fin_C = Colonnes - 1; }

            if (l >= Lignes - 4)
            {
                if (grille[l, c] == grille[l - 1, c] && grille[l - 1, c] == grille[l - 2, c] && grille[l - 2, c] == grille[l - 3, c])
                {
                    return grille[l, c];
                }
            }

            while (c + k < fin_C && grille[l, c] == grille[l, c + k])
            {
                Pion_Align += 1;
                k += 1;
            }
            k = 1;
            while (c + k > deb_C && grille[l, c] == grille[l, c - k])
            {
                Pion_Align += 1;
                k += 1;
            }
            if (Pion_Align > 4)
            {
                return grille[l, c];
            }
            k = 1;
            Pion_Align = 1;

            while (c + k < fin_C && l - k > deb_L && grille[l, c] == grille[l - k, c + k])
            {
                Pion_Align += 1;
                k += 1;
            }
            k = 1;
            while (c - k < deb_C && l + k > fin_L && grille[l, c] == grille[l + k, c - k])
            {
                Pion_Align += 1;
                k += 1;
            }
            if (Pion_Align > 4)
            {
                return grille[l, c];
            }
            k = 1;
            Pion_Align = 1;
            while (c + k < fin_L && l - k > deb_C && grille[l, c] == grille[l - k, c + k])
            {
                Pion_Align += 1;
                k += 1;
            }
            k = 1;
            while (c - k < deb_L && l + k > fin_C && grille[l, c] == grille[l + k, c - k])
            {
                Pion_Align += 1;
                k += 1;
            }
            if (Pion_Align > 4)
            {
                return grille[l, c];
            }
            if (Nb_Coups_Jouer == Lignes * Colonnes)
            {
                return -1;
            }
            return 0;
        }
    }
}
