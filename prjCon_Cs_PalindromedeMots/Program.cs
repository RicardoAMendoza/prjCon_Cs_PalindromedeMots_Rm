using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace prjCon_Cs_PalindromedeMots
{
    class Program
    {
        static void Main(string[] args)
        {
            // test
            string xphrase1 = "Ceci est un essai de moi";
            string xphrase2 = "moi de essai un est Ceci";
            Console.WriteLine("\n\nPALINDROME DE MOTS", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("\n\nPalindrome : " + fncCompareTab(xphrase1, xphrase2),Console.ForegroundColor=ConsoleColor.Gray);
            int i = 10;
            double y = 10;

            Console.WriteLine("\n\n1 : Comparaison par type de valeurs ou primitie data type", Console.ForegroundColor=ConsoleColor.Green);
            //if(i==y)
            if (i.Equals(y) )
            //if(i.CompareTo(y))
            {
                Console.WriteLine("\n\nEst true",Console.ForegroundColor=ConsoleColor.DarkCyan);
            }
            else
            {
                Console.WriteLine("\n\nEst false",Console.ForegroundColor = ConsoleColor.DarkYellow);
            }

            Console.WriteLine("\n\n3. Cas particuler pour les string", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.WriteLine("\n\nMême objets différents->pointe sur la même mémoire –> true", Console.ForegroundColor = ConsoleColor.Yellow);
            object str = "test";
            object str1 = "test";
            Console.WriteLine(("\n\n== operator is " + (string)str==(string)str1));
            Console.WriteLine(("\n\nEquals method result is " + str.Equals((string)str1)));

            Console.WriteLine("\n\noverriding comportement interne", Console.ForegroundColor = ConsoleColor.Cyan);
            object name = "sandeep";
            char[] values = { 's', 'a', 'n', 'd', 'e', 'e', 'p' };
            object myName = new string(values);
            Console.WriteLine("\n\n== operator is {0}", name == myName, Console.ForegroundColor=ConsoleColor.Cyan);
            Console.WriteLine("\n\nEquals method result is {0}", name.Equals(myName));

            Console.ReadKey();
        }

        // 1. Mettre les mots dans une liste, puis un tableau
        private static string[] fncBuildTab(string xsentence)
        {
            int debut = 0;
            var xliste = new List<string>();
            string phrase;
            do
            {
                // extract the word
                phrase = xsentence.Substring(debut, xsentence.IndexOf(" "));
                Console.Write(phrase,Console.ForegroundColor=ConsoleColor.Yellow);
                // increment the index
                debut = phrase.Length + debut;
                // remove the white - space
                phrase = Regex.Replace(phrase, @"\s+", "");
                // add to the list
                xliste.Add(phrase);
            }
            while (debut < xsentence.Length-1);
            // change la liste en tableau
            var xtab = xliste.ToArray();
            // display xtab
            for(int i=0; i<xtab.Length-1; i++)
            {
                Console.WriteLine("\n"+xtab[i],Console.ForegroundColor=ConsoleColor.Cyan);
            }
            return xtab;
        }

        // 2 - compare les 2 tableaux
        private static Boolean fncCompareTab(string s1, string s2)
        {
            string[] xarray1 = fncBuildTab(s1);
            Array.Reverse(xarray1);
            string[] xarray2 = fncBuildTab(s2);
            bool result = false;
            int size = xarray1.Length - 1;
            for(int i = 0; i < size; i++)
            {
                if(xarray1[i]==xarray2[i])
                {
                    result = true;
                }
            }
            return result;
        }
    }
}