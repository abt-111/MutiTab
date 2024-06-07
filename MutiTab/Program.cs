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
            Console.Write("Entrez une valeur pour taille de la case n°" + i + " : ");
            taille = Convert.ToInt32(Console.ReadLine());
            irregularTab[i] = new int[taille];
        }

        Console.WriteLine();

        // Insertion de uniformTab dans irregularTab
        TabInsert(irregularTab, uniformTab);

        // Affichage des tableaux
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

    public static void TabInsert(int[][] irregularTab, int[][] uniformTab)
    {
        int indexMinus = uniformTab[0].Length;

        for (int i = 0; i < irregularTab.Length; i++)
        {
            for (int j = 0; j < indexMinus; j++)
            {
                irregularTab[i][j] = uniformTab[i][j + (uniformTab[0].Length - indexMinus)];
            }
            indexMinus--;
        }
    }
}