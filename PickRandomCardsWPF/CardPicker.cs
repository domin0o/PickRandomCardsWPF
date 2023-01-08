using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for(int i = 0; i< numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            //Pobieranie liczby z zakresu 1-13
            int value = random.Next(1,14);
            //Jeśli liczba to 1, zwróć łańcuch znaków "As"
            if (value == 1) return "As";
            //Jeśli liczba to 11, zwróć łańcuch znaków "Walet"
            if (value == 11) return "Walet";
            //Jeśli liczba to 12, zwróć łańcuch znaków "Dama"
            if (value == 12) return "Dama";
            //Jeśli liczba to 13, zwróć łańcuch znaków "Król"
            if (value == 13) return "Król";
            //Jeśli liczba jest inna niż liczby wyżej, zwróć wartość value, która zostanie przekształcona do łańcucha znaków
            return value.ToString();
        }

        private static string RandomSuit()
        {
            //pobieranie liczby losowej
            int value = random.Next(1,5);
            //Jeśli liczba to 1, zwróć łańcuch znaków "pik"
            if (value == 1) return "pik";
            //Jeśli liczba to 2, zwróć łańcuch znaków "kier"
            if (value == 2) return "kier";
            //Jeśli liczba to 3, zwróć łańcuch znaków "trefl"
            if (value == 3) return "trefl";
            //W przeciwnym wypadku, zwróć łańcuch znaków "karo"
            return "karo";

        }
    }
}
