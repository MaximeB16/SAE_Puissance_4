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
        private bool Partie_fini = false;

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
            return Partie_fini;
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
                    Partie_fini = true;
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
                Partie_fini = true;
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
                Partie_fini = true;
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
                return 1;
            }
            if (Nb_Coups_Jouer == ( Lignes+1 ) * ( Colonnes+1 ) )
            {
                Partie_fini = true;
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
                pose_pion(l, c);
                update_case_basse(c);
                verif = verification(l, c);
                ProchainTour();
            }
            return verif;
        }

        public int TourIA()
        {
            int meilleurCoup = 0;
            if (Tour && !Partie_fini)
            {
                meilleurCoup = TrouverMeilleurCoup();
                if (meilleurCoup != -1)
                    coup(meilleurCoup);
            }
            return meilleurCoup;
        }

        public int EvaluerEtat()
        {
            if (Partie_fini)
            {
                if (Tour)
                {
                    Partie_fini = true;
                    return -1; // Le joueur 2 a gagné
                }
                else
                {
                    Partie_fini = true;
                    return 1; // Le joueur 1 a gagné
                }
            }
            else
                return 0; // Match nul ou partie en cours
        }

        public int Minimax(int profondeur, bool joueurMax)
        {
            int score = EvaluerEtat();

            if (score != 0 || profondeur == 0)
                return score;

            if (joueurMax)
            {
                int meilleurScore = int.MinValue;

                for (int col = 0; col <= Colonnes; col++)
                {
                    if (case_basse[col] != -1)
                    {
                        int ligne = case_basse[col];

                        grille[ligne, col] = 1;
                        case_basse[col]--;
                        Nb_Coups_Jouer++;

                        int scoreActuel = Minimax(profondeur - 1, !joueurMax);

                        grille[ligne, col] = 0;
                        case_basse[col]++;
                        Nb_Coups_Jouer--;

                        meilleurScore = Math.Max(meilleurScore, scoreActuel);
                    }
                }

                return meilleurScore;
            }
            else
            {
                int meilleurScore = int.MaxValue;

                for (int col = 0; col <= Colonnes; col++)
                {
                    if (case_basse[col] != -1)
                    {
                        int ligne = case_basse[col];

                        grille[ligne, col] = 2;
                        case_basse[col]--;
                        Nb_Coups_Jouer++;

                        int scoreActuel = Minimax(profondeur - 1, joueurMax);

                        grille[ligne, col] = 0;
                        case_basse[col]++;
                        Nb_Coups_Jouer--;

                        meilleurScore = Math.Min(meilleurScore, scoreActuel);
                    }
                }

                return meilleurScore;
            }
        }

        public int TrouverMeilleurCoup()
        {
            int meilleurScore = int.MinValue;
            int meilleurCoup = -1;

            for (int col = 0; col <= Colonnes; col++)
            {
                if (case_basse[col] != -1)
                {
                    int ligne = case_basse[col];

                    grille[ligne, col] = 1;
                    case_basse[col]--;
                    Nb_Coups_Jouer++;

                    int scoreActuel = Minimax(5, false); // Profondeur maximale de l'algorithme MinMax

                    grille[ligne, col] = 0;
                    case_basse[col]++;
                    Nb_Coups_Jouer--;

                    if (scoreActuel > meilleurScore)
                    {
                        meilleurScore = scoreActuel;
                        meilleurCoup = col;
                    }
                }
            }

            return meilleurCoup;
        }
    }
}