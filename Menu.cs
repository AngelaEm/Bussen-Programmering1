using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussen
{
    /// <summary>
    /// Class holding the "Bussimulator"-menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Welcomes user and run Menu
        /// </summary>
        public static void Run()
        {
            // Clear so that only message shows
            Console.Clear();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("****************************************\n");
            Console.WriteLine("Välkommen till denna Bussimulator!\n");
            Console.WriteLine("****************************************\n");
            Console.WriteLine("Tryck enter för att komma till menyn...\n");
            Console.ReadKey();

            // Array that holds the menu options
            string[] menuOptions = new string[] { "\tLägg till ny Passagerare", "\tHantera personuppgifter", "\tTotal ålder på bussen", "\tMedelålder på bussen", "\tHitta äldsta passagerare", "\tÅldersgrupper", "\tSortera bussen", "\tVilket kön", "\tStadsdelar", "\tPoke", "\tTa bort passagerare", "\tAvsluta" };

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
                    Console.WriteLine("---->  " + menuOptions[0] + "\tx\n");

                    Console.WriteLine(menuOptions[1]);

                    Console.WriteLine(menuOptions[2]);

                    Console.WriteLine(menuOptions[3]);

                    Console.WriteLine(menuOptions[4]);

                    Console.WriteLine(menuOptions[5]);

                    Console.WriteLine(menuOptions[6]);

                    Console.WriteLine(menuOptions[7]);

                    Console.WriteLine(menuOptions[8]);

                    Console.WriteLine(menuOptions[9]);

                    Console.WriteLine(menuOptions[10]);

                    Console.WriteLine(menuOptions[11]);

                }

                else if (menuSelected == 1)
                {
                    Console.WriteLine(menuOptions[0]);

                    Console.WriteLine("---->  " + menuOptions[1] + "\tx\n");

                    Console.WriteLine(menuOptions[2]);

                    Console.WriteLine(menuOptions[3]);

                    Console.WriteLine(menuOptions[4]);

                    Console.WriteLine(menuOptions[5]);

                    Console.WriteLine(menuOptions[6]);

                    Console.WriteLine(menuOptions[7]);

                    Console.WriteLine(menuOptions[8]);

                    Console.WriteLine(menuOptions[9]);

                    Console.WriteLine(menuOptions[10]);

                    Console.WriteLine(menuOptions[11]);

                }

                else if (menuSelected == 2)
                {
                    Console.WriteLine(menuOptions[0]);

                    Console.WriteLine(menuOptions[1]);

                    Console.WriteLine("---->  " + menuOptions[2] + "\tx\n");

                    Console.WriteLine(menuOptions[3]);

                    Console.WriteLine(menuOptions[4]);

                    Console.WriteLine(menuOptions[5]);

                    Console.WriteLine(menuOptions[6]);

                    Console.WriteLine(menuOptions[7]);

                    Console.WriteLine(menuOptions[8]);

                    Console.WriteLine(menuOptions[9]);

                    Console.WriteLine(menuOptions[10]);

                    Console.WriteLine(menuOptions[11]);

                }

                else if (menuSelected == 3)
                {
                    Console.WriteLine(menuOptions[0]);

                    Console.WriteLine(menuOptions[1]);

                    Console.WriteLine(menuOptions[2]);

                    Console.WriteLine("---->  " + menuOptions[3] + "\tx\n");

                    Console.WriteLine(menuOptions[4]);

                    Console.WriteLine(menuOptions[5]);

                    Console.WriteLine(menuOptions[6]);

                    Console.WriteLine(menuOptions[7]);

                    Console.WriteLine(menuOptions[8]);

                    Console.WriteLine(menuOptions[9]);

                    Console.WriteLine(menuOptions[10]);

                    Console.WriteLine(menuOptions[11]);

                }

                else if (menuSelected == 4)
                {
                    Console.WriteLine(menuOptions[0]);

                    Console.WriteLine(menuOptions[1]);

                    Console.WriteLine(menuOptions[2]);

                    Console.WriteLine(menuOptions[3]);

                    Console.WriteLine("---->  " + menuOptions[4] + "\tx\n");

                    Console.WriteLine(menuOptions[5]);

                    Console.WriteLine(menuOptions[6]);

                    Console.WriteLine(menuOptions[7]);

                    Console.WriteLine(menuOptions[8]);

                    Console.WriteLine(menuOptions[9]);

                    Console.WriteLine(menuOptions[10]);

                    Console.WriteLine(menuOptions[11]);

                }

                else if (menuSelected == 5)
                {
                    Console.WriteLine(menuOptions[0]);

                    Console.WriteLine(menuOptions[1]);

                    Console.WriteLine(menuOptions[2]);

                    Console.WriteLine(menuOptions[3]);

                    Console.WriteLine(menuOptions[4]);

                    Console.WriteLine("---->  " + menuOptions[5] + "\tx\n");

                    Console.WriteLine(menuOptions[6]);

                    Console.WriteLine(menuOptions[7]);

                    Console.WriteLine(menuOptions[8]);

                    Console.WriteLine(menuOptions[9]);

                    Console.WriteLine(menuOptions[10]);

                    Console.WriteLine(menuOptions[11]);

                }

                else if (menuSelected == 6)
                {
                    Console.WriteLine(menuOptions[0]);

                    Console.WriteLine(menuOptions[1]);

                    Console.WriteLine(menuOptions[2]);

                    Console.WriteLine(menuOptions[3]);

                    Console.WriteLine(menuOptions[4]);

                    Console.WriteLine(menuOptions[5]);

                    Console.WriteLine("---->  " + menuOptions[6] + "\tx\n");

                    Console.WriteLine(menuOptions[7]);

                    Console.WriteLine(menuOptions[8]);

                    Console.WriteLine(menuOptions[9]);

                    Console.WriteLine(menuOptions[10]);

                    Console.WriteLine(menuOptions[11]);

                }

                else if (menuSelected == 7)
                {
                    Console.WriteLine(menuOptions[0]);

                    Console.WriteLine(menuOptions[1]);

                    Console.WriteLine(menuOptions[2]);

                    Console.WriteLine(menuOptions[3]);

                    Console.WriteLine(menuOptions[4]);

                    Console.WriteLine(menuOptions[5]);

                    Console.WriteLine(menuOptions[6]);

                    Console.WriteLine("---->  " + menuOptions[7] + "\tx\n");

                    Console.WriteLine(menuOptions[8]);

                    Console.WriteLine(menuOptions[9]);

                    Console.WriteLine(menuOptions[10]);

                    Console.WriteLine(menuOptions[11]);

                }

                else if (menuSelected == 8)
                {
                    Console.WriteLine(menuOptions[0]);

                    Console.WriteLine(menuOptions[1]);

                    Console.WriteLine(menuOptions[2]);

                    Console.WriteLine(menuOptions[3]);

                    Console.WriteLine(menuOptions[4]);

                    Console.WriteLine(menuOptions[5]);

                    Console.WriteLine(menuOptions[6]);

                    Console.WriteLine(menuOptions[7]);

                    Console.WriteLine("---->  " + menuOptions[8] + "\tx\n");

                    Console.WriteLine(menuOptions[9]);

                    Console.WriteLine(menuOptions[10]);

                    Console.WriteLine(menuOptions[11]);

                }

                else if (menuSelected == 9)
                {
                    Console.WriteLine(menuOptions[0]);

                    Console.WriteLine(menuOptions[1]);

                    Console.WriteLine(menuOptions[2]);

                    Console.WriteLine(menuOptions[3]);

                    Console.WriteLine(menuOptions[4]);

                    Console.WriteLine(menuOptions[5]);

                    Console.WriteLine(menuOptions[6]);

                    Console.WriteLine(menuOptions[7]);

                    Console.WriteLine(menuOptions[8]);

                    Console.WriteLine("---->  " + menuOptions[9] + "\tx\n");

                    Console.WriteLine(menuOptions[10]);

                    Console.WriteLine(menuOptions[11]);

                }

                else if (menuSelected == 10)
                {
                    Console.WriteLine(menuOptions[0]);

                    Console.WriteLine(menuOptions[1]);

                    Console.WriteLine(menuOptions[2]);

                    Console.WriteLine(menuOptions[3]);

                    Console.WriteLine(menuOptions[4]);

                    Console.WriteLine(menuOptions[5]);

                    Console.WriteLine(menuOptions[6]);

                    Console.WriteLine(menuOptions[7]);

                    Console.WriteLine(menuOptions[8]);

                    Console.WriteLine(menuOptions[9]);

                    Console.WriteLine("---->  " + menuOptions[10] + "\tx\n");

                    Console.WriteLine(menuOptions[11]);

                }

                else
                {
                    Console.WriteLine(menuOptions[0]);

                    Console.WriteLine(menuOptions[1]);

                    Console.WriteLine(menuOptions[2]);

                    Console.WriteLine(menuOptions[3]);

                    Console.WriteLine(menuOptions[4]);

                    Console.WriteLine(menuOptions[5]);

                    Console.WriteLine(menuOptions[6]);

                    Console.WriteLine(menuOptions[7]);

                    Console.WriteLine(menuOptions[8]);

                    Console.WriteLine(menuOptions[9]);

                    Console.WriteLine(menuOptions[10]);

                    Console.WriteLine("---->  " + menuOptions[11] + "\tx\n");

                }

                // Variable holding enter
                var keyPressed = Console.ReadKey();

                // If user press down key and selected option is in array
                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelected != menuOptions.Length - 1)
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

                            Console.WriteLine("*************************************\n");
                            Buss.AddPassenger();
                            Console.WriteLine("*************************************\n");

                            break;

                        case 1:

                            Console.WriteLine("*************************************\n");
                            Personuppgifter.Menyval();
                            Console.WriteLine("*************************************\n");

                            break;

                        case 2:

                            // Runs if there are no passengers 
                            if (Passagerare.totalAntal < 1)
                            {
                                Personuppgifter.IngaPassagerare();
                                break;
                            }

                            else
                            {
                                int totalAge = Buss.TotalAge(Passagerare.passagerareAge);

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n*************************************\n");
                                Console.WriteLine("Total ålder av passagerare är {0} år.\n", totalAge);
                                Console.WriteLine("*************************************\n");

                                Console.ReadKey();

                                break;

                            }


                        case 3:

                            // Runs if there are no passengers 
                            if (Passagerare.totalAntal < 1)
                            {
                                Personuppgifter.IngaPassagerare();
                                break;
                            }

                            else
                            {

                                double averageAge = Buss.AvarageAge(Passagerare.passagerareAge);

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n*************************************\n");
                                Console.WriteLine("Medelåldern är {0} år.\n", averageAge);
                                Console.WriteLine("*************************************\n");

                                Console.ReadKey();

                                break;

                            }

                        case 4:

                            // Runs if there are no passengers 
                            if (Passagerare.totalAntal < 1)
                            {
                                Personuppgifter.IngaPassagerare();
                                break;
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                int maxAge = Buss.MaxAge(Passagerare.passagerareAge);
                                Console.WriteLine("\n*************************************\n");
                                Console.WriteLine("Den äldsta passageraren är {0} år gammal.\n", maxAge);
                                Console.WriteLine("*************************************\n");

                                Console.ReadKey();

                                break;
                            }

                        case 5:

                            // Runs if there are no passengers 
                            if (Passagerare.totalAntal < 1)
                            {
                                Personuppgifter.IngaPassagerare();
                                break;
                            }

                            else
                            {
                                Buss.AgeGroup();

                                break;
                            }

                        case 6:

                            // Runs if there are no passengers 
                            if (Passagerare.totalAntal < 1)
                            {
                                Personuppgifter.IngaPassagerare();
                                break;
                            }

                            else
                            {
                                Buss.SortBuss();

                                break;
                            }

                        case 7:

                            // Runs if there are no passengers 
                            if (Passagerare.totalAntal < 1)
                            {
                                Personuppgifter.IngaPassagerare();
                                break;
                            }

                            else
                            {

                                Buss.PrintSex(Passagerare.passagerareSex);

                                break;
                            }

                        case 8:

                            // Runs if there are no passengers 
                            if (Passagerare.totalAntal < 1)
                            {
                                Personuppgifter.IngaPassagerare();
                                break;
                            }

                            else
                            {

                                Buss.PrintDistrict();

                                break;
                            }

                        case 9:

                            // Runs if there are no passengers 
                            if (Passagerare.totalAntal < 1)
                            {
                                Personuppgifter.IngaPassagerare();
                                break;
                            }

                            else
                            {

                                Buss.PokePassenger();

                                break;
                            }

                        case 10:

                            Buss.RemovePassenger();

                            break;

                        case 11:

                            Buss.Avsluta();

                            break;

                    }
                }
            }
        }
    }
}
