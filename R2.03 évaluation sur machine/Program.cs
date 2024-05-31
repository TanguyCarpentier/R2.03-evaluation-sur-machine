//CreeTab est un sous-programme qui ne prends aucun
//paramètre. Il demande le nombre d'éléments 
//harmoniques qui corresponds à la taille du tableau.
//Et il créer et return un tableau qui corresponds à la taille
//Indiquée.
double[] CreeTab()
{
    int taille;
    Console.WriteLine("Saisir le nombre d'éléments harmoniques");
    taille=Convert.ToInt32(Console.ReadLine());
    double[] tab=new double[taille];
    return tab;
}

