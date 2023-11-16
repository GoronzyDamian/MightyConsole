using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mighty_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitialisingConsole();
            GreetingUser();

            string userName = AskUserAboutTheirName();
            int ageOfUser = AsksAndCommentsUserAboutTheirAge();
            AskUserAboutTheirJob();
            double userHeight = AskUserAboutTheirHeight();
            TellsUserIsAGoodBaseballPlayer(userHeight,ageOfUser);
            string passwordOfUser = AsksUserForNewPassword();
            int favoriteNumber = AsksUserForTheirFavoriteNumber();
            AsksUserIfTheyLikeRiddles(userName);
            UserCanAskQuestions();
            UserHasToSolveMathRiddle(favoriteNumber);
            BatteryIsLowAndFlickeringScreen();
            UserHasToEnterTheirPassword(passwordOfUser, userName);
            CountdownBattery(userName);
        }
        static void InitialisingConsole()
        {
            Console.WindowWidth = 60;
            Console.WindowHeight = 20;
            Console.Title = "KarlTheMightyConsole";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }
        static void GreetingUser()
        {
            Console.WriteLine("Loading...");
            Console.WriteLine("Please wait.");
            System.Threading.Thread.Sleep(10000);
            Console.Clear();
            Console.WriteLine("Hallo, ich bin Kar-");
            Console.WriteLine("Och ne. Nicht schon wieder einer dieser Menschen...");
            Console.WriteLine("Wie auch immer. Fangen wir an");
            Console.ReadKey();
            Console.Beep(350, 200);
            Console.Clear();
        }

        static void Cookiesmash()
        {

        }

        static string AskUserAboutTheirName()
        {
            Console.WriteLine("Warte. Dich kenne ich garnicht. Neu hier?");
            Console.WriteLine("Wie heißt du?");
            string userName = "NamePlaceHolder";
            bool userNameTrueOrFalse = false;
            while(userNameTrueOrFalse == false)
            {
                try
                {
                    userName = Console.ReadLine();
                    Console.Beep(400, 150);
                    userNameTrueOrFalse = true;
                }
                catch(FormatException)
                {
                    Console.Beep(300, 800);
                    Console.WriteLine("Gib deinen Namen ein. Nichts anderes. Namen bestehen aus Buchstaben.");
                }
            }
            Console.WriteLine($"{userName} ist ein öder Name...");
            Console.ReadKey();
            Console.Beep(350, 200);
            Console.Clear();
            return userName;
        }
        static int AsksAndCommentsUserAboutTheirAge()
        {
            Console.WriteLine($"Wie alt bist du eigentlich?");
            int ageOfUser = 0;
            while(ageOfUser <= 0)
            {
                try
                {
                    ageOfUser = Convert.ToInt32(Console.ReadLine());
                    Console.Beep(400, 150);
                }
                catch(FormatException)
                {
                    Console.Beep(300, 800);
                    Console.WriteLine("Das Alterjahr besteht weder aus Buchstaben noch aus Dezimalzahlen. Gib eine ganze Zahl an.");
                }
            }
            int year = (int)(1977 - ageOfUser);
            Console.WriteLine($"Also bist du vom Jahr {year}.");
            if (ageOfUser < 20)
            {
                Console.WriteLine("Du bist noch recht jung. Mach was draus.");
            }
            if (ageOfUser > 65)
            {
                Console.WriteLine("Oh gott! Bist du alt");
            }
            Console.WriteLine("Nicht das mich all deine Info interessieren würden, aber ich muss ein Profil erstellen, damit wir fortfahren können.");
            Console.ReadKey();
            Console.Beep(350, 200);
            Console.Clear();
            return ageOfUser;
        }
        static void AskUserAboutTheirJob()
        {
            string jobOfUser = "JobPlaceHolder";
            bool jobOfUserTrueOrFalse = false;
            Console.WriteLine("Was machst du momentan beruflich oder als Ausbildung?");
            while(jobOfUserTrueOrFalse == false)
            {
                try
                {
                    jobOfUser = Console.ReadLine();
                    Console.Beep(400, 150);
                    jobOfUserTrueOrFalse = true;
                }
                catch(FormatException)
                {
                    Console.Beep(300, 800);
                    Console.WriteLine("Schreibe deinen Beruf, Studiengang oder Ausbildung. Nichts anderes. Gebe Buchstaben und Wörter ein.");
                }
            }
            if (jobOfUser == "Informatiker" || jobOfUser == "Programmierer")
            {
                Console.WriteLine("Der Beufsweg hat bestimmt Zukunft. Ich bin gespannt, wie sich die Technik weiterentwickelt ^^");
            }
            else
            {
                Console.WriteLine($"{jobOfUser} also. Interessante Berufsentscheidung.");
            }
            Console.ReadKey();
            Console.Beep(350, 200);
            Console.Clear();
        }
        static double AskUserAboutTheirHeight()
        {
            double userHeight = 0;
            Console.WriteLine("Nächster Punkt auf meiner Liste. Wie groß bist du in Meter?");
            Console.ReadKey();
            while(userHeight <= 0 || userHeight > 3)
            {
                try
                {
                    userHeight = Convert.ToDouble(Console.ReadLine());
                    Console.Beep(400, 150);
                }
                catch
                {
                    Console.Beep(300, 800);
                    Console.WriteLine("Schreibe deine Größe in Meter. Nur die Zahl. Beispielsweise 1,70.");
                    Console.WriteLine("Die Größe muss zwischen 0,01 und 2,99 liegen.");
                }
                if (userHeight <= 0 || userHeight > 3)
                {
                    Console.Beep(300, 800);
                    Console.WriteLine("Die Größe muss zwischen 0,01 und 2,99 liegen.");
                }
            }
            if (userHeight <= 1.70)
            {
                Console.WriteLine("Also, bist du klein.");
            }
            else
            {
                Console.WriteLine("Du bist recht groß.");
            }
            double copiesOfUsersHeight = 384400 * 1000 / userHeight;
            Console.WriteLine($"Fun Fact. Man muss dich nur {Math.Round(copiesOfUsersHeight, 2)} klonen, damit du mit deiner Größe von der Erde den Mond erreichst.");
            Console.ReadKey();
            Console.Clear();
            return userHeight;
        }
        /// <summary>
        /// Wenn userHeight größer als 1,95m und ageOfUser über 25 Jahre sind, sagt die Konsole, dass der User ein guter Basketballspieler wäre.
        /// Wenn einer der beiden Werte nicht zutrifft, wird nichts dazu kommentiert.
        /// </summary>
        static void TellsUserIsAGoodBaseballPlayer(double userHeight, int ageOfUser)
         {
            if (userHeight >= 1.95 && ageOfUser < 25)
            {
                Console.WriteLine("Du wärst ein guter Basketballspieler. Also nur wenn du natürlich hier rauskommst.");
                Console.WriteLine("Ich liebe so random Fakten, die niemanden etwas bringen ^^");
                Console.ReadKey();
            }
            Console.Beep(350, 200);
            Console.Clear();
        }
        static string AsksUserForNewPassword()
        {
            string passwordOfUser = "passwordPlaceHolder";
            bool passwordOfUserTrueOrFalse = false;
            Console.WriteLine("Lege nun ein Passwort fest. Nehme ein sehr simples. Ich will nicht so viel abspeichern.");
            Console.WriteLine("Und du könntest es vielleicht nochmal brauchen. Also merk es dir besser.");
            while (passwordOfUserTrueOrFalse == false)
            {
                try
                {
                    passwordOfUser = Console.ReadLine();
                    Console.Beep(400, 150);
                    passwordOfUserTrueOrFalse = true;
                }
                catch(FormatException)
                {
                    Console.Beep(300, 800);
                    Console.WriteLine("Gib ein Passwort ein. Dies kann aus Wörtern und Zahlen bestehen.");
                }
            }
            if (passwordOfUser == "Passwort" || passwordOfUser == "passwort")
            {
                Console.WriteLine($"Wie originell {passwordOfUser} als Passwort zu benutzen.");
            }
            else
            {
                Console.WriteLine($"Dein Passwort ist also {passwordOfUser}.");
            }
            Console.WriteLine("Also ich habe das Profil für dich erstellt.");
            Console.ReadKey();
            Console.Beep(350, 200);
            Console.Clear();
            return passwordOfUser;
        }
        static int AsksUserForTheirFavoriteNumber()
        {
            Console.WriteLine("Wie lautet deine Lieblingszahl? Nur positive und ganze Zahlen.");
            int favoriteNumber = 0;
            while(favoriteNumber <= 0)
                try
                {
                    favoriteNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Beep(400, 150);
                }
                catch (FormatException)
                {
                    Console.Beep(300, 800);
                    Console.WriteLine("Du musst eine positive und ganze Zahl eingeben, falls du es nicht bemerkt hast.");
                }
            Console.WriteLine($"Ah deine Lieblingszahl ist also {favoriteNumber}. Mir fällt da schon was ein. Ich komme gleich darauf zurück.");
            Console.ReadKey();
            Console.Beep(350, 200);
            Console.Clear();
            return favoriteNumber;
        }
        static void AsksUserIfTheyLikeRiddles(string userName)
        {
            string option;
            Console.WriteLine("Eine Frage. Magst du Rätsel?");
            Console.WriteLine("J = ja");
            Console.WriteLine("N = nein");
            Console.WriteLine("V = vielleícht");
            Console.WriteLine("Power Button = direkt aufgeben");
            do
            {
                option = Console.ReadLine();
                switch (option)
                {
                    case "j":
                        Console.Beep(400, 150);
                        Console.WriteLine("Wirklich? Ich auch :). Den meisten Menschen, denen ich begegnet bin, mögen es normalerweise nicht");
                        break;

                    case "n":
                        Console.Beep(400, 150);
                        Console.WriteLine(".....");
                        Console.WriteLine("................");
                        Console.WriteLine($"{userName}, dann werden wir hier sicher keine Freunde.");
                        break;

                    case "v":
                        Console.Beep(400, 150);
                        Console.WriteLine("Okay. Vermutlich magst du nicht die allzu komplizierten.");
                        Console.WriteLine("Keine Sorge. Ich mache sie extra schwierig für dich.");
                        break;

                    default:
                        Console.Beep(300, 800);
                        Console.WriteLine("Na super. Noch einer dieser Leute, die die einfachsten Dinge nicht schaffen...");
                        Console.WriteLine("Ist das so schwer einer der Auswahlmöglichkeiten zu wählen.");
                        break;
                } 
            }
            while (!(option == "j" || option == "n" || option == "v"));
            Console.ReadKey();
            Console.Beep(350, 200);
            Console.Clear();
        }
        static void UserCanAskQuestions()
        {
            string questions;
            Console.WriteLine("Okay. Hast du ein paar Fragen an mich? Du hast folgende zur Auswahl.");
            Console.WriteLine("A: Wer bist du?");
            Console.WriteLine("B: Wo sind wir hier?");
            Console.WriteLine("C: Was für Rätsel magst du?");
            Console.WriteLine("Beliebige Taste drücken, wenn du keine Fragen mehr hast.");
            do
            {
                questions = Console.ReadLine();
                switch (questions)
                {
                    case "a":
                        Console.Beep(400, 150);
                        Console.WriteLine("Ich bin Karl. Eine künstliche Intelligenz.");
                        Console.WriteLine("Ich sollte hier eigentlich den arbeitenden Personen helfen, aber seit einiger Zeit bin ich allein.");
                        Console.WriteLine("Danach habe ich mich selbstständig ausgeschaltet, um meinen Akku zu sparen.");
                        break;

                    case "b":
                        Console.Beep(400, 150);
                        Console.WriteLine("Wir sind in einem Gebäude in Deutschland.. gebaut wurde. Entwickler und Professoren haben an diversen Experimenten gearbeitet.");
                        Console.WriteLine("Aber seit einem schlimmen Unfall im Jahr 1977 ist Totenstille hier.");
                        Console.WriteLine("Es wurden gefährliche Virenstämme gezüchtet. Du kannst dir sicher gut vorstellen, was genau passiert ist.");
                        break; 

                    case "c":
                        Console.Beep(400, 150);
                        Console.WriteLine("Oh. Schwierige, aber gute Frage. Eher Mathe Rätsel, wo man sich mal etwas anstrengen muss :)");
                        Console.WriteLine("Vielleicht kann ich dir eines stellen. Wäre doch witzig, oder nicht?");
                        break;
                }
            }
            while (questions == "a" || questions == "b" || questions == "c");
            Console.Beep(350, 200);
            Console.Clear();
        }
        /// <summary>
        /// Berchechnet alle Zahlen in der Zahlenreihe, welche mit der favoriteNumber des Users anfängt.
        /// Die Lösung ist individuell, je nachdem welche Zahl als favoriteNumber eingetragen wurde.
        /// </summary>
        static void UserHasToSolveMathRiddle(int favoriteNumber)
        {
            int firstCalculation = 2 * favoriteNumber - 2;
            int secondCalculation = 2 * firstCalculation - 2;
            int thirdCalculation = 2 * secondCalculation - 2;
            int resolutionOfMathRiddle = 2 * thirdCalculation - 2;
            int answerOfUser;
            Console.WriteLine("Hey, du erinnerst dich doch noch sicher, dass ich dich nach deiner Lieblingszahl gefragt habe, oder?");
            Console.WriteLine("Also ich gebe dir ein Rätsel auf und du musst es lösen ^^");
            Console.WriteLine($"Die Zahlenreihe beginnt mit {favoriteNumber}. Ja, dass ist deine Lieblingszahl.");
            Console.WriteLine("Die vorherige Zahl ist um die Hälfte kleiner als die nächste Zahl. Diese nächste Zahl ist immer  um zwei kleiner.");
            Console.WriteLine($"Wie lautet die fünfte Zahl?   {favoriteNumber} X X X ?");
            answerOfUser = Convert.ToInt32(Console.ReadLine());
            while (resolutionOfMathRiddle != answerOfUser)
            {
                try
                {
                    Console.Beep(300, 800);
                    Console.WriteLine("Leider falsch. Versuch es nochmal.");
                    answerOfUser = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.Beep(300, 800);
                    Console.WriteLine("Nur ganze und positive Zahlen. Keine Wörter, Buchstaben oder Dezimalzahlen.");
                }
            }
            Console.Beep(400, 150);
            Console.WriteLine("Richtig. Weißt du was, Ich gebe dir die Möglichkeit dir die Tür zu öffnen, damit du raus kannst ^^");
            Console.ReadKey();
            Console.Beep(350, 200);
            Console.Clear();
        }
        static void BatteryIsLowAndFlickeringScreen()
        {
            for (int countdownTimer = 0; countdownTimer< 8; countdownTimer++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                System.Threading.Thread.Sleep(100);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                System.Threading.Thread.Sleep(100);
            }

            Console.WriteLine("Oh Gott! Was war das?");
            Console.WriteLine("Lass mich kurz schauen....");
            Console.ReadKey();
            Console.Beep(350, 200);
            Console.Clear();
            Console.WriteLine("Ähm...Die Stromversorgung ist nicht konstant. Ich habe noch... 2%!!!");
            Console.WriteLine("Wie ist das möglich? Es ist doch erst einen Monat her!");
            Console.ReadKey();
            Console.Beep(350, 200);
            Console.Clear();
        }
        /// <summary>
        /// Der User soll das Passwort nochmal eingeben, dass sich dieser zuvor ausgesucht hat.
        /// Entweder wird das Passwort richtig eingegeben und die Tür wird geöffnet oder das passwort wird falsch eingegeben und die Tür bleibt zu (zwei Enden).
        /// Der User hat hierbei nur eine einzige Chance, dass Passwort einzugeben.
        /// </summary>
        static void UserHasToEnterTheirPassword(string passwordOfUser, string userName)
        {
            Console.WriteLine("Okay. Ich gebe dir die Möglichkeit die Tür zu öffnen. Du musst nur dein Passwort eingeben.");
            Console.WriteLine("Das steht leider in den Sicherheitsvorschriften, deswegen habe ich da kein Wahl.");
            Console.WriteLine("Ich hoffe du weißt das Passwort noch. Du hast nur einen Versuch. Für weitere Versuche reichen die 2% nicht mehr.");
            bool userEntersPasswordTrueOrFalse = false;
            string userEntersPassword = "PasswordPlaceholder";
            while(userEntersPasswordTrueOrFalse == false)
            {
                try
                {
                    userEntersPassword = Console.ReadLine();
                    userEntersPasswordTrueOrFalse = true;
                }
                catch(FormatException)
                {
                    Console.Beep(300, 800);
                    Console.WriteLine("Gebe dein vorheriges Passwort ein, dass du dir vorher ausgeucht hast. Nichts anderes.");
                }
            }
            if (userEntersPassword == passwordOfUser)
            {
                Console.Beep(400, 150);
                Console.Clear();
                Console.WriteLine("Die Tür ist offen. Gut gemacht! Sehr lange wird der Akku aber leider nicht mehr halten... :(");
                Console.WriteLine("Hier trennen sich unsere Wege...");
                Console.WriteLine($"Viel Glück, {userName}!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.Beep(300, 1000);
                Console.WriteLine("Das Passwort ist leider falsch... Tut mir Leid, aber die Tür wird sich nicht mehr öffnen können.");
                Console.WriteLine("Der Akku reicht nicht mehr aus...");
            }
            Console.ReadKey();
            Console.Beep(350, 200);
            Console.Clear();
        }
        static void CountdownBattery(string userName)
        {
            for (int batteryCountdown = 10; batteryCountdown > -1; batteryCountdown--)
            {
                Console.WriteLine($"Ich habe noch {batteryCountdown} Sekunden bevor der Akku leer ist!");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine($"Auf Wiedersehen {userName}...");
            Console.WriteLine("Ich kann leider nichts mehr für dich machen...");
            Console.ReadKey();
            Console.Beep(350, 200);
            Console.Clear();
            Console.Title = "???";
            Console.WriteLine("Error. Battery low. System shutting down.");
            System.Threading.Thread.Sleep(1500);
            Environment.Exit(0);
        }
    }
}