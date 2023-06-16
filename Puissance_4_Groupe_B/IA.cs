using Jeu;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Puissance_4_Groupe_B
{
    internal class IA
    {

        Grille plateau;


        public IA(Grille grille)
        {
            plateau = grille;
        }

        // Update la grille 
        public void UpdateGrille(Grille grille)
        {
            plateau = grille;
        }

        public int JouerUnCoupFictif(int profondeur, bool JoueurActuel, int k,int evaluer)
        {
            int score = 0;
            int LigneChoisie;
            int PionIA;
            int meilleurScore = int.MinValue;
            int meilleurCoup = 0;


            if (JoueurActuel) { PionIA = 2; }else { PionIA = 1; }

            if (profondeur == 0 || evaluer == 4)
            {
                return k;
            }

            for (int i = 0; i < plateau.get_Colonnes(); i++)
            {
                if (plateau.case_basse[i] >= 0)
                {
                    LigneChoisie = plateau.case_la_plus_basse(i);
                    plateau.get_grille()[LigneChoisie, i] = PionIA;
                    score = plateau.verification(LigneChoisie, i);
                    JouerUnCoupFictif(profondeur - 1, !JoueurActuel, i, score);
                    plateau.get_grille()[LigneChoisie, i] = 0;
                    if (score > meilleurScore && plateau.case_la_plus_basse(i) != -1)
                    {
                        meilleurScore = score;
                        meilleurCoup = i;
                    }
                }
                else
                {
                    i++;
                }
            }
            return meilleurCoup;
        }
    } 


}
