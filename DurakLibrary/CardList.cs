/*

Опис: Клас CardList створює та визначає загальний список об'єктів карток. Використовує 
клонування для створення нового списку карток. Метод копіювання для копіювання екземплярів 
карток в інший екземпляр карток - використовується у Deck.Shuffle(). Ця реалізація передбачає, 
що джерело та цільові колекції мають однаковий розмір.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakLibrary
{
    // Клас CardList успадковує клас загального списку та використовує інтерфейс ICloneable


    public class CardList : List<Card>, ICloneable
    {
        // Метод клонування, повертає клон списку карток
        public object Clone()
        {
            CardList newCards = new CardList();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;
        }

        // Метод CopyTo для копіювання екземплярів карток в інший екземпляр Cards - використовується у Deck.Shuffle().
        // Ця реалізація передбачає, що джерело та цільові колекції мають однаковий розмір.
        public void CopyTo(CardList targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        // ToString показує карти гравця як рядок
        public String ToString(CardList cardsDrawn, int playerNumber)
        {
            String cardsDrawnString = "";

            cardsDrawnString += "\n\nDrawnCards Player " + playerNumber.ToString() + "\n";
            for (int i = 0; i < cardsDrawn.Count(); i++)
            {
                Card tempCard = cardsDrawn.GetCard(i, cardsDrawn);
                cardsDrawnString += tempCard.ToString();
                if (i != 51)
                    cardsDrawnString += ", ";

            }

            return cardsDrawnString;
        }

        // Отримання картки за її номером
        public Card GetCard(int cardNum, CardList cards)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                       "Значення повинно бути від 0 до 51."));
        }
    }
}