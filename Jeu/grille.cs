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
        private int Nb_Joueurs = 1;
        private List<string> Nom_Joueurs = new List<string>();
        private int[,] grille;
        private int[] case_basse;
        private int Lignes;
        private int Colonnes;
        private bool Tour;
        private bool Partie_finie = false;

        public Grille(int l, int c)
        {
            Lignes = l-1;
            Colonnes = c-1;
            Nom_Joueurs.Add("Alice"); Nom_Joueurs.Add("Connor");
            Tour = true;
            grille = new int[l,c];
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    grille[i, j] = 0;
                }
            }
            case_basse = new int[c];
            for (int k = 0; k < c; k++)
            {
                case_basse[k] = Lignes;
            }
        }

        public int[,] get_grille()
        {
            return grille;
        }

        public void restart()
        {
            Nb_Coups_Jouer = 0;
            for (int i = 0; i < Lignes+1; i++)
            {
                for (int j = 0; j < Colonnes+1; j++)
                {
                    grille[i, j] = 0;
                }
            }
            for (int k = 0; k < Colonnes+1; k++)
            {
                case_basse[k] = Lignes;
            }
        }

        public bool get_est_fini()
        {
            return Partie_finie;
        }

        public void set_tour(bool y)
        {
            Tour = y;
        }
        public int get_Nb_Coup_Jouer()
        {
            return Nb_Coups_Jouer;
        }
        public int get_Lignes()
        {
            return Lignes;
        }
        public int get_Nb_Joueurs()
        {
            return Nb_Joueurs;
        }
        public int get_Colonnes()
        {
            return Colonnes;
        }
        public bool get_Tour()
        {
            return Tour;
        }
        public string get_NomJ1()
        {
            return Nom_Joueurs[0];
        }
        public string get_NomJ2()
        {
            return Nom_Joueurs[1];
        }
        //TEST

        public void update_NomJ(string Name1, string Name2)
        {
            if (Name1 != "")
            {
                Nom_Joueurs[0] = Name1;
            }
            if (Name2 != "")
            {
                Nom_Joueurs[1] = Name2;
            }
        }

        public void update_NbJ(int k)
        {
            Nb_Joueurs = k;
        }

        public void ProchainTour()
        {
            Tour = !Tour;
        }
        public void pose_pion(int c)
        {
            if (Tour)
            {
                grille[case_la_plus_basse(c), c] = 1;
            }
            else
            {
                grille[case_la_plus_basse(c), c] = 2;
            }
            Nb_Coups_Jouer += 1;
        }

        public int case_la_plus_basse(int c)
        {
            return case_basse[c];
        }

        public void update_case_basse(int c)
        {
            case_basse[c] -= 1;
        }

        public int verification(int l, int c)
        {
            int k = 1;
            int Pion_Align = 1;
            int deb_L = l - 3;
            int fin_L = l + 3;
            int deb_C = c - 3;
            int fin_C = c + 3;

            if (deb_L < 0)
            {
                deb_L = 0;
            }
            if (deb_C < 0)
            {
                deb_C = 0;
            }
            if (fin_L > Lignes)
            {
                fin_L = Lignes;
            }
            if (fin_C > Colonnes)
            {
                fin_C = Colonnes;
            }
            //Verification Verticale
            if (l <= Lignes - 3)
            {
                if (grille[l, c] == grille[l + 1, c] && grille[l + 1, c] == grille[l + 2, c] && grille[l + 2, c] == grille[l + 3, c])
                {
                    return 1;
                }
            }
            //Verification Horizontale
            while (c + k <= fin_C)
            {
                if (grille[l, c] == grille[l, c + k])
                {
                    Pion_Align += 1;
                    k += 1;
                }
                else
                {
                    k += 3;
                }
            }
            k = 1;
            while (c - k >= deb_C)
            {
                if (grille[l, c] == grille[l, c - k])
                {
                    Pion_Align += 1;
                    k += 1;
                }
                else
                {
                    k += 3;
                }
            }
            if (Pion_Align >= 4)
            {
                Partie_finie = true;
                return 1;
            }

            //Verification Oblique Montant

            k = 1;
            Pion_Align = 1;

            while (c + k <= fin_C && l - k >= deb_L)
            {
                if (grille[l, c] == grille[l - k, c + k])
                {
                    Pion_Align += 1;
                    k += 1;
                }
                else
                {
                    k += 3;
                }
            }
            k = 1;
            while (c - k >= deb_C && l + k <= fin_L)
            {
                if (grille[l, c] == grille[l + k, c - k])
                {
                    Pion_Align += 1;
                    k += 1;
                }
                else
                {
                    k += 3;
                }
            }
            if (Pion_Align >= 4)
            {
                Partie_finie = true;
                return 1;
            }

            //Verification Oblique Descendant

            k = 1;
            Pion_Align = 1;
            while (c - k >= deb_C && l - k >= deb_L)
            {
                if (grille[l, c] == grille[l - k, c - k])
                {
                    Pion_Align += 1;
                    k += 1;
                }
                else
                {
                    k += 3;
                }
            }
            
            k = 1;
            while (c + k <= fin_C && l + k <= fin_L)
            {
                if (grille[l, c] == grille[l + k, c + k])
                {
                    Pion_Align += 1;
                    k += 1;
                }
                else
                {
                    k += 3;
                }
            }
            if (Pion_Align >= 4)
            {
                Partie_finie = true;
                return 1;
            }
            if (Nb_Coups_Jouer == ( Lignes+1 ) * ( Colonnes+1 ) )
            {
                Partie_finie = true;
                return -1;
            }
            return 0;
        }

        public int coup(int c)
        {
            int l = case_la_plus_basse(c);
            int verif = 0;
            if (l != -1)
            {
                pose_pion(c);
                update_case_basse(c);
                verif = verification(l, c);
                ProchainTour();
            }
            return verif;
        }

        public int TourIA()
        {
            int meilleurCoup = TrouverMeilleurCoup();

            int ligneVide = ObtenirLigneVide(meilleurCoup);
            if (ligneVide != -1)
            {
                grille[ligneVide, meilleurCoup] = 2; // Place le pion de l'IA dans la colonne choisie
            }

            return meilleurCoup;
        }

        public int EvaluerEtat()
        {
            int score = 0;

            // Évaluation basique :
            // - 1 point pour chaque pion de l'IA (2) dans une ligne, colonne ou diagonale
            // - -1 point pour chaque pion de l'adversaire (1) dans une ligne, colonne ou diagonale

            // Évaluation des lignes

            for (int l = 0; l < Lignes; l++)
            {
                for (int c = 0; c <= Colonnes - 4; c++)
                {
                    int pion1 = grille[l, c];
                    int pion2 = grille[l, c + 1];
                    int pion3 = grille[l, c + 2];
                    int pion4 = grille[l, c + 3];

                    if (pion1 == 2 && pion2 == 2 && pion3 == 2 && pion4 == 2)
                        score += 10; // L'IA a une ligne complète de pions
                    else if (pion1 == 1 && pion2 == 1 && pion3 == 1 && pion4 == 1)
                        score -= 10; // L'adversaire a une ligne complète de pions
                }
            }
            // Évaluation des colonnes
            for (int c = 0; c < Colonnes; c++)
            {
                for (int l = 0; l <= Lignes - 4; l++)
                {
                    int pion1 = grille[l, c];
                    int pion2 = grille[l + 1, c];
                    int pion3 = grille[l + 2, c];
                    int pion4 = grille[l + 3, c];

                    
                    if (pion1 == 2 && pion2 == 2 && pion3 == 2 && pion4 == 2)
                        score += 10; // L'IA a une colonne complète de pions
                    else if (pion1 == 1 && pion2 == 1 && pion3 == 1 && pion4 == 1)
                        score -= 10; // L'adversaire a une colonne complète de pions
                    
                }
            }

            // Évaluation des diagonales descendantes
            for (int l = 0; l <= Lignes - 4; l++)
            {
                for (int c = 0; c <= Colonnes - 4; c++)
                {
                    int pion1 = grille[l, c];
                    int pion2 = grille[l + 1, c + 1];
                    int pion3 = grille[l + 2, c + 2];
                    int pion4 = grille[l + 3, c + 3];

                    
                    if (pion1 == 2 && pion2 == 2 && pion3 == 2 && pion4 == 2)
                        score += 10; // L'IA a une diagonale descendante complète de pions
                    else if (pion1 == 1 && pion2 == 1 && pion3 == 1 && pion4 == 1)
                        score -= 10; // L'adversaire a une diagonale descendante complète de pions
                    
                }
            }

            // Évaluation des diagonales montantes
            for (int l = Lignes - 1; l >= 3; l--)
            {
                for (int c = 0; c <= Colonnes - 4; c++)
                {
                    int pion1 = grille[l, c];
                    int pion2 = grille[l - 1, c + 1];
                    int pion3 = grille[l - 2, c + 2];
                    int pion4 = grille[l - 3, c + 3];
                    
                    if (pion1 == 2 && pion2 == 2 && pion3 == 2 && pion4 == 2)
                        score += 10; // L'IA a une diagonale montante complète de pions
                    else if (pion1 == 1 && pion2 == 1 && pion3 == 1 && pion4 == 1)
                        score -= 10; // L'adversaire a une diagonale montante complète de pions
                    
                }
            }
            return score;
        }

        private int Minimax(int profondeur, bool tourJoueurMax)
        {
            int score = EvaluerEtat();

            if (Partie_finie || profondeur == 0)
            {
                return score;
            }

            if (tourJoueurMax)
            {
                int meilleurScore = int.MinValue;

                for (int c = 0; c < Colonnes; c++)
                {
                    int l = ObtenirLigneVide(c);
                    if (l != -1)
                    {
                        grille[l, c] = 1; // La valeur 1 représente le joueur humain

                        int scoreCoup = Minimax(profondeur - 1, false);
                        grille[l, c] = 0; // Annuler le coup

                        meilleurScore = Math.Max(meilleurScore, scoreCoup);
                    }
                }

                return meilleurScore;
            }
            else
            {
                int meilleurScore = int.MaxValue;

                for (int c = 0; c < Colonnes; c++)
                {
                    int l = ObtenirLigneVide(c);
                    if (l != -1)
                    {
                        grille[l, c] = 2; // La valeur 2 représente le joueur IA

                        int scoreCoup = Minimax(profondeur - 1, true);
                        grille[l, c] = 0; // Annuler le coup

                        meilleurScore = Math.Min(meilleurScore, scoreCoup);
                    }
                }

                return meilleurScore;
            }
        }

        
        public int TrouverMeilleurCoup()
        {
            int meilleurCoup = -1;
            int meilleurScore = int.MinValue;
            int profondeur = 2;

            for (int c = 0; c < Colonnes; c++)
            {
                int l = ObtenirLigneVide(c);
                if (l != -1)
                {
                    grille[l, c] = 2; // La valeur 2 représente le joueur IA

                    int score = Minimax(profondeur - 1, false);
                    grille[l, c] = 0; // Annuler le coup

                    if (score > meilleurScore)
                    {
                        meilleurScore = score;
                        meilleurCoup = c;
                    }
                }
            }

            return meilleurCoup;
        }

        private int ObtenirLigneVide(int colonne)
        {
            for (int l = Lignes - 1; l >= 0; l--)
            {
                if (grille[l, colonne] == 0) // La valeur 0 représente une case vide
                {
                    return l;
                }
            }

            return -1; // Aucune ligne vide trouvée dans la colonne
        }
    }
}