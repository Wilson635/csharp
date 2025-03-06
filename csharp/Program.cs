namespace csharp;

using System;

/*
 * Arithmétique  : +, -, *, /, % (binaire)
 *                 +, -, ++, --, (unaire)
 *
 * Affectation   : =, +=, -=, *=, /=, %=
 *
 * Booléen - (In)egalité           : ==, !, <, >, <=, >=
 * Booléen - binaire conditionnel  : &&, ||
 */

class Csharp
{
    static void Main()
    {
        Console.Title = "My First Game";
        /*
            // Déclaration des variables et Types de données
            Double a = 12.5;
            Double b = 12.5;

            Double c = a + b;

            string text = "wilson";
            string subText = "Steve";

            // Affichage du text
            Console.WriteLine(text + ' ' + subText);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        */
        
        bool result = (5 % 2 == 0);
        
        Console.WriteLine(result);
    }
}