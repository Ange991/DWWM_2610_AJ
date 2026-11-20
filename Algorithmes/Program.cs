// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        //declaration
        string prenom = "";
        string ville = "";
        string couleur = "";
        int age;

        //saisie
        Console.WriteLine("Entrez votre prénom.");
        prenom = Console.ReadLine();
        Console.WriteLine("Quel âge avez-vous ?");
        age = int.Parse(Console.ReadLine());

        //traitement
        if (age >= 18)
        {
            Console.WriteLine("Dans quelle ville habitez-vous ?");
            ville = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Quelle est votre couleur préférée ?");
            couleur = Console.ReadLine();
        }
        if (age >= 18)
        {
            Console.WriteLine(prenom + "," + age + ", majeur," + ville);
        }
        else
        {
            Console.WriteLine(prenom + "," + age + ", mineur," + couleur);
        }
    }
}