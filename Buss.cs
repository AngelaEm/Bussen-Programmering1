using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bussen
{
    /// <summary>
    /// Class Buss 
    /// </summary>
    class Buss
    {
        /// <summary>
        /// Adds passengers with properties age, sex and district to the bus
        /// </summary>
        public static void AddPassenger()
        {
            // Clear console
            Console.Clear();

            // Iterates maximum 25 times with questions to user
            for (int i = Passagerare.totalAntal; i < 25; i++)
            {
                // Variable holding users age
                int age = 0;

                // Asks about age
                bool loop = true;
                do
                {
                    Console.WriteLine("**********************\n");
                    Console.WriteLine("Hur gammal är du? \n");

                    try
                    {
                        age = int.Parse(Console.ReadLine());
                        loop = false;
                    }

                    catch
                    {
                        Console.WriteLine("\nFel! Skriv endast tal.\n");
                    }

                } while (loop);

                Console.WriteLine("\nTryck enter för att fortsätta.\n");

                // Variable holding users gender
                string sex = Console.ReadLine();

                bool loop2 = true;
                do
                {
                    // Asks abot gender
                    Console.WriteLine("Är du: [k]Kvinna, [m]Man, [a]Annat?\n");

                    try
                    {
                        sex = Console.ReadLine();

                        if (sex == "k" || sex == "K" || sex == "m" || sex == "M" || sex == "a" || sex == "A")
                        {
                            loop2 = false;
                        }
                        else
                        {
                            Console.WriteLine("\nFel! Välj mellan [k]Kvinna, [m]Man, [a]Annat?\n");
                        }
                    }

                    catch
                    {
                        Console.WriteLine();
                    }

                } while (loop2);

                // Asks user about district                  
                Console.WriteLine("\nVar bor du?\n");

                //Variable holding users answer
                string district = Console.ReadLine();

                Console.WriteLine();

                // Passenger object with properties age, sex and district                   
                Passagerare person = new Passagerare(age, sex, district);

                // Array holding all the persons                   
                Passagerare.passagerare[i] = person;

                // Adds one passenger to the total number of passengers                  
                Passagerare.totalAntal++;

                // Asks if user wants to add another passenger                    
                if (i < 26)

                {
                    Console.WriteLine("Vill du lägga till ytterligare en passagerare? j/n\n");

                    // Variable holding users answer
                    string svar = Console.ReadLine();

                    // Runs if user wants to add one more passenger                       
                    if (svar == "j" || svar == "J")

                    {
                        // Runs if user try to add more than 25 passengers                          
                        if (Passagerare.totalAntal >= 25)
                        {
                            Console.WriteLine("Det är tyvärr fullt på bussen nu.\n");
                            Console.ReadKey();
                        }

                        Console.WriteLine();
                    }

                    // Runs if user does not want to add another passenger

                    else if (svar == "n" || svar == "N")
                    {

                        break;

                    }

                    // Lets user know if answer is not correct                       
                    else
                    {

                        Console.WriteLine("Ogiltigt val\n");
                        Console.ReadKey();

                        break;

                    }
                }
                else
                {
                    Console.WriteLine("\nDet är tyvärr fullt på bussen nu.");
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Prints every added passenger
        /// </summary>
        public static void PrintBuss()
        {

            //Variable holding a number for each passenger
            int n = 1;

            // Prints every person in array passenger
            for (int i = 0; i < Passagerare.totalAntal; i++)

            {
                Passagerare person = Passagerare.passagerare[i];

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n**********************************\n");
                Console.WriteLine("Passagerare " + n + ":");
                Console.WriteLine("Ålder: {0}\nKön: {1}\nStadsdel: {2}\n", person.Age, person.Sex, person.District);

                // Add one 
                n++;
            }

            Console.ReadKey();


        }

        /// <summary>
        /// Prints total age of all passengers at the bus
        /// </summary>
        /// <param name="passagerareAge"> list with passengers ages </param>
        /// <returns> Total age </returns>
        public static int TotalAge(List<int> passagerareAge)
        {
            // Clear console
            Console.Clear();

            // Variable holding total age
            int totalAge = 0;

            // Adds passengers age for every number in list passagerareAge
            for (int i = 0; i < passagerareAge.Count; i++)
            {
                totalAge += passagerareAge[i];
            }

            // Returns total age
            return totalAge;
        }

        /// <summary>
        /// Calculate average age
        /// </summary>
        /// <param name="passagerareAge"> list with passanger ages </param>
        /// <returns> Average age </returns>
        public static double AvarageAge(List<int> passagerareAge)
        {
            // Clear console
            Console.Clear();

            // Variable holdigt total age
            int totalAge = TotalAge(passagerareAge);

            // The denominator must never be zero
            if (passagerareAge.Count == 0)
            {
                return 0.0;
            }

            // Calculate average age
            double averageAge = (double)totalAge / passagerareAge.Count;

            // Return average age
            return averageAge;
        }

        /// <summary>
        /// Shows age of oldest passenger
        /// </summary>
        /// <param name="passagerareAge"> List with passenger ages </param>
        /// <returns> Max age </returns>
        public static int MaxAge(List<int> passagerareAge)
        {
            // Clear console
            Console.Clear();

            // Variable holding max age
            int maxAge = 0;

            // Iterates trough list with passengers to find the oldes passenger
            for (int i = 0; i < passagerareAge.Count; i++)
            {
                // Passenger age
                int age = passagerareAge[i];

                // If age is more than maxAxe this runs
                if (age > maxAge)
                {
                    maxAge = age;
                }
            }

            // Return maxAge
            return maxAge;
        }

        /// <summary>
        /// Prints passangers in same agegroup. 
        /// </summary>            
        public static void AgeGroup()
        {
            // Clear console
            Console.Clear();

            // Menu with choises
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n*************************************\n");

                Console.WriteLine("Se alla [b]arn på bussen\n");
                Console.WriteLine("Se alla [s]kolungdomar på bussen\n");
                Console.WriteLine("Se alla [v]uxna på bussen\n");
                Console.WriteLine("Se alla [p]ensionärer på bussen\n");

                Console.WriteLine("\n*************************************\n");

                // Variable with users menuchoice
                string meny = Console.ReadLine();

                // Prints "barn"
                if (meny == "b" || meny == "B")
                {
                    Console.WriteLine("\nHär kan du se alla barn som är på bussen:\n");

                    foreach (Passagerare person in Passagerare.barn)

                    {
                        Console.WriteLine("\n**********************************\n");
                        Console.WriteLine("Ålder: {0}\nKön: {1}\nStadsdel: {2}\n", person.Age, person.Sex, person.District);
                    }

                    Console.ReadKey();

                    break;
                }

                // Prints "skolungdomar"
                else if (meny == "s" || meny == "S")
                {
                    Console.WriteLine("\nHär kan du se alla skolungdomar som är på bussen:\n");

                    foreach (Passagerare person in Passagerare.skolungdom)

                    {
                        Console.WriteLine("\n**********************************\n");
                        Console.WriteLine("Ålder: {0}\nKön: {1}\nStadsdel: {2}\n", person.Age, person.Sex, person.District);
                    }

                    Console.ReadKey();

                    break;
                }

                // Prints "vuxna"
                else if (meny == "v" || meny == "V")

                {
                    Console.WriteLine("\nHär kan du se alla vuxna som är på bussen:\n");

                    foreach (Passagerare person in Passagerare.vuxen)

                    {
                        Console.WriteLine("\n**********************************\n");
                        Console.WriteLine("Ålder: {0}\nKön: {1}\nStadsdel: {2}\n", person.Age, person.Sex, person.District);
                    }

                    Console.ReadKey();

                    break;
                }

                // Prints pensionärer
                else if (meny == "p" || meny == "P")
                {
                    Console.WriteLine("\nHär kan du se alla pensionärer som är på bussen:\n");

                    foreach (Passagerare person in Passagerare.pensionar)

                    {
                        Console.WriteLine("\n**********************************\n");
                        Console.WriteLine("Ålder: {0}\nKön: {1}\nStadsdel: {2}\n", person.Age, person.Sex, person.District);
                    }

                    Console.ReadKey();

                    break;
                }

                // If user writes wrong letter
                else
                {
                    Console.WriteLine("Ogiltigt val");

                    Console.ReadKey();

                    break;
                }
            }
        }

        /// <summary>
        /// Sorts the list of passanger ages from low number to high number.
        /// </summary>
        public static void SortBuss()
        {
            // Clear console
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n*************************************\n");

            // Variable with max index of the list. This is the number of times to iterate through the list
            int max = Passagerare.passagerareAge.Count - 1;

            // The outher loop iterating through the list
            for (int i = 0; i < max; i++)
            {
                // Variable holding the ages left to sort
                int nrLeft = max - i;

                // Inner loop comparing ages 
                for (int j = 0; j < nrLeft; j++)
                {
                    // If age in left index is greater than age to the right swap them
                    if (Passagerare.passagerareAge[j] > Passagerare.passagerareAge[j + 1])
                    {
                        // Variable holding the left value temporary
                        int temp = Passagerare.passagerareAge[j];

                        // Swap values
                        Passagerare.passagerareAge[j] = Passagerare.passagerareAge[j + 1];
                        Passagerare.passagerareAge[j + 1] = temp;
                    }
                }
            }

            // Writes message about the sorted ages

            Console.WriteLine("\nPassagerarnas ålder i storleksordning:\n");

            // Iterates through the sorted list and writes all ages
            for (int i = 0; i < Passagerare.passagerareAge.Count; i++)
            {
                Console.Write(Passagerare.passagerareAge[i]);
                Console.Write(" | ");
            }

            Console.WriteLine();
            Console.WriteLine("\n*************************************\n");
            Console.ReadKey();
        }

        /// <summary>
        /// Prints passengers genders
        /// </summary>
        public static void PrintSex(List<string>passagerareSex)
        {
            // Clear console
            Console.Clear();

            // Explains that k means kvinna, m means man and a means annat.
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n*************************************\n");
            Console.WriteLine("K: Kvinna");
            Console.WriteLine("M: Man");
            Console.WriteLine("A: Annat\n");

            int n = 1;

            // Prints passenger gender
            foreach (var sex in passagerareSex)
            {
                Console.WriteLine("Passagerare {0}: {1}", n, sex);
                n++;
            }

            Console.WriteLine("\n*************************************\n");
            Console.ReadKey();
        }

        /// <summary>
        /// Prints passengers district
        /// </summary>
        public static void PrintDistrict()
        {
            // Clear console
            Console.Clear();

            Console.WriteLine("\n*************************************\n");

            // Prints passengers district
            for (int i = 0; i < Passagerare.passagerareDistrict.Count; i++)
            {
                Console.WriteLine("Passagerare {0} bor här : {1}.\n", i + 1, Passagerare.passagerareDistrict[i]);
            }

            Console.WriteLine("\n*************************************\n");
            Console.ReadKey();
        }

        /// <summary>
        /// Tells users reaction if you poke them
        /// </summary>
        public static void PokePassenger()
        {
            Console.Clear();

            int n = 1;

            Console.WriteLine("\n*************************************\n");

            // For every passenger 
            for (int i = 0; i < Passagerare.totalAntal; i++)

            {
                // Person in array passagerare
                Passagerare person = Passagerare.passagerare[i];

                // Tells what happens when you poke that person
                Console.Write("\nPerson {0} reagerar så här:\n", n);
                person.Poke();
                n++;

            }

            Console.WriteLine("\n*************************************\n");
            Console.ReadKey();
        }

        /// <summary>
        /// Remove passenger from array
        /// </summary>
        public static void RemovePassenger()

        {
            // Clear console
            Console.Clear();

            Console.WriteLine("\n*************************************\n");

            // Runs if number of passengers is more than zero
            if (Passagerare.totalAntal > 0)
            {
                // Variable holding passengers position
                int plats = 0;

                try
                {
                    // Asks which passenger to remove
                    Console.WriteLine("\nFrån vilket säte 0-24 vill du ta bort en passagerare?\n");

                    // Users choice
                    plats = int.Parse(Console.ReadLine());

                    // Runs if there is no passenger on users choice
                    if (plats > Passagerare.totalAntal - 1)
                    {
                        Console.WriteLine("\nDet finns ingen passagerare på detta säte. Testa ett lägre nummer.\n");
                        Console.ReadKey();
                    }

                    else
                    {
                        // Creates a copy of the array with one less position
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
                    }
                }

                catch
                {
                    Console.WriteLine("\nOgiltigt val! Skriv in ett tal mellan 0 och 24.\n");
                    Console.ReadKey();
                }
            }

            else
            {
                Console.WriteLine("\nDet finns inga passagerare på bussen än! Fyll på passagerare i menyn.\n");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Finish the bus-simulator
        /// </summary>
        public static void Avsluta()
        {
            Console.Clear();
            Console.WriteLine("\n*************************************\n");
            Console.WriteLine("Programmet avslutas!");
            Console.WriteLine("\n*************************************\n");
            Console.ReadKey();
            Environment.Exit(1);

        }
    }
}
   


