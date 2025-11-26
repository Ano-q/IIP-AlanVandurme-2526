=====================================
CONSOLERESTO - EXAMEN PRATIQUE
=====================================

Date: 11 novembre 2025
Exercice: Application Development Fundamentals - Partieel Examen


=====================================
CODE COMPLET - CONSOLERESTO
=====================================

namespace Program;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        // constanten en variabelen //
        const double prijsSpaghetti = 12.00;
        const double prijsLasagne = 15.00;
        const double prijsPizza = 13.00;
        const double prijsWijn = 7.00;
        const double prijsFrisdrank = 3;
        const double happyHourKortingPercentage = 0.1;
        const double btwTarief = 0.21;
        double prijsExclBtw = 0;
        double prijsBtw = 0;
        double prijsTotaal = 0;
        char bestelCode;
        
        // DO-WHILE loop //
        do
        {
            Console.Clear();
            Console.WriteLine($@"
=== Resto Odisee ====
a. Spaghetti € {prijsSpaghetti}
b. Lasagne € {prijsLasagne}
c. Pizza € {prijsPizza}
d. Wijn € {prijsWijn}
e. Frisdrank € {prijsFrisdrank}
f. Stop");
            Console.WriteLine();
            Console.Write("plaats je bestelling (a-e of f om te stoppen) ");
            bestelCode = Convert.ToChar(Console.ReadLine());
            
            // SWITCH CASE //
            switch (bestelCode)
            {
                case 'a':
                    prijsExclBtw += prijsSpaghetti;
                    Console.WriteLine($"Spaghetti besteld (€ {prijsSpaghetti:F2})");
                    Console.ReadLine();
                    break;
                case 'b':
                    prijsExclBtw += prijsLasagne;
                    Console.WriteLine($"Lasagne besteld (€ {prijsLasagne:F2})");
                    Console.ReadLine();
                    break;
                case 'c':
                    prijsExclBtw += prijsPizza;
                    Console.WriteLine($"Pizza besteld (€ {prijsPizza:F2})");
                    Console.ReadLine();
                    break;
                case 'd':
                    prijsExclBtw += prijsWijn;
                    Console.WriteLine($"Wijn besteld (€ {prijsWijn:F2})");
                    Console.ReadLine();
                    break;
                case 'e':
                    prijsExclBtw += prijsFrisdrank;
                    Console.WriteLine($"Frisdrank besteld (€ {prijsFrisdrank:F2})");
                    Console.ReadLine();
                    break;
                case 'f':
                    Console.WriteLine($"Stop");
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }
        } while (bestelCode != 'f');
        
        // Berekening van de korting //
        DateTime nu = DateTime.Now;
        int uur = nu.Hour;
        int minuten = nu.Minute;
        
        if ((uur == 17 && minuten >= 30) || uur == 18 || (uur == 19 && minuten == 0))
        {
            double korting = prijsExclBtw * happyHourKortingPercentage;
            prijsExclBtw = prijsExclBtw - korting;
            Console.WriteLine($"Happy hour! Korting van {happyHourKortingPercentage:P0}");
        }
        
        prijsBtw = prijsExclBtw * btwTarief;
        prijsTotaal = prijsExclBtw + prijsBtw;
        
        Console.WriteLine($@"
= Afrekening =
Prijs zonder BTW: € {prijsExclBtw:F2}
BTW: € {prijsBtw:F2}
Totaal: € {prijsTotaal:F2}");
        Console.WriteLine("Bedankt voor je bezoek!");
        Console.ReadLine();
        Console.ReadKey();
    }
}


=====================================
POINTS CLÉS DU CODE
=====================================

1. CONSTANTES ET VARIABLES
   - Toutes les constantes sont de type DOUBLE (pas decimal!)
   - happyHourKortingPercentage = 0.1 (pour 10%)
   - btwTarief = 0.21 (pour 21%)
   - Attention: 21% s'écrit 0.21, pas (21%)!

2. BOUCLE DO-WHILE
   - Utilisée car on doit afficher le menu AU MOINS une fois
   - Continue tant que bestelCode != 'f'
   - Console.Clear() au début pour nettoyer l'écran

3. SWITCH-CASE
   - Chaque case ajoute le prix à prijsExclBtw avec +=
   - Chaque case affiche un message de confirmation
   - Ne pas oublier break; à la fin de chaque case
   - default pour gérer les choix invalides

4. HAPPY HOUR (17h30 - 19h00)
   - DateTime.Now pour obtenir l'heure actuelle
   - Condition: (uur == 17 && minuten >= 30) || uur == 18 || (uur == 19 && minuten == 0)
   - Les parenthèses sont importantes!
   - Appliquer la réduction AVANT de calculer le BTW

5. CALCULS
   - prijsBtw = prijsExclBtw * btwTarief
   - prijsTotaal = prijsExclBtw + prijsBtw
   - ATTENTION: utiliser btwTarief, pas prijsBtw dans le calcul!

6. FORMAT SPECIFIERS
   - :F2 pour les montants en euros (2 décimales)
   - :P0 pour les pourcentages (affiche 10% au lieu de 0.1)

7. COMMENTAIRES
   - Code commenté pour plus de clarté
   - Aide à la compréhension et à la maintenance


=====================================
ERREURS FRÉQUENTES À ÉVITER
=====================================

❌ prijsBtw = prijsExclBtw * prijsBtw
✅ prijsBtw = prijsExclBtw * btwTarief

❌ const double btwTarief = (21%)
✅ const double btwTarief = 0.21

❌ Oublier d'ajouter le prix: Console.WriteLine(...)
✅ prijsExclBtw += prijsSpaghetti; puis Console.WriteLine(...)

❌ if (uur == 17 && minuten >= 30 || uur == 18)
✅ if ((uur == 17 && minuten >= 30) || uur == 18 || (uur == 19 && minuten == 0))

❌ {prijsSpaghetti} sans format
✅ {prijsSpaghetti:F2} pour 2 décimales

❌ Oublier le break; dans un case
✅ Toujours mettre break; à la fin de chaque case


=====================================
CHECKLIST AVANT DE SOUMETTRE
=====================================

□ Le code compile sans erreurs
□ Toutes les constantes sont déclarées avec les bonnes valeurs
□ Le menu s'affiche correctement avec "=== Resto Odisee ==="
□ Les prix s'accumulent correctement dans prijsExclBtw
□ Happy Hour fonctionne (tester entre 17h30 et 19h00)
□ Le BTW est calculé avec btwTarief (0.21)
□ Tous les montants sont formatés avec :F2
□ Le pourcentage est affiché avec :P0
□ Le message "Bedankt voor je bezoek!" s'affiche
□ Le code est commenté
□ Naming et casing corrects (camelCase)
□ Fichier ZIP nommé: ADF_PartieelExamen_VoornaamFamilienaam.zip


=====================================
CONSEILS POUR L'EXAMEN
=====================================

1. Lis TOUJOURS l'énoncé en entier avant de commencer
2. Vérifie le type des variables (double vs decimal vs int)
3. Teste ton code régulièrement pendant que tu codes
4. Fais attention aux parenthèses dans les conditions complexes
5. Utilise les constantes demandées, ne tape pas les valeurs en dur
6. N'oublie pas les format specifiers (:F2, :P0)
7. Commente ton code pour montrer que tu comprends
8. Relis ton code avant de soumettre
9. Vérifie que le ZIP est correctement nommé
10. Reste calme et confiant - tu as bien pratiqué!


BONNE CHANCE POUR TON EXAMEN VENDREDI! 🍀💪

Tu es bien préparé et tu vas réussir! 🎉
