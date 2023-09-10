using Bussen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussen
{
    public class Personuppgifter
    {
        /// <summary>
        /// Shows a message if user tries to view passengers at bus when no passengers have been added
        /// </summary>
        public static void IngaPassagerare()
        {
            Console.Clear();
            Console.WriteLine("\n\nDet finns inga passagerare än. Var god lägg till passagerare i menyn.");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Menu holding options about personal information
        /// </summary>
        public static void Menyval()
        {
            // Array that holds the menu options
            string[] menuOptionsPrint = new string[] { "\tPersonuppgifter Bussimulator", "\tSe senaste passagerare.", "\tRadera senaste passagerare", "\tSkriv ut aktuella passagerare på bussen.", "\tSe alla busspassagerare", "\tAvsluta" };

            // Variable holding users choice in menu
            int menuSelected = 0;

            while (true)
            {
                // Clear so that only menu shows
                Console.Clear();

                Console.WriteLine();

                // Hides cursor
                Console.CursorVisible = false;

                if (menuSelected == 0)
                {
                    Console.WriteLine("---->  " + menuOptionsPrint[0] + "\tx\n");

                    Console.WriteLine(menuOptionsPrint[1]);

                    Console.WriteLine(menuOptionsPrint[2]);

                    Console.WriteLine(menuOptionsPrint[3]);

                    Console.WriteLine(menuOptionsPrint[4]);

                    Console.WriteLine(menuOptionsPrint[5]);

                }

                else if (menuSelected == 1)
                {
                    Console.WriteLine(menuOptionsPrint[0]);

                    Console.WriteLine("---->  " + menuOptionsPrint[1] + "\tx\n");

                    Console.WriteLine(menuOptionsPrint[2]);

                    Console.WriteLine(menuOptionsPrint[3]);

                    Console.WriteLine(menuOptionsPrint[4]);

                    Console.WriteLine(menuOptionsPrint[5]);

                }

                else if (menuSelected == 2)
                {
                    Console.WriteLine(menuOptionsPrint[0]);

                    Console.WriteLine(menuOptionsPrint[1]);

                    Console.WriteLine("---->  " + menuOptionsPrint[2] + "\tx\n");

                    Console.WriteLine(menuOptionsPrint[3]);

                    Console.WriteLine(menuOptionsPrint[4]);

                    Console.WriteLine(menuOptionsPrint[5]);

                }

                else if (menuSelected == 3)
                {
                    Console.WriteLine(menuOptionsPrint[0]);

                    Console.WriteLine(menuOptionsPrint[1]);

                    Console.WriteLine(menuOptionsPrint[2]);

                    Console.WriteLine("---->  " + menuOptionsPrint[3] + "\tx\n");

                    Console.WriteLine(menuOptionsPrint[4]);

                    Console.WriteLine(menuOptionsPrint[5]);

                }

                else if (menuSelected == 4)
                {
                    Console.WriteLine(menuOptionsPrint[0]);

                    Console.WriteLine(menuOptionsPrint[1]);

                    Console.WriteLine(menuOptionsPrint[2]);

                    Console.WriteLine(menuOptionsPrint[3]);

                    Console.WriteLine("---->  " + menuOptionsPrint[4] + "\tx\n");

                    Console.WriteLine(menuOptionsPrint[5]);
                }

                else
                {
                    Console.WriteLine(menuOptionsPrint[0]);

                    Console.WriteLine(menuOptionsPrint[1]);

                    Console.WriteLine(menuOptionsPrint[2]);

                    Console.WriteLine(menuOptionsPrint[3]);

                    Console.WriteLine(menuOptionsPrint[4]);

                    Console.WriteLine("---->  " + menuOptionsPrint[5] + "\tx\n");
                }

                // Variable holding enter
                var keyPressed = Console.ReadKey();

                // If user press down key and selected option is in array
                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelected != menuOptionsPrint.Length - 1)
                {
                    // Add one to selected menuoption
                    menuSelected++;
                }

                // If user press up key and selected option in in array
                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelected >= 1)
                {
                    // Subtract one to selected menuoption
                    menuSelected--;
                }

                // If user press enter, check menuoption and run method 
                else if (keyPressed.Key == ConsoleKey.Enter)
                {

                    switch (menuSelected)
                    {

                        case 0:

                            // Clear console
                            Console.Clear();

                            // Information to user about GDPR
                            Console.WriteLine("\nPERSONUPPGIFTER OCH GDPR\n");
                            Console.WriteLine("**********************************************************************************************************************\n");
                            Console.WriteLine("Vi på kommunen vill informera om att vi samlar in data om ålder kön och stadsdel när du använder denna bussimulator.\nSyftet är att få fram statistik över vilka som väljer att åka buss för att sedan kunna göra insatser som leder till att fler ska välja bussen.");
                            Console.WriteLine("\nVi samlar endast in information som vi anser nödvändig och vi kommer inte använda informationen till något annat.\nVi kommer inte att lämna din information vidare till en tredje part utan ditt samtycke.\n");
                            Console.WriteLine("\nEnligt GDPR har du rätt att se och radera din information. Detta kan du göra i menyn. Om du vill ändra något så\n raderar du din information och lägger till den på nytt under lägg till passagerare.");
                            Console.WriteLine("\nVi på kommunen uppskattar att du använder vår bussimulator och vi ser till att dina personuppgifter behandlas på ett säkert sätt.");
                            Console.WriteLine("\n**********************************************************************************************************************\n");
                            Console.ReadKey();                          

                            break;

                        case 1:

                            // Runs if there are no passengers 
                            if (Passagerare.totalAntal < 1)
                            {
                                IngaPassagerare();
                                break;
                            }

                            else
                            {

                                // Clear console
                                Console.Clear();

                                // Shows latest added passenger
                                Passagerare personb = Passagerare.passagerare[Passagerare.totalAntal - 1];

                                Console.WriteLine("\n\nÅlder: {0}\nKön: {1}\nStadsdel: {2}\n", personb.Age, personb.Sex, personb.District);

                                Console.ReadKey();

                                break;
                            }

                        case 2:

                            // Runs if there are no passengers 
                            if (Passagerare.totalAntal < 1)
                            {
                                IngaPassagerare();

                                break;
                            }

                            //Removes latest added passenger
                            else
                            {
                         
                            // Clear console
                            Console.Clear();

                            Console.WriteLine("\n*************************************\n");

                            // Variable holding passengers position
                            int plats = Passagerare.totalAntal-1;

                            //Creates a copy of the array with one less position
                            var copy = new Passagerare[Passagerare.passagerare.Length - 1];

                            // Metod som finns i .NET som gör kopia av array. Man vill kopiera från 0 till längden av copy. Börjar med att kopiera från 0 till plats. (0=börja kopiera från, copy=kopiera till, 0=börja kopiera till, plats = element att kopiera)
                            Array.Copy(Passagerare.passagerare, 0, copy, 0, plats);

                            // Fortsätter att kopiera från positionen efter plats till resten.(plats+1 = börja kopiera från, copy=kopiera till, plats=börja kopiera till, Passagerare.passagerare.Length-plats-1= element att kopiera)
                            Array.Copy(Passagerare.passagerare, plats + 1, copy, plats, Passagerare.passagerare.Length - plats - 1);

                            // New array copy
                            Passagerare.passagerare = copy;

                            // Subtract one from totalAntal
                            Passagerare.totalAntal--;

                            // Remove from list passagerareAge
                            Passagerare.passagerareAge.RemoveAt(plats);

                            //Remove from list passagerareSex
                            Passagerare.passagerareSex.RemoveAt(plats);

                            //Remome from list passagerareDistrict
                            Passagerare.passagerareDistrict.RemoveAt(plats);

                            Console.WriteLine("\nPassagerare är nu borttagen. Tryck enter för att gå till menyn.\n");

                            Console.WriteLine("\n*************************************\n");

                            Console.ReadKey();

                            break;

                            }

                        case 3:

                            // Runs if there are no passengers 
                            if (Passagerare.totalAntal < 1)
                            {
                                IngaPassagerare();

                                break;
                            }

                            // Prints all passengers on the bus
                            else
                            {

                             // Asks user for password
                             Console.WriteLine("\nSkriv in lösenord: \n");
                           
                            try
                            {
                                int losen = int.Parse(Console.ReadLine());

                                if (losen == 1234)
                                {
                                    Buss.PrintBuss();
                                }

                                else
                                {
                                    Console.WriteLine("Fel lösenord! Gå tillbaka till menyn och gör nytt val.");

                                    Console.ReadKey();
                                }
                            }

                            catch 
                            {
                                Console.WriteLine("Fel lösenord! Gå tillbaka till menyn och gör nytt val.");
                               
                                Console.ReadKey();

                                break;
                            }
                            
                            break;

                            }

                        case 4:

                            // Runs if there are no passengers 
                            if (Passagerare.totalAntal < 1)
                            {
                                IngaPassagerare();

                                break;
                            }

                            // Prints every passenger that registered
                            else
                            {

                                //Asks user for password
                                Console.WriteLine("\nSkriv in lösenord: \n");
                             
                                try
                                {
                                    int losen = int.Parse(Console.ReadLine());

                                    if (losen == 1234)
                                    {

                                        Console.WriteLine("\nHär kan du se alla passagerare som varit på bussen:\n");
                                        Console.WriteLine("\n**********************************\n");

                                        foreach (Passagerare person in Passagerare.barn)

                                        {
                                            Console.WriteLine("Ålder: {0}\nKön: {1}\nStadsdel: {2}\n", person.Age, person.Sex, person.District);
                                        }

                                        foreach (Passagerare person in Passagerare.skolungdom)

                                        {
                                            Console.WriteLine("Ålder: {0}\nKön: {1}\nStadsdel: {2}\n", person.Age, person.Sex, person.District);
                                        }

                                        foreach (Passagerare person in Passagerare.vuxen)

                                        {
                                            Console.WriteLine("Ålder: {0}\nKön: {1}\nStadsdel: {2}\n", person.Age, person.Sex, person.District);
                                        }

                                        foreach (Passagerare person in Passagerare.pensionar)

                                        {

                                            Console.WriteLine("Ålder: {0}\nKön: {1}\nStadsdel: {2}\n", person.Age, person.Sex, person.District);
                                        }

                                        Console.WriteLine("\n**********************************\n");
                                        Console.ReadKey();

                                        break;

                                    }
                                    else
                                    {
                                        Console.WriteLine("Fel lösenord! Gå tillbaka till menyn och gör nytt val.");

                                        Console.ReadKey();
                                    }
                                }

                                catch
                                {
                                    Console.WriteLine("Fel lösenord! Gå tillbaka till menyn och gör nytt val.");

                                    Console.ReadKey();

                                    break;
                                }

                                break;
                            }

                        case 5:

                            // Back to start
                            Console.WriteLine("Går tillbaka till menyn.");
                            Menu.Run();
                            Console.ReadKey();

                            break;
                    }
                }
            }
        }
    }
}



   
