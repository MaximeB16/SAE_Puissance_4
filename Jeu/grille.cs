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
        
        /// <summary>
        /// Constructeur de la Grille
        /// </summary>
        /// <param name="l">Nombre de lignes</param>
        /// <param name="c">Nombre de colonne</param>
        public Grille(int l, int c)
        {
            // Indice de la dernière ligne et de la dernière colonne
            Lignes = l-1;
            Colonnes = c-1;
            Nom_Joueurs.Add("Alice"); Nom_Joueurs.Add("Connor");
            Tour = true;
            // Initialisation de la grille de jeu avec des 0 --> aucun pion posé
            grille = new int[l,c];
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    grille[i, j] = 0;
                }
            }
            // Initialisation du tableau de la plus basse ligne disponible pour chaque colonne
            case_basse = new int[c];
            for (int k = 0; k < c; k++)
            {
                case_basse[k] = Lignes;
            }
        }

        /// <summary>
        /// Getter du tableau 2D représentant les pions placés
        /// </summary>
        /// <returns>État de la grille</returns>
        public int[,] get_grille()
        {
            return grille;
        }

        /// <summary>
        /// Recommence la partie
        /// </summary>
        public void restart()
        {
            // Réinitialise toutes les valeurs par défaut
            Nb_Coups_Jouer = 0;
            Partie_fini = false;
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

        /// <summary>
        /// Indique si la partie est finie ou non
        /// </summary>
        /// <returns>Vrai si la partie est finie, faux si elle est toujours en cours</returns>
        public bool get_est_fini()
        {
            return Partie_fini;
        }

        /// <summary>
        /// Défini le joueur qui joue
        /// </summary>
        /// <param name="y">Vrai si c'est au tour du joueur 1, faux si  c'est à celui du joueur 2</param>
        public void set_tour(bool y)
        {
            Tour = y;
        }

        /// <summary>
        /// Donne le nombre de coups joués depuis le début de la partie
        /// </summary>
        /// <returns>Nombre de coups joués</returns>
        public int get_Nb_Coup_Jouer()
        {
            return Nb_Coups_Jouer;
        }

        /// <summary>
        /// Donne le nombre de lignes de la grille
        /// </summary>
        /// <returns>Nombre de lignes</returns>
        public int get_Lignes()
        {
            return Lignes;
        }

        /// <summary>
        /// Donne le nombre de colonnes de la grille
        /// </summary>
        /// <returns>Nombre de colonnes</returns>
        public int get_Colonnes()
        {
            return Colonnes;
        }

        /// <summary>
        /// Renvoie le nombre de joueurs humains
        /// </summary>
        /// <returns>Nombre de joueurs</returns>
        public int get_Nb_Joueurs()
        {
            return Nb_Joueurs;
        }

        /// <summary>
        /// Renvoie le Tour en cours
        /// </summary>
        /// <returns>Vrai si c'est au tour du joueur 1, faux sii c'est au tour du  joueur 2</returns>
        public bool get_Tour()
        {
            return Tour;
        }

        /// <summary>
        /// Renvoie le nom du joueur 
        /// </summary>
        /// <param name="joueur">indice du joueurs</param>
        /// <returns></returns>
        public string get_NomJ(int joueur)
        {
            return Nom_Joueurs[joueur];
        }

        /// <summary>
        /// Met à jour le nom de chaque joueur
        /// </summary>
        /// <param name="Name1">Nouveau nom du joueur 1</param>
        /// <param name="Name2">Nouveau nom du joueur 2</param>
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

        /// <summary>
        /// Met à jour le nombre de joueurs humains
        /// </summary>
        /// <param name="k">Nouveau nombre de joueurs humains</param>
        public void update_NbJ(int k)
        {
            Nb_Joueurs = k;
        }

        /// <summary>
        /// Passe au tour suivant
        /// </summary>
        public void ProchainTour()
        {
            Tour = !Tour;
        }

        /// <summary>
        /// Pose le pion dans la colonne données
        /// </summary>
        /// <param name="c">Colonne dans laquelle le pion sera posé</param>
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

        /// <summary>
        /// Renvoie la ligne non-utilisée la plus basse de la colonne donnée
        /// </summary>
        /// <param name="c">Indice de la colonne</param>
        /// <returns>Ligne la plus basse de la colonne</returns>
        public int case_la_plus_basse(int c)
        {
            return case_basse[c];
        }

        /// <summary>
        /// Met à jour la valeur à l'indice de la colonne donnée dans le tableau des cases les plus basses
        /// </summary>
        /// <param name="c">Indice de la colonne</param>
        public void update_case_basse(int c)
        {
            case_basse[c] -= 1;
        }

        /// <summary>
        /// Vérifie l'état de la grille pour la case à la ligne et colonne donnée
        /// </summary>
        /// <param name="l">Indice de la ligne</param>
        /// <param name="c">Indice de la colonne</param>
        /// <returns>1 si l'un des joueurs à gagner, -1 si il y a match nul et 0 si la partie n'est pas encore finie</returns>
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

        /// <summary>
        /// Place le pion dans la colonne donnée et vérifie l'état de la grille
        /// </summary>
        /// <param name="c">Indice de la colonne</param>
        /// <returns>Vérification de la grille</returns>
        public int coup(int c)
        {
            int verif = 0;
            if (case_basse[c] != -1)
            {
                pose_pion(c);
                verif = verification(case_basse[c],c);
                update_case_basse(c);
                ProchainTour();
            }
            return verif;
        }

        /// <summary>
        /// Fait jouer l'IA
        /// </summary>
        /// <returns>Colonne du meilleur coup</returns>
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

        /// <summary>
        /// Évalue l'état de la grille
        /// </summary>
        /// <returns>Valeur de l'état</returns>
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

        /// <summary>
        /// Emploie du minmax, algorithme récursif vérifiant chaque coup possible et comparant l'évaluation de la grille
        /// </summary>
        /// <param name="profondeur">Nombre de coups futurs à regarder</param>
        /// <param name="joueurMax">Vrai si le joueur est le joueur Max, faux si c'est le joueur Min</param>
        /// <returns></returns>
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

        /// <summary>
        /// Compare chaque coup possible et effectue son minmax pour trouver le meilleur coup
        /// </summary>
        /// <returns>Colonne du meilleur coup</returns>
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

                    int scoreActuel = Minimax(5, false); // Profondeur maximale de l'algorithme MinMax : 5

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