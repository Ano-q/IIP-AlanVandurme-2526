/* Dit is een reeks korte oefeningen over selecties in C#. 
 * 
 * Doel van de oefeningen, zie https://rogiervdl.github.io/CS-course/03_selecties.html:
 *  
 * 1. relationele operatoren (==, \!=, \<, \>, \<=, \>=) om waarden te vergelijken 
 * 2. logische operatoren: combineren van booleaanse waarden en uitdrukkingen met &&, ||, en !
 * 3. if, if-else, if-else-if
 * 4. switch-case
 * 5. ternaire operator
 *
 * Tips en richtlijnen
 * - gebruik bij uitvoer zoveel mogelijk string interpolatie, dus Console.WriteLine($"Hallo, {naam}"); en niet  Console.WriteLine("Hallo, " + naam);
 * - lees goed de richtlijnen bij elke opgave
 * - controleer bij uitvoeren of je resultaat exact overeenkomt met voorbeelduitvoer.jpg
 * 
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        /* --- Oefening 1: Eenvoudige IF-vergelijking ---
         * Context: Je wilt controleren of een getal groter is dan 10.
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'getal' en geef deze een waarde (bijv. 15).
         * 2. Schrijf een `if`-statement dat controleert of 'getal' groter is dan 10.
         * 3. Print "Het getal is groter dan 10." als de voorwaarde waar is.
         *
         * Testvoorbeeld:
         * Input: getal = 15
         * Verwachte output: Het getal is groter dan 10.
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 2: IF-ELSE voor pass/fail ---
         * Context: Je moet bepalen of een student geslaagd is voor een toets. De drempel is 50.
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'score' en geef deze een waarde (bijv. 65).
         * 2. Gebruik een `if-else`-statement om te controleren of de score 50 of hoger is.
         * 3. Print "Geslaagd!" als de voorwaarde waar is, anders "Niet geslaagd.".
         *
         * Testvoorbeeld:
         * Input: score = 65
         * Verwachte output: Geslaagd!
         *
         * Input: score = 40
         * Verwachte output: Niet geslaagd.
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 3: Relaties met booleaanse expressies ---
         * Context: Je wilt bepalen of een gebruiker in de tienerleeftijd is.
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'leeftijd' en geef deze een waarde (bijv. 16).
         * 2. Schrijf een booleaanse expressie die controleert of 'leeftijd' tussen 13 en 19 (inclusief) ligt.
         * 3. Sla het resultaat op in een 'bool' variabele 'isTiener'.
         * 4. Gebruik een `if`-statement om "Is een tiener." af te drukken als 'isTiener' waar is.
         *
         * Testvoorbeeld:
         * Input: leeftijd = 16
         * Verwachte output: Is een tiener.
         *
         * Input: leeftijd = 20
         * Verwachte output: (niets)
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 4: Ternaire operator ---
         * Context: Je wilt de status van een bestelling weergeven.
         *
         * Opdracht:
         * 1. Declareer een 'bool' variabele 'isVerzonden' met de waarde `false`.
         * 2. Gebruik de ternaire operator om een 'string' variabele 'status' in te stellen.
         * Als 'isVerzonden' `true` is, moet 'status' "Verzonden" zijn. Anders moet 'status' "In behandeling" zijn.
         * 3. Print de 'status' af.
         *
         * Testvoorbeeld:
         * Input: isVerzonden = false
         * Verwachte output: In behandeling
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 5: Relatie tussen strings ---
         * Context: Je moet controleren of een gebruikersnaam geldig is.
         *
         * Opdracht:
         * 1. Declareer een 'string' variabele 'ingevoerdeGebruikersnaam' met de waarde "admin".
         * 2. Declareer een 'const string' 'VerplichteNaam' met de waarde "admin".
         * 3. Gebruik de `==` operator om te controleren of de twee strings identiek zijn. Sla het resultaat op in een 'bool' variabele 'isGeldig'.
         * 4. Print 'isGeldig' af.
         *
         * Testvoorbeeld:
         * Input: ingevoerdeGebruikersnaam = "admin"
         * Verwachte output: True
         *
         * Input: ingevoerdeGebruikersnaam = "Admin"
         * Verwachte output: False
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 6: Character vergelijking ---
         * Context: Je moet controleren of een ingevoerd karakter een klinker is.
         *
         * Opdracht:
         * 1. Declareer een 'char' variabele 'karakter' met de waarde 'a'.
         * 2. Schrijf een booleaanse expressie die controleert of 'karakter' gelijk is aan 'a' OF 'e' OF 'i' OF 'o' OF 'u'.
         * 3. Sla het resultaat op in een 'bool' variabele 'isKlinker' en print deze af.
         *
         * Testvoorbeeld:
         * Input: karakter = 'a'
         * Verwachte output: True
         *
         * Input: karakter = 'b'
         * Verwachte output: False
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 7: IF-ELSE IF-ELSE voor leeftijdsgroepen ---
         * Context: Je wilt een bericht weergeven op basis van de leeftijd van een bezoeker.
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'leeftijd' met de waarde 17.
         * 2. Gebruik een `if-else if-else` keten om de volgende regels te controleren:
         * - Als de leeftijd 12 of jonger is, print "Kind".
         * - Als de leeftijd tussen 13 en 17 is, print "Tiener".
         * - In alle andere gevallen, print "Volwassene".
         *
         * Testvoorbeeld:
         * Input: leeftijd = 17
         * Verwachte output: Tiener
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 8: Complexe logische AND/OR ---
         * Context: Een speler mag door naar het volgende level als ze minimaal 50 punten hebben EN de bazenverslagen is, OF als ze meer dan 100 punten hebben.
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'huidigePunten' met de waarde 75.
         * 2. Declareer een 'bool' variabele 'isBaasVerslagen' met de waarde `true`.
         * 3. Schrijf een booleaanse expressie die de condities combineert.
         * 4. Sla het resultaat op in een 'bool' variabele 'magDoorNaarVolgendLevel' en print deze af.
         *
         * Testvoorbeeld:
         * Input: huidigePunten = 75, isBaasVerslagen = true
         * Verwachte output: True
         *
         * Input: huidigePunten = 45, isBaasVerslagen = true
         * Verwachte output: False
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 9: String.CompareTo() ---
         * Context: Je vergelijkt twee woorden om hun alfabetische volgorde te bepalen.
         *
         * Opdracht:
         * 1. Declareer een 'string' variabele 'woord1' met de waarde "apple".
         * 2. Declareer een 'string' variabele 'woord2' met de waarde "banana".
         * 3. Gebruik de `CompareTo()` methode om de twee woorden te vergelijken en sla het resultaat op in een 'int' variabele 'resultaat'.
         * 4. Print 'resultaat' af.
         *
         * Testvoorbeeld:
         * Input: woord1 = "apple", woord2 = "banana"
         * Verwachte output: -1
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 10: Combinatie van IF en logische operatoren ---
         * Context: Een winkel biedt korting als een product van het merk "Nike" is EN duurder dan €100.
         *
         * Opdracht:
         * 1. Declareer een 'string' variabele 'merk' met de waarde "Nike".
         * 2. Declareer een 'double' variabele 'prijs' met de waarde 120.0.
         * 3. Gebruik een `if`-statement om te controleren of het merk "Nike" is en de prijs groter is dan 100.0.
         * 4. Print "U krijgt korting!" als de voorwaarde waar is.
         *
         * Testvoorbeeld:
         * Input: merk = "Nike", prijs = 120.0
         * Verwachte output: U krijgt korting!
         *
         * Input: merk = "Adidas", prijs = 120.0
         * Verwachte output: (niets)
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 11: Ternaire operator en typeconversie ---
         * Context: Je wilt de status van een temperatuur weergeven als "Heet" of "Normaal".
         *
         * Opdracht:
         * 1. Vraag de gebruiker om de temperatuur in te voeren en sla deze op als een 'string'.
         * 2. Converteer de string naar een 'int' met `int.Parse()`.
         * 3. Gebruik de ternaire operator om een 'string' variabele 'temperatuurStatus' in te stellen.
         * - Als de temperatuur groter is dan 25, is de status "Heet".
         * - Anders is de status "Normaal".
         * 4. Print 'temperatuurStatus' af.
         *
         * Testvoorbeeld:
         * Input: 28
         * Verwachte output: Heet
         *
         * Input: 20
         * Verwachte output: Normaal
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 12: Meerdere voorwaarden met IF-ELSE IF ---
         * Context: Je wilt bepalen welke medaille een atleet wint op basis van hun positie.
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'positie' met een waarde (bijv. 2).
         * 2. Gebruik een `if-else if-else` keten om de volgende regels te controleren:
         * - Als de positie 1 is, print "Goud!".
         * - Als de positie 2 is, print "Zilver.".
         * - Als de positie 3 is, print "Brons.".
         * - In alle andere gevallen, print "Geen medaille.".
         *
         * Testvoorbeeld:
         * Input: positie = 2
         * Verwachte output: Zilver.
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 13: Logische operatoren en OR-vergelijking ---
         * Context: Een film is geschikt voor volwassenen als het thema 'geweld' of 'volwassen' bevat.
         *
         * Opdracht:
         * 1. Declareer een 'string' variabele 'thema1' met de waarde "drama".
         * 2. Declareer een 'string' variabele 'thema2' met de waarde "geweld".
         * 3. Schrijf een booleaanse expressie die controleert of 'thema1' of 'thema2' "geweld" OF "volwassen" is.
         * 4. Sla het resultaat op in een 'bool' variabele 'isGeschiktVoorVolwassenen'.
         * 5. Print de waarde van 'isGeschiktVoorVolwassenen' af.
         *
         * Testvoorbeeld:
         * Input: thema1="drama", thema2="geweld"
         * Verwachte output: True
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 14: Vergelijking met booleaanse variabele ---
         * Context: Je wilt de status van een schakelaar veranderen.
         *
         * Opdracht:
         * 1. Declareer een 'bool' variabele 'schakelaar' en geef deze de waarde `true`.
         * 2. Gebruik een `if-else` statement. Als 'schakelaar' `true` is, print "Schakelaar is aan.". Anders, print "Schakelaar is uit.".
         * 3. Verander de waarde van 'schakelaar' naar `false`.
         * 4. Herhaal de `if-else` statement.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * Schakelaar is aan.
         * Schakelaar is uit.
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 15: Ternaire operator met numerieke vergelijking ---
         * Context: Je wilt bepalen wat de hoogste score is tussen twee spelers.
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'scoreSpeler1' met de waarde 1200.
         * 2. Declareer een 'int' variabele 'scoreSpeler2' met de waarde 1500.
         * 3. Gebruik de ternaire operator om de hoogste score te bepalen. Sla het resultaat op in een 'int' variabele 'hoogsteScore'.
         * 4. Print 'hoogsteScore' af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 1500
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 16: IF-statement met string.Contains() ---
         * Context: Je controleert of een e-mailadres geldig is door te kijken of het een '@' bevat.
         *
         * Opdracht:
         * 1. Vraag de gebruiker om een e-mailadres in te voeren en sla het op in een 'string' variabele 'email'.
         * 2. Gebruik een `if`-statement en de `Contains()`-methode om te controleren of 'email' een "@" bevat.
         * 3. Print "Geldig e-mailadres." als de voorwaarde waar is.
         *
         * Testvoorbeeld:
         * Input: jan@email.com
         * Verwachte output: Geldig e-mailadres.
         *
         * Input: jan_email.com
         * Verwachte output: (niets)
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 17: Relatie met `DateTime` ---
         * Context: Je controleert of het al ochtend is.
         *
         * Opdracht:
         * 1. Declareer een 'DateTime' variabele 'nu' met `DateTime.Now`.
         * 2. Schrijf een booleaanse expressie die controleert of het uur (nu.Hour) kleiner is dan 12.
         * 3. Sla het resultaat op in een 'bool' variabele 'isOchtend'.
         * 4. Gebruik een `if`-statement om "Het is ochtend." af te drukken als 'isOchtend' waar is.
         *
         * Testvoorbeeld:
         * Als het 9 uur 's ochtends is:
         * Verwachte output: Het is ochtend.
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 18: `if...else` met booleaanse `Parse` ---
         * Context: Je vraagt een gebruiker of ze akkoord gaan met de voorwaarden.
         *
         * Opdracht:
         * 1. Vraag de gebruiker "Ga je akkoord? (true/false)" en sla de invoer op in een 'string'.
         * 2. Gebruik `bool.Parse()` om de string om te zetten naar een 'bool' variabele 'akkoord'.
         * 3. Gebruik een `if-else`-statement om te bepalen of de gebruiker akkoord is.
         * - Als 'akkoord' `true` is, print "Bedankt!".
         * - Anders, print "Annuleren.".
         *
         * Testvoorbeeld:
         * Input: true
         * Verwachte output: Bedankt!
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 19: Combinatie van `Math` en `if` ---
         * Context: Je wilt controleren of een getal een perfect vierkant is.
         *
         * Opdracht:
         * 1. Declareer een 'double' variabele 'getal' met de waarde 25.0.
         * 2. Bereken de vierkantswortel van 'getal' met `Math.Sqrt()`. Sla het resultaat op in een 'double' variabele 'wortel'.
         * 3. Controleer met een `if`-statement of de wortel een geheel getal is. Dit kan door te vergelijken of 'wortel' gelijk is aan `Math.Floor(wortel)`.
         * 4. Als de voorwaarde waar is, print "Het getal is een perfect vierkant."
         *
         * Testvoorbeeld:
         * Input: getal = 25.0
         * Verwachte output: Het getal is een perfect vierkant.
         *
         * Input: getal = 24.0
         * Verwachte output: (niets)
         */
        
        // TODO: implementeer hier.

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 20: Ternaire operator in string-uitvoer ---
         * Context: Je wilt een bericht tonen over het aantal punten dat een speler heeft.
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'punten' met de waarde 1.
         * 2. Gebruik de ternaire operator binnen een `Console.WriteLine` om te bepalen of het woord "punt" of "punten" moet worden weergegeven.
         * - Als 'punten' gelijk is aan 1, gebruik dan "punt".
         * - Anders, gebruik dan "punten".
         *
         * Testvoorbeeld:
         * Input: punten = 1
         * Verwachte output: Je hebt 1 punt.
         *
         * Input: punten = 5
         * Verwachte output: Je hebt 5 punten.
         */
        
        // TODO: implementeer hier.
    }
}
