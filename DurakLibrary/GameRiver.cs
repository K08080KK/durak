/*
 
 Опис: Клас GameRiver, цей клас буде містити список карт, які знаходяться в центрі гри.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakLibrary
{
    public class GameRiver : ICloneable
    {
        //атрибути екземпляра
        CardList gameRiver = new CardList();
        private int riverCardsRemaning = 0;




        //метод AddCardToRiver, додасть карту до річки
        public void AddCardToRiver(Card card)
        {
            gameRiver.Add(card);
            riverCardsRemaning = gameRiver.Count();
        }

        //метод RemoveCardFromRiver, видалить карту з річки
        public void RemoveCardFromRiver(Card card)
        {
            gameRiver.Remove(card);
            riverCardsRemaning = gameRiver.Count();
        }

        //показує довжину річки
        public int length()
        {
            return gameRiver.Count();

        }


        //отримає карту на основі числового значення
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return gameRiver[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                       "Значення повинно бути від 0 до 51."));
        }

        //клонує карти річки
        public object Clone()
        {
            GameRiver newGameRiver = new GameRiver(gameRiver.Clone() as CardList);
            return newGameRiver;
        }

        //параметризований конструктор встановлює нову грічку
        private GameRiver(CardList newGameRiver)
        {
            gameRiver = newGameRiver;
        }

        //конструктор за замовчуванням
        public GameRiver()
        {

        }

        //очищає річку
        public void ClearRiver()
        {
            gameRiver.Clear();
        }




        //порівнює карти, що введені в річку 
        public bool cardRiverComparison(Card trumpCard)
        {


            String defendedString = "";
            bool defended = false;

            switch (gameRiver.Count)
            {

                case 2:
                    if (gameRiver[1].suit == gameRiver[0].suit | gameRiver[1].suit == trumpCard.getCardSuit())
                    {
                        if (gameRiver[1] > gameRiver[0] | gameRiver[1].suit == trumpCard.getCardSuit())
                        {
                            defendedString += "\nЦя карта захистила: " + gameRiver[1].ToString();
                            defended = true;
                        }
                        else
                        {
                            defendedString += "\nЦя карта НЕ захистила: " + gameRiver[1].ToString();
                        }
                    }
                    else
                    {
                        defendedString += "Не той же масть";
                    }
                    break;

                case 4:
                    if (gameRiver[3].suit == gameRiver[2].suit | gameRiver[1].suit == trumpCard.getCardSuit())
                    {
                        if (gameRiver[3] > gameRiver[2] | gameRiver[1].suit == trumpCard.getCardSuit())
                        {
                            defendedString += "\nЦя карта захистила: " + gameRiver[3].ToString();
                            defended = true;
                        }
                        else
                        {
                            defendedString += "\nЦя карта НЕ захистила: " + gameRiver[3].ToString();
                        }
                    }
                    else
                    {
                        defendedString += "Не той же масть";
                    }
                    break;

                case 6:
                    if (gameRiver[5].suit == gameRiver[4].suit | gameRiver[1].suit == trumpCard.getCardSuit())
                    {
                        if (gameRiver[5] > gameRiver[4] | gameRiver[1].suit == trumpCard.getCardSuit())
                        {
                            defendedString += "\nЦя карта захистила: " + gameRiver[5].ToString();
                            defended = true;
                        }
                        else
                        {
                            defendedString += "\nЦя карта НЕ захистила: " + gameRiver[5].ToString();
                        }
                    }
                    else
                    {
                        defendedString += "Не той же масть";
                    }
                    break;

                case 8:
                    if (gameRiver[7].suit == gameRiver[6].suit | gameRiver[1].suit == trumpCard.getCardSuit())
                    {
                        if (gameRiver[7] > gameRiver[6] | gameRiver[1].suit == trumpCard.getCardSuit())
                        {
                            defendedString += "\nЦя карта захистила: " + gameRiver[7].ToString();
                            defended = true;
                        }
                        else
                        {
                            defendedString += "\nЦя карта НЕ захистила: " + gameRiver[7].ToString();
                        }
                    }
                    else
                    {
                        defendedString += "Не той же масть";
                    }
                    break;

            }

            return defended;



        }


        //повертає рядок, що містить картки річки
        public String ToString(GameRiver gameRiver1)
        {
            String gameRiverString = "";

            gameRiverString += "\n\n\tКарти річки\n\t";
            for (int i = 0; i < gameRiver1.length(); i++)
            {
                Card tempCard = gameRiver1.GetCard(i);
                gameRiverString += tempCard.ToString();
                if (i != 51)
                    gameRiverString += ", ";

            }

            return gameRiverString;
        }

        //отримує кількість карток в річці
        public int getCardsRemaining()
        {
            return riverCardsRemaning = gameRiver.Count;
        }

        public bool cardRiverComparison()
        {
            throw new NotImplementedException();
        }
    }
}