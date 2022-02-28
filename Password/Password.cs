using System;
using System.IO;
using static MyLibrary.PasswordCase;



namespace PasswordCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //opretter en path hvor teksfilen skal oprettes
            string path = @"C:\Users\rasnie\Documents\Password.txt";
            Console.WriteLine("Opret brugernavn:");

            //Skriver en tekst til tekstfilen
            File.WriteAllText(path, "Oversigt over oprettede brugere i databasen");

            string brugernavn = Console.ReadLine();
            //Tilføjer brugerens input af brugernavn til tekstfilen (NewLine tilføjer en ny linje i filen
            File.AppendAllText(path, Environment.NewLine);
            File.AppendAllText(path, brugernavn);

            //Udskriver tekst der fortæller bruger hvad password skal opfylde
            Console.WriteLine("\n\nPassword skal opfylde følgende krav:\nSkal indeholde minimum 12 tegn/bogstaver\nSkal indeholde minimum ét tal\nSkal indeholde minimum ét specialtegn\nSkal indeholde både små og store bogstaver\nMå ikke indeholde mellemrum\nMå ikke indeholde et tal i starten og i slutningen\nMå ikke være det samme som dit brugernavn\n\nOpret password:  ");
            string password = Console.ReadLine();

            PasswordValidering pass2 = new PasswordValidering(password, brugernavn);

            //Laver kontrolstruktur if else, for at tjekke om passworded lever op til kravene
            //Hvis alle krav er true oprettes password og tilføjer det til tekstfilen.
            //Hvis ikke fortæller den hvilke krav passwordet ikke levede op til.
            if (pass2.PasswordCointainsMinimumLength12() == true & pass2.PasswordContainsNoSpaces() == true &
                    pass2.PasswordContainsNumbers() == true & pass2.PasswordContainsSpecialCharacters() == true &
                    pass2.PasswordContainsSmallLetters() == true & pass2.PasswordContainsCapitalLetters() == true &
                    pass2.PasswordNotSameAsUsername() == true & pass2.PasswordHasNoNumberFirst() == true &
                    pass2.PasswordHasNoNumberLast() == true)
            {
                File.AppendAllText(path, Environment.NewLine);
                File.AppendAllText(path, password);
                Console.WriteLine("Din bruger er oprettet i databasen");
            }
            else
            {
                Console.WriteLine("\n\nPassword opfylder ikke ovenstående kriterier. Prøv igen:\n");
            }


            //Når brugernavn og password er oprettet, bedes man logge ind.
            Console.WriteLine("Log ind på bruger\nBrugernavn: ");
            var usr = Console.ReadLine();
            Console.WriteLine("Password: ");
            var pswrd = Console.ReadLine();

            //Laver et string array "lines", som læser henholdsvis linje 1 og 2 i tekstfilen.
            string[] lines = File.ReadAllLines(path);
            string user = lines[1];
            string pass = lines[2];

            //kontrolerer om det indtastede stemmer overens med den oprettede bruger
            //Hvis true logges der ind.
            //Hvis ikke får man en besked på at bruger eller password er forkert.
            if (usr == user & pswrd == pass)
            {
                Console.WriteLine("\nLogget ind");
            }
            else
            {
                Console.WriteLine("Brugernavn eller password er ukorrekt");
            }
            Console.ReadLine();


        }
    }
}
