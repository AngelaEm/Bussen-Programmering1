using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bussen
{
    /// <summary>
    /// Class with properties Age, sex and district
    /// </summary>
    public class Passagerare
    {
        // Properties Passagerare

        public int Age;
        public string Sex;
        public string District;

        public static int totalAntal = 0;

        /// <summary>
        /// Array holding all passengers
        /// </summary>
        public static Passagerare[] passagerare = new Passagerare[25];

        /// <summary>
        /// List holding the passengers ages
        /// </summary>
        public static List<int> passagerareAge = new List<int>();

        /// <summary>
        /// List holding all passengers sexes
        /// </summary>
        public static List<string> passagerareSex = new List<string>();

        /// <summary>
        /// List holding all passengers district
        /// </summary>
        public static List<string> passagerareDistrict = new List<string>();

        /// <summary>
        /// List with all passengers older than 65 years
        /// </summary>
        public static List<Passagerare> pensionar = new List<Passagerare>();

        /// <summary>
        /// List with kids younger than 6
        /// </summary>
        public static List<Passagerare> barn = new List<Passagerare>();

        /// <summary>
        /// List with students
        /// </summary>
        public static List<Passagerare> skolungdom = new List<Passagerare>();

        /// <summary>
        /// List with adults
        /// </summary>
        public static List<Passagerare> vuxen = new List<Passagerare>();
       

        /// <summary>
        /// Konstruktor that runs when we add person 
        /// </summary>
        /// <param name="age"> Passengers age</param>
        /// <param name="sex"> Passengers sex, male/female</param>
        /// <param name="district">Passengers district</param>
        public Passagerare(int age, string sex, string district)
        {
            Age = age;
            Sex = sex;
            District = district;

            passagerareAge.Add(Age);

            passagerareSex.Add(Sex);

            passagerareDistrict.Add(District);

            // Controlls age and adds person to list depending on age
            if (Age > 65)
            {
                pensionar.Add(this);
            }
            else if (Age < 19)
            {
                if (Age > 6)
                {
                   skolungdom.Add(this);
                }

                else
                {
                    barn.Add(this);
                }
            }

            else
            {
                vuxen.Add(this);
            }          
        }
        /// <summary>
        /// Describes what happens when you poke passenger with different ages and different gender
        /// </summary>
        public void Poke()
        {

            if (Age < 10)
            {
                if(Sex == "k" || Sex == "a")
                {
                    Console.Write("Skrattar högt när man petar!\n");
                }
                else
                {
                    Console.Write("Blir sur när man petar!\n");
                }

            }
            else if (Age >= 10 && Age < 45)
            {
                if(Sex == "k")
                {
                    Console.Write("Blir irriterad när man petar!\n");
                }
                else
                {
                    Console.Write("Blir förbannad när man petar!\n");
                }               
            }
            else if (Age >= 65)
            {
                if(Sex == "m")
                {
                    Console.Write("Petar tillbaka när man petar!\n");
                }
                else
                {
                    Console.Write("Skriker när man petar!\n");
                }
            }
            else
            {
                Console.Write("Blir väldigt förbannad när man petar!\n");
            }           
        }
    }
}




