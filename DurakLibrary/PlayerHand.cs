/*
 
 Опис: Клас PlayerHand, відстежує карти в руках гравців
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakLibrary
{
    public class PlayerHand : ICloneable
    {


        //атрибути екземпляра
        CardList playerHand = new CardList();
        //private bool isHandEmpty = false;
        private int numberOfCardsRemaning = 0;



        //конструктор за замовчуванням
        public PlayerHand()
        {

        }

        //параметризований конструктор
        private PlayerHand(CardList newPlayerHand)
        {
            playerHand = newPlayerHand;
        }

        //метод клонування
        //повертає клон playerhand

        public object Clone()
        {
            PlayerHand newplayerHand = new PlayerHand(playerHand.Clone() as CardList);
            return newplayerHand;
        }

        //метод додавання карти до руки
        public void AddCardToHand(Card card)
        {
            playerHand.Add(card);
            numberOfCardsRemaning = playerHand.Count();
        }

        //додає карти до руки гравця
        public void AddCardsToHand(CardList cards)
        {


            for (int i = 0; i < cards.Count(); i++)
            {
                playerHand.Add(cards[i]);
            }

            numberOfCardsRemaning = playerHand.Count();
        }



        public void RemoveCardFromHand(Card card)
        {
            playerHand.Remove(card);
            numberOfCardsRemaning = playerHand.Count();
        }

        //отримує кількість карт в руці
        public int length()
        {
            return playerHand.Count();

        }

        //метод вибору карти з руки, вибирає певну карту з руки, а потім видаляє зі списку
        public Card ChooseCardFromHand(int choosenCardNumber)
        {
            Card card;
            card = playerHand.ElementAt(choosenCardNumber);
            //playerHand.Remove(card);

            return card;
        }

        //вибирає конкретну карту з руки
        public Card ChooseCardFromHand(Card card)
        {
            return card;

        }

        //отримати карту за цілим числом
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return playerHand[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                       "Значення повинно бути від 0 до 51."));
        }


        //показує руку у вигляді рядка
        public String ToString(PlayerHand playerHand1, String playerName)
        {
            String playerHandString = "";

            playerHandString += playerName.ToString() + "Карти: \n\t";
            for (int i = 0; i < playerHand1.length(); i++)
            {
                Card tempCard = playerHand1.GetCard(i);
                playerHandString += tempCard.ToString();
                if (i != 51)
                    playerHandString += ", ";

            }

            return playerHandString;
        }


        //показує руку у вигляді рядка, ціле число номера гравця
        public String ToString(PlayerHand playerHand1, int playerNumber)
        {
            String playerHandString = "";

            playerHandString += "\n\nГравець" + playerNumber.ToString() + "\n";
            for (int i = 0; i < playerHand1.length(); i++)
            {
                Card tempCard = playerHand1.GetCard(i);
                playerHandString += tempCard.ToString();
                if (i != 51)
                    playerHandString += ", ";

            }

            return playerHandString;
        }


    }

}
