using System;
using System.Linq;
using System.Text;
namespace MyLibrary
{
    //Ny class for Fodboldcase, denne skal tilføjes i program koden ved brug af "using." øverst i koden.
    public class FodboldCase
    {
        //main class kaldet Afleveringer
        public class Afleveringer
        {
            //Private readonly da de kun skal benyttes i denne class
            //Der skal bruges to variabler til at løse opgaven, afleveringer og mål
            private readonly int afleveringer;
            private readonly string mål;

            //subclass Afleveringer, definerer variablerne så de kan hentes som objekt
            public Afleveringer(int afleveringer, string mål)
            {
                //this. indikerer at det er variablerne fra main class der bruges
                this.afleveringer = afleveringer;
                this.mål = mål;

            }

            //Metode JubelScenarier definerer hvad der skal returneres ud fra variablerne
            public string JubelScenarier()
            {

                {
                    //Objektet cheer oprettes som StringBuilder, parantes indikerer hvad
                    //der skal udskrives og hvor mange karakterer den kan indeholde
                    StringBuilder cheer = new StringBuilder("", 100);

                    //hvis pass er mindre end 1, tilføjes teksten "shh!" til StringBuilderen.
                    if (afleveringer < 1)
                    {
                        cheer.Append("shh!");
                    }
                    //Er pass højere end 0 og mindre end 10, tiløjes teksten "huh! " til stringbuilderen
                    //Append tilføjer teksten en ekstra gang for hver ekstra pass.
                    if (afleveringer > 0 & afleveringer < 10)
                    {
                        for (int i = 0; i < afleveringer; i++)
                        {
                            cheer.Append("Huh! ");
                        }
                    }

                    if (afleveringer >= 10)
                    {
                        cheer.Append("High Five!! Jubel!");
                    }

                    if (mål.ToUpper() == "\nMÅL")

                    {
                        cheer.Append("Olé Olé Olé!!!");
                    }

                    if (mål == "nej")
                    {
                        cheer.Append("\nØv! Intet mål.");
                    }

                    return Convert.ToString(cheer);
                }
            }
        }
    }

    //Ny class for DanseCase
    public class DanseCase
    {
        public class DancerPoint
        {
            private readonly string navn;
            private readonly int point;

            public DancerPoint(string navn, int point)
            {
                this.navn = navn;
                this.point = point;
            }

            //metoden returnerer den givne tekst samt de indtastede navne og point.
            public string SamletScoreForDansere()
            {
                return ("Samlet score for " + navn + ": " + point);
            }

            //operator+ lægger variablerne sammen a og b sammen i det nye objekt c, ved + og returnerer c.
            public static DancerPoint operator +(DancerPoint a, DancerPoint b)
            {
                DancerPoint c = new DancerPoint(a.navn + " & " + b.navn, a.point + b.point);
                return (c);
            }
        }
    }

    //Ny class for PasswordCase
    public class PasswordCase
    {
        public class PasswordValidering
        {
            private readonly string password;
            private readonly string brugernavn;

            public PasswordValidering(string password, string brugernavn)
            {
                this.password = password;
                this.brugernavn = brugernavn;
            }

            //Metoden tjekker om passwords længde er 12 eller over.
            //Hvis det er 12 eller over retuerneres true, hvis ikke, returneres en tekst og false
            public bool PasswordCointainsMinimumLength12()
            {
                //Password længde af minimum 12
                if (!(password.Length >= 12))
                {
                    Console.WriteLine("Password skal være på minimum 12 karakterer");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public bool PasswordContainsNoSpaces()
            {
                //tjekker for mellemrum
                if (password.Contains(" "))
                {
                    Console.WriteLine("Password må ikke indeholde mellemrum");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public bool PasswordContainsNumbers()
            {
                //tal fra 0-9
                if (true)
                {

                    int count = 0;
                    //indikerer tal fra 0 til 9
                    for (int i = 0; i <= 9; i++)
                    {
                        //variabel number
                        string number = i.ToString();

                        if (password.Contains(number))

                        {
                            //Variablen count får værdien 1 hvis password indeholder et tal.
                            count = 1;
                        }
                    }

                    //Hvis count forbliver 0 (den værdi variablen er sat til fra staren, og altså ikke indeholder et tal
                    //returneres en given tekst samt false.
                    if (count == 0)
                    {
                        Console.WriteLine("Password skal indeholde mindst ét tal");
                        return false;
                    }
                    //hvis count er alt andet end 0 returneres true.
                    else
                    {
                        return true;
                    }
                }
            }


            public bool PasswordContainsSpecialCharacters()
            {
                //specialtegn
                if
                (!(password.Contains("@") || password.Contains("#")
                || password.Contains("!") || password.Contains("~")
                || password.Contains("$") || password.Contains("%")
                || password.Contains("^") || password.Contains("&")
                || password.Contains("*") || password.Contains("(")
                || password.Contains(")") || password.Contains("-")
                || password.Contains("+") || password.Contains("/")
                || password.Contains(":") || password.Contains(".")
                || password.Contains(",") || password.Contains("<")
                || password.Contains(">") || password.Contains("?")
                || password.Contains("|")))
                {
                    Console.WriteLine("Password skal indeholde mindst ét specialtegn");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public bool PasswordContainsSmallLetters()
            {
                //små bogstaver
                if (!(password.Any(char.IsLower)))
                {
                    Console.WriteLine("Password skal indeholde et eller flere små bogstaver");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public bool PasswordContainsCapitalLetters()
            {

                //store bogstaver
                if (!(password.Any(char.IsUpper)))

                {
                    Console.WriteLine("Password skal indeholde et eller flere store bogstaver!");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public bool PasswordNotSameAsUsername()
            {

                //password må ikke være det samme som brugernavn
                if (this.brugernavn.ToLower() == password.ToLower())
                {
                    Console.WriteLine("Password må ikke være det samme som Brugernavn");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public bool PasswordHasNoNumberFirst()
            {
                //tjekker om tal er i starten
                bool number = false;

                number = int.TryParse(password[0].ToString(), out int a);
                if (number == true)
                {
                    Console.WriteLine("Password må ikke starte med et tal");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public bool PasswordHasNoNumberLast()
            {
                //Tjekker om tal er i slutningen
                bool number = false;
                number = int.TryParse(password[password.Length - 1].ToString(), out int a);
                if (number == true)
                {
                    Console.WriteLine("Password må ikke slutte med et tal");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
