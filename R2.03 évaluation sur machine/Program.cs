//CreeTab est un sous-programme qui ne prends aucun paramètre.
//Il demande le nombre d'éléments harmoniques qui corresponds à la 
//taille du tableau.Il créé et return un tableau qui corresponds
// à la taille indiquée.

double[] CreeTab()
{
    int taille;
    Console.WriteLine("Saisir le nombre d'éléments harmoniques");
    taille=Convert.ToInt32(Console.ReadLine());
    double[] tab=new double[taille];
    return tab;
}
//CalculNombreHarmonique est un sous-programme qui prends en paramètre
//Hn qui est le nombre harmonique que l'on souhaite calculé et qui 
//renvoit le nombre harmonique qui a été calculé.
double CalculNombreHarmonique(int Hn)
{
    double NombreHarmonique = 0;
    for (int i = 0; i < Hn; i++)
    {
        NombreHarmonique += 1 / i;
    }
    return NombreHarmonique;
}

//AjoutNombreHarmoniqueDansTableau est un sous-programme qui prends en
//paramètre un tableau. Puis remplit chaque élément du tableau par 
//le nombre harmonique correspondant à son emplacement dans le tableau.
double[] AjoutNombreHarmoniqueDansTableau(double[] Tableau)
{
    for (int i = 1;i < Tableau.Length; i++)
    {
        Tableau[i-1] = CalculNombreHarmonique(i);
    }
    return Tableau;
}

