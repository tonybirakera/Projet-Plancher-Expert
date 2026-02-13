// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    // Méthode principale du programme.
    static void Main(string[] args)
    {
        //Déclaration des variables.
        double longueur, largeur, superficie;
        double prixMat = 0, prixMO = 0;
        double coutMat, coutMO, sousTotal, taxes, total;
        int choix;
        string typePlancher = "";

        //Début de la saisie d'information par l'utilisateur
        Console.Write("Veuillez entrer la longueur de la pièce (en pieds carré) : ");
        longueur = Convert.ToDouble(Console.ReadLine());
        Console.Write("Veuillez entrer la largeur de la pièce (en pieds carré) : ");
        largeur = Convert.ToDouble(Console.ReadLine());
        //calcul de la superficie
        superficie = longueur * largeur;

        //Implatation de notre boucle DO...WHILE
        do
        {
            //Demande de saisi et affichage des choix à l'utilisateur
            Console.WriteLine();
            Console.WriteLine("Choisissez le type de couvre-plancher :");
            Console.WriteLine("1. Tapis commercial");
            Console.WriteLine("2. Tapis de qualité");
            Console.WriteLine("3. Plancher de bois franc");
            Console.WriteLine("4. Plancher flottant");
            Console.WriteLine("5. Céramique");
            Console.Write("Votre choix : ");
            choix = Convert.ToInt32(Console.ReadLine());
        }
        //fin de notre boucle
        while (choix < 1 || choix > 5);
        
        // Sélection du type de plancher en utilisant la structure de sélection CASE
        switch (choix)
        {
            case 1:
                typePlancher = "Tapis commercial";
                prixMat = 1.29;
                prixMO = 2.00;
                break;

            case 2:
                typePlancher = "Tapis de qualité";
                prixMat = 3.99;
                prixMO = 2.25;
                break;

            case 3:
                typePlancher = "Plancher de bois franc";
                prixMat = 3.49;
                prixMO = 3.25;
                break;

            case 4:
                typePlancher = "Plancher flottant";
                prixMat = 1.99;
                prixMO = 2.25;
                break;

            case 5:
                typePlancher = "Céramique";
                prixMat = 1.49;
                prixMO = 3.25;
                break;
        }
        //Calcul des divers coûts et total taxe incluse
        coutMat = superficie * prixMat;
        coutMO = superficie * prixMO;
        sousTotal = coutMat + coutMO;
        taxes = sousTotal * 0.15;
        total = sousTotal + taxes;
        //Affichage des informations sur le total des coûts taxe incluse
        Console.WriteLine();
        Console.WriteLine("--- RÉSULTATS ---");
        Console.WriteLine();
        Console.WriteLine("Superficie : " + superficie + " pi²");
        Console.WriteLine("Type de couvre-plancher : " + typePlancher);
        Console.WriteLine("Coût des matériaux : " + coutMat + "$");
        Console.WriteLine("Coût de la main-d’œuvre : " + coutMO + "$");
        Console.WriteLine("Taxes (15 %) : " + taxes + "$");
        Console.WriteLine();
        Console.WriteLine("TOTAL À PAYER : " + total + "$");
        Console.ReadKey();
    }
}

