using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implémenter un bout de code pour valider si une chaîne de caractères est un palindrome
//(la chaîne a la même valeur qu’on lise de gauche à droite ou de droite à gauche). 
//Il faut prendre soin d’appliquer les principes SOLID.

namespace Exercicio_3_retourne_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = "ANA";
            String traiterWord = (Palidrome(word));
            bool YesorNot = (PalidromeYesorNot(traiterWord, word));
            ShowPalindrome(YesorNot);
            Console.ReadKey();

        }

        public static string Palidrome(string word)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = (word.Length -1 ); i >=0 ; i--)
            {

                sb.Append(word[i]);

            }
            String traiterWord = sb.ToString();
            return traiterWord;
        }

        public static bool PalidromeYesorNot(string traiterWord, string Word)
        {
            return traiterWord == Word;
        }

        public static void ShowPalindrome(bool YesorNot)
        {
            if (YesorNot)
            {
                Console.Write("Et un Palindrome");
            }
            else
            {
                Console.Write("Ne pas un Palindrome");
            }

        }
    }
}
