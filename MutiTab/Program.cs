using System;
using System.Threading.Channels;

class MainClass
{
    public static void Main(string[] args)
    {
        int taille;
        int[][] uniformTab = [[1, 2, 3], [2, 3, 4], [3, 4, 5]];
        int[][] irregularTab = new int[3][];

        // Saisie de l'utilisateur
        for (int i = 0; i < irregularTab.Length; i++)
        {
            Console.Write("Entrez une valeur pour taille de la case n°" + i + " entre 1 et 3 (please T_T) : ");
            taille = Convert.ToInt32(Console.ReadLine());
            irregularTab[i] = new int[taille];
        }

        Console.WriteLine();

        // Insertion de uniformTab dans irregularTab
        for (int i = 0; i < irregularTab.Length; i++)
        {
            for (int j = 0; j < irregularTab[i].Length; j++)
            {
                irregularTab[i][j] = uniformTab[i][j + (uniformTab[0].Length - irregularTab[i].Length)];
            }
        }

        TabDisplay(uniformTab, "uniforme");
        TabDisplay(irregularTab, "irrégulier");
    }

    public static void TabDisplay(int[][] tableau, string tabName)
    {
        string chaine = "Tableau " + tabName + "\n";

        for (int i = 0; i < tableau.Length; i++)
        {
            chaine += i + " => " + " [ ";
            for (int j = 0; j < tableau[i].Length; j++)
            {
                chaine += tableau[i][j];
                if (j + 1 != tableau[i].Length)
                {
                    chaine += ", ";
                }
            }
            chaine += " ]\n";
        }

        Console.WriteLine(chaine);
    }
}