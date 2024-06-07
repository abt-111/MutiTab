using System;

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

        // Insertion de uniformTab dans irregularTab
        for (int i = 0; i < irregularTab.Length; i++)
        {
            for (int j = 0; j < irregularTab[i].Length; j++)
            {
                irregularTab[i][j] = uniformTab[i][j + (uniformTab.Length - 1)];
            }
        }
    }
}