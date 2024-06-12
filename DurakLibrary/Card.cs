/*



Опис: Клас Card встановлює та визначає одну гральну картку для будь-яких екземплярів рангу та масті. Цей клас також перевизначає оператори відношення для об'єктів карток 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DurakLibrary
{
    // Публічний клас картки використовує інтерфейс ICloneable
    public class Card : ICloneable
    {
        // Атрибути екземпляра
        // Було readonly
        public readonly CardRanksEnum rank;
        public readonly CardSuitsEnum suit;


        // Атрибути класу
        public static bool isAceHigh = true;
        public static bool useTrumps = false;
        public static CardSuitsEnum trump = CardSuitsEnum.Club;

        public EventHandler CardClicked { get; set; }

        // Конструктор за замовчуванням
        public Card()
        {

        }

        // Параметризований конструктор (CardSuitsEnum, CardRanksEnum)
        public Card(CardSuitsEnum newSuit, CardRanksEnum newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public CardSuitsEnum getCardSuit()
        {

            return suit;
        }

        public CardRanksEnum getCardRank()
        {

            return rank;
        }

        // Метод клонування підтримує інтерфейс ICloneable
        // Повертає копію членів
        public object Clone()
        {
            return MemberwiseClone();
        }


        // Метод ToString()
        // Повертає ранг та масть у вигляді рядка
        public override String ToString()
        {
            return "Карта " + rank + " масті " + suit + "s";
        }

        public String ToString(int playerNumber)
        {
            return "\nКарта, витягнута гравцем " + playerNumber + "\nКарта " + rank + " масті " + suit + "s";
        }

        // Метод GetHashCode()
        // Повертає унікальний номер хешу
        public override int GetHashCode()
        {
            return 13 * (int)suit + (int)rank;
        }

        // Методи перевантаження операторів
        // Повертає логічне значення
        public static bool operator ==(Card card1, Card card2)
        {
  
                return (card1.suit == card2.suit) && (card1.rank == card2.rank);
            
        }

        public static bool operator !=(Card card1, Card card2)
        {
        
                return !(card1 == card2);
      
        }

        public override bool Equals(object card)
        {
            return this == (Card)card;
        }

        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == CardRanksEnum.Ace)
                    {
                        if (card2.rank == CardRanksEnum.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.rank == CardRanksEnum.Ace)
                            return false;
                        else
                            return (card1.rank > card2.rank);
                    }
                }
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }

        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == CardRanksEnum.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.rank == CardRanksEnum.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }



    }
}