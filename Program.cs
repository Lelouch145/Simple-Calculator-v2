using System;
// använder system.IO för filhantering
using System.IO;




class Program
{

    static void Main()
    {


        List<string> history = new List<string>();
        // Skapar en filväg som heter "history.txt"
        string filePath = "history.txt";
        // Om filen existerar
        if (File.Exists(filePath))
        {
            // Läser filen "history.txt" och visar den i programmet
            // history.txt har det som array så jag gör om till en lista
            history = new List<string>(File.ReadAllLines(filePath));
        }
        bool running = true;

        while (running)
        {
            Console.WriteLine("Välj alternativen");

            Menu();

            string input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    Calculate(history, "+", filePath);
                    break;

                case "2":
                    Calculate(history, "-", filePath);
                    break;

                case "3":
                    Calculate(history, "*", filePath);
                    break;

                case "4":
                    Calculate(history, "/", filePath);
                    break;

                case "5":
                    ShowHistory(history);
                    break;

                case "6":
                    Calculate(history, "^", filePath);
                    break;

                case "7":
                    Calculate(history, "roten ur", filePath);
                    break;

                case "8":
                    Calculate(history, "%", filePath);
                    break;
                case "9":
                    Console.WriteLine("Avslutar kalkulatorn... ");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Skriv en giltig siffra. ");
                    break;



            }



        }

    }

    static void Menu()
    {
        Console.WriteLine("\n--- SIMPLE CALCULATOR ---");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Visa Historik");
        Console.WriteLine("6. Upphöjd");
        Console.WriteLine("7. Roten ur");
        Console.WriteLine("8. Modulo");
        Console.WriteLine("9. Exit");
        Console.Write("Välj ett av alternativen: ");
    }







    // Visar historik alltså det användaren har skrivit tidigare
    static void ShowHistory(List<string> history)
    {

        Console.WriteLine(Environment.NewLine + "Historik!");

        if (history.Count == 0)
        {
            Console.WriteLine("Det finns ingen historik");
            return;
        }
        // Vi skriver ut "line" istället för history
        // för att history är hela listan
        // och line är en rad i taget
        foreach (string line in history)
        {
            Console.WriteLine(line);
        }
    }

    // En metod för att konvertera användarens input som är sträng till
    // double utan att göra samma kod om och om igen som version 1
    static double GetNumber(string message)
    {
        // Körs till den blir false alltså i denna fall tills det finns inget
        // mer att göra
        while (true)
        {
            // Använder parameter för att visa meddelandet
            Console.Write(message);
            // Sparar användarens val i input
            string input = Console.ReadLine() ?? "";
            // Försöker konvertera input strängen till en double number
            if (double.TryParse(input, out double number))
            {
                // Om det går att konvertera då returnerar vi number 
                return number;
            }
            else
            {
                // Ananrs får användaren ett fel meddelande
                Console.WriteLine("Ogiltigt tal, försök igen!");
            }

        }

    }

    // Exakt samma princip som i GetNumber men denna metod konverterar 
    // användarens val till int istället
    static int GetNumberInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Ogiltigt tal, försök igen");
            }
        }
    }

    // Frågar användaren hur många tal hen vill använda
    static int GetCount()
    {
        // Loopar igenom till användaren svarar rätt
        while (true)
        {
            // Skriver ut meddelande till användaren
            Console.WriteLine("Hur många tal vill du använda?");
            // sparar svaren som en sträng i input variabeln
            string input = Console.ReadLine() ?? "";
            // Försöker omvandla den till int och döper den till antal
            if (int.TryParse(input, out int antal))
            {
                // Om antalet alltså användaren val är mer än 1 så sparar vi det
                if (antal > 1)
                {
                    return antal;
                }
                // Annars får användaren ett felmeddelande och försöker igen
                else
                {
                    Console.WriteLine("Antal tal måste vara mer än 1");
                }
            }
            else
            {
                // Felmeddelande till användaren 
                Console.WriteLine("Skriv en giltig heltal!");
            }
        }

    }

    static void SaveHistory(List<string> history, string filePath)
    {
        // Skriver användarens val till history.txt och sparar där.
        File.WriteAllLines(filePath, history);

    }

    // Här är all magi som sker
    static void Calculate(List<string> history, string operation, string filePath)
    {
        // I variabeln ska vi spara resultat och dens startvärde är 0
        double resultat = 0;
        // Här gör vi upphöjd, max två siffrro.
        if (operation == "^")
        {
            // Användaren får välja basen och sparar den som double bas
            double bas = GetNumber("Skriv basen: ");
            // samma här fast exponent
            double exponent = GetNumber("Skriv exponenten: ");
            // Här använder jag en math-funktion för att kunna räkna
            // ut upphöjd och sparar det i resultat
            resultat = Math.Pow(bas, exponent);
            // Skriver ut resultaten
            Console.WriteLine($"Resultat: {resultat}");
            // Lägger till det i listan "history"
            history.Add($"{bas} ^ {exponent} = {resultat}");
            SaveHistory(history, filePath);
            return;
        }
        // Här sker roten ur
        else if (operation == "roten ur")
        {
            // med hjälp av parameter visar vi meddelandet och sparar 
            // valet i double root
            double root = GetNumber("Skriv talet du vill göra rotenur: ");

            if (root < 0)
            {
                // Felmeddelande om rooten är mindren 0
                Console.WriteLine("Du kan inte göra roten ur med ett negativ tal");
                return;
            }
            // Här använder jag en math-funktion för att kunna räkna
            // ut roten ur och sparar det i resultat
            resultat = Math.Sqrt(root);
            Console.WriteLine($"Resultat: {resultat}");
            // Använder history.Add för att lägga i listan för att användaren
            // ska kunna se vad de har gjort
            // I listan visar vi tex rotenur och sedan användarens val av siffra
            // Och till slut resultaten
            history.Add($"{operation} {root} = {resultat}");
            SaveHistory(history, filePath);
            return;


        }
        // Här gör vi samma sak fast använder GetNumberInt och ingen math.funktion
        else if (operation == "%")
        {
            int första = GetNumberInt("Skriv in första talet: ");
            int andra = GetNumberInt("Skriv in andra talet: ");

            if (andra == 0)
            {
                Console.WriteLine("Andra talet kan inte vara 0");
                return;
            }

            resultat = första % andra;
            Console.WriteLine($"Resultat: {resultat}");
            history.Add($"{första} % {andra} = {resultat}");
            SaveHistory(history, filePath);
            return;


        }

        // Skapar en double lista som heter numbers för att kunna spara 
        // på samma sätt som jag har sparat svaret tidigare ovanför
        List<double> numbers = new List<double>();

        // Sparar GetCount metodens inmatning som int i en variabel som heter
        // count
        int count = GetCount();

        // Om användaren väljer "+" så ska denna köras
        if (operation == "+")
        {
            // resultat är startvärdet som sedan loopas och plussas ihop
            resultat = 0;
            // Vi loopar igenom tills användarens val av tal är utförd
            // Alltså användaren får välja hur många tal hen vill använda
            // i int count = GetCount();
            for (int i = 0; i < count; i++)
            {
                // Skriver ut med index för att göra det tydligare
                double number = GetNumber($"Skriv tal {i + 1}:");
                // Lägger till det i numbers listan
                numbers.Add(number);
                resultat += number;
            }
        }
        // samma princip här
        else if (operation == "*")
        {
            // Här har vi istället resultat = 1 för att om vi hade 0
            // Då skulle allt va 0 eftersom 0 * vad som helst är 0
            resultat = 1;
            for (int i = 0; i < count; i++)
            {
                double number = GetNumber($"Skriv tal {i + 1}:");
                numbers.Add(number);
                resultat *= number;

            }
        }
        // Samma princip men här har vi en else if för subtraktion och division
        else if (operation == "-" || operation == "/")
        {
            // Här låter vi användaren välja första talet istället för att 
            // Det ska vara nån fast siffra
            resultat = GetNumber("Skriv tal 1: ");
            // sparar valet i numbers listan
            numbers.Add(resultat);
            // Loopar igenom så många gånger count låter
            for (int i = 1; i < count; i++)
            {
                // Visar användaren vilken siffra de är på för att göra 
                // Det tydligare
                double number = GetNumber($"Skriv tal {i + 1}: ");
                // om "-"
                if (operation == "-")
                {
                    // Lägger till number i listan
                    numbers.Add(number);
                    // Och räknar ut 
                    resultat -= number;
                }
                // Om "/"
                else if (operation == "/")
                {
                    // Om användarens första val av tal är 0 så får hen en fel
                    // meddelande
                    if (number == 0)
                    {
                        Console.WriteLine("Du kan inte dividera med 0!");
                        return;
                    }
                    // Annars räknar vi ut det
                    resultat /= number;
                    // Och lägger i listan
                    numbers.Add(number);
                }
            }
        }


        // Det är här vi visar användarens resultat.
        // Skriver längst här och inte i nån if eller if else statement 
        // För att inte skriva upprepande kod
        Console.WriteLine($"Resultat: {resultat}");
        // Skapar en sträng som visar vald operation alltså "-,+,*,/,roten ur, ^ eller %"
        // Med det som är sparat i numbers listan 
        string expression = string.Join($" {operation} ", numbers);
        // Och det sparar vi i history listan för att användaren ska kunna få tillgång
        // Till det senare.
        history.Add($"{expression} = {resultat}");
        SaveHistory(history, filePath);

    }





}