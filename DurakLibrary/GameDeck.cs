/*
 
 Опис: Клас GameDeck, створює колоду із картами за допомогою функціоналу класу CardList. Метод Shuffle для випадкового перемішування карт в колоді. Метод GetCard для вибору карти з колоди. Перевірка наявності тузів і козирів.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DurakLibrary
{
    //Клас GameDeck, який використовує інтерфейс ICloneable
    public class GameDeck : ICloneable
    {
        //Атрибути екземпляра
        private CardList cards = new CardList();
        private int cardsRemaining = 0;
        private Card trumpCard = new Card();

        //Конструктор за замовчуванням, перебирає всі можливі масті і ранги, а потім додає їх до приватного списку карт
        public GameDeck()
        {
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((CardSuitsEnum)suitVal, (CardRanksEnum)rankVal));

                }
            }
        }

        //Параметризований конструктор (розмір колоди 52, 36 або 20)
        public GameDeck(int deckSize)
        {
            int rankStartingPoint = 0;

            if (deckSize == 52)
            {
                rankStartingPoint = 1;
            }
            else if (deckSize == 36)
            {
                rankStartingPoint = 6;

                //додати тузи
                cards.Add(new Card((CardSuitsEnum)0, (CardRanksEnum)1));
                cards.Add(new Card((CardSuitsEnum)1, (CardRanksEnum)1));
                cards.Add(new Card((CardSuitsEnum)2, (CardRanksEnum)1));
                cards.Add(new Card((CardSuitsEnum)3, (CardRanksEnum)1));
            }

            else if (deckSize == 20)
            {
                rankStartingPoint = 10;

                //додати тузи
                cards.Add(new Card((CardSuitsEnum)0, (CardRanksEnum)1));
                cards.Add(new Card((CardSuitsEnum)1, (CardRanksEnum)1));
                cards.Add(new Card((CardSuitsEnum)2, (CardRanksEnum)1));
                cards.Add(new Card((CardSuitsEnum)3, (CardRanksEnum)1));
            }


            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = rankStartingPoint; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((CardSuitsEnum)suitVal, (CardRanksEnum)rankVal));

                }
            }



        }


        //Параметризований конструктор (CardList), встановлює приватний атрибут cardlist на новий список карт.
        private GameDeck(CardList newCards)
        {
            cards = newCards;
        }

        //

        //Параметризований конструктор, дозволяє тузам бути високими.
        public GameDeck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        // Параметризований конструктор, дозволяє використовувати козирну маст.
        public GameDeck(bool useTrumps, CardSuitsEnum trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        // Параметризований конструктор, дозволяє тузам бути високими і використовувати козирну маст.
        public GameDeck(bool isAceHigh, bool useTrumps, CardSuitsEnum trump) : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        //метод клонування
        //повертає новий об'єкт GameDeck після клонування cardlist
        public object Clone()
        {
            GameDeck newDeck = new GameDeck(cards.Clone() as CardList);
            return newDeck;
        }

        //метод перемішування, випадковим чином перемішує порядок списку карт, 
        //потім використовує метод CopyTo в cardlist для копіювання карт в нову колоду cardlist. 
        public void Shuffle(int deckSize)
        {
            if (deckSize == 52)
            {
                CardList newDeck = new CardList();
                bool[] assigned = new bool[52];
                Random sourceGen = new Random();
                for (int i = 0; i < 52; i++)
                {
                    int sourceCard = 0;
                    bool foundCard = false;
                    while (foundCard == false)
                    {
                        sourceCard = sourceGen.Next(52);
                        if (assigned[sourceCard] == false)
                            foundCard = true;
                    }
                    assigned[sourceCard] = true;
                    newDeck.Add(cards[sourceCard]);
                }
                newDeck.CopyTo(cards);
            }
            else if (deckSize == 36)
            {
                CardList newDeck = new CardList();
                bool[] assigned = new bool[36];
                Random sourceGen = new Random();
                for (int i = 0; i < 36; i++)
                {
                    int sourceCard = 0;
                    bool foundCard = false;
                    while (foundCard == false)
                    {
                        sourceCard = sourceGen.Next(36);
                        if (assigned[sourceCard] == false)
                            foundCard = true;
                    }
                    assigned[sourceCard] = true;
                    newDeck.Add(cards[sourceCard]);
                }
                newDeck.CopyTo(cards);
            }
            else if (deckSize == 20)
            {
                CardList newDeck = new CardList();
                bool[] assigned = new bool[20];
                Random sourceGen = new Random();
                for (int i = 0; i < 20; i++)
                {
                    int sourceCard = 0;
                    bool foundCard = false;
                    while (foundCard == false)
                    {
                        sourceCard = sourceGen.Next(20);
                        if (assigned[sourceCard] == false)
                            foundCard = true;
                    }
                    assigned[sourceCard] = true;
                    newDeck.Add(cards[sourceCard]);
                }
                newDeck.CopyTo(cards);
            }

        }

        //метод отримання карти, отримує карту на основі наданого цілочисельного числа 
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                       "Значення повинно бути від 0 до 51."));
        }


        //витягти карту з колоди
        public Card DrawCard()
        {
            Card card;

            card = cards.First();
            cards.RemoveAt(0);
            return card;
        }


        //витягти кілька карт залежно від наданого значення int
        public CardList DrawCards(int numberOfCards)
        {
            CardList cardsdrawn = new CardList();

            for (int i = 0; i < numberOfCards; i++)
            {
                cardsdrawn.Add(cards.ElementAt(0));
                cards.RemoveAt(0);
            }

            return cardsdrawn;

        }

        //довжина колоди
        public int length()
        {
            return cards.Count();

        }

        //метод ToString показує карти в колоді як рядок
        public String ToString(GameDeck gameDeck1)
        {
            String gameDeckString = "";

            gameDeckString += "\n\nКарти в колоді\n";
            for (int i = 0; i < gameDeck1.length(); i++)
            {
                Card tempCard = gameDeck1.GetCard(i);
                gameDeckString += tempCard.ToString();
                if (i != 51)
                    gameDeckString += ", ";

            }

            return gameDeckString;
        }

        //отримати залишкові карти в колоді
        public int getCardsRemaining()
        {
            return cardsRemaining = cards.Count;
        }

        //отримати козирну карту колоди
        public Card getTrumpCard()
        {
            return trumpCard;
        }
        //встановлює козирну карту
        public void setTrumpCard(GameDeck deck)
        {

            Card trumpCard;

            trumpCard = deck.DrawCard();

            this.trumpCard = trumpCard;
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}