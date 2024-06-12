/*
 
 Опис: Клас Player, створює всю функціональність для стандартного гравця
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakLibrary
{
    public class Player
    {
        //атрибути екземпляра
        private String name = "";
        private PlayerHand hand = new PlayerHand();
        private bool isAttacking = false;
        private bool isDefending = false;


        //атрибути класу
        public const String DEFAULT_NAME = "John Doe";
        public const PlayerHand DEFAULT_PLAYERHAND = null;
        public const bool DEFAULT_ISATTACKING = false;
        public const bool DEFAULT_ISDEFENDING = false;


        //конструктор за замовчуванням
        public Player()
        {
            setName(DEFAULT_NAME);
            setHand(DEFAULT_PLAYERHAND);
            setIsAttacking(DEFAULT_ISATTACKING);
            setIsDefending(DEFAULT_ISDEFENDING);
        }

        //параметризований конструктор (PlayerHand hand, bool isAttacking, bool isDefending)
        public Player(String name, PlayerHand hand, bool isAttacking, bool isDefending)
        {
            setName(name);
            setHand(hand);
            setIsAttacking(isAttacking);
            setIsDefending(isDefending);
        }

        //Фаза атаки для людських гравців
        public virtual void AttackingPhase(GameRiver gameRiver, Card attackingCard)
        {

            CardList gameRiverList = new CardList();


            for (int i = 0; i < gameRiver.length(); i++)
            {
                gameRiverList.Add(gameRiver.GetCard(i));
            }



            switch (gameRiver.length())
            {
                case 0:


                    gameRiver.AddCardToRiver(attackingCard);
                    getHand().RemoveCardFromHand(attackingCard);

                    break;

                case 2:
                    if (attackingCard.getCardRank() == gameRiverList[0].rank | attackingCard.getCardRank() == gameRiverList[1].rank)
                    {
                        gameRiver.AddCardToRiver(attackingCard);
                        getHand().RemoveCardFromHand(attackingCard);

                        break;
                    }
                    break;

                case 4:
                    if (attackingCard.getCardRank() == gameRiverList[0].rank | attackingCard.getCardRank() == gameRiverList[1].rank | attackingCard.getCardRank() == gameRiverList[2].rank | attackingCard.getCardRank() == gameRiverList[3].rank)
                    {
                        gameRiver.AddCardToRiver(attackingCard);
                        getHand().RemoveCardFromHand(attackingCard);
                        break;
                    }
                    break;

                case 6:
                    if (attackingCard.getCardRank() == gameRiverList[0].rank | attackingCard.getCardRank() == gameRiverList[1].rank | attackingCard.getCardRank() == gameRiverList[2].rank | attackingCard.getCardRank() == gameRiverList[3].rank | attackingCard.getCardRank() == gameRiverList[4].rank | attackingCard.getCardRank() == gameRiverList[5].rank)
                    {
                        gameRiver.AddCardToRiver(attackingCard);
                        getHand().RemoveCardFromHand(attackingCard);
                        break;
                    }
                    break;

                case 8:
                    if (attackingCard.getCardRank() == gameRiverList[0].rank | attackingCard.getCardRank() == gameRiverList[1].rank | attackingCard.getCardRank() == gameRiverList[2].rank | attackingCard.getCardRank() == gameRiverList[3].rank | attackingCard.getCardRank() == gameRiverList[4].rank | attackingCard.getCardRank() == gameRiverList[5].rank)
                    {
                        gameRiver.AddCardToRiver(attackingCard);
                        getHand().RemoveCardFromHand(attackingCard);
                        break;
                    }
                    break;
            }



        }

        //Фаза захисту для людських гравців
        public virtual void DefendingPhase(GameRiver gameRiver, Card trumpCard, Card defendingCard)
        {
            //Card defendingCard = new Card();
            CardList gameRiverList = new CardList();
            bool sucessfulldefense = false;


            //gameRiver.AddCardToRiver(defendingCard);
            //getHand().RemoveCardFromHand(defendingCard);
            //sucessfulldefense = true;



            for (int i = 0; i < gameRiver.length(); i++)
            {
                gameRiverList.Add(gameRiver.GetCard(i));
            }



            switch (gameRiver.length())
            {
                case 1:


                    if (defendingCard.getCardSuit() == gameRiverList[0].suit & defendingCard > gameRiverList[0] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameRiverList[0])
                    {
                        gameRiver.AddCardToRiver(defendingCard);
                        getHand().RemoveCardFromHand(defendingCard);
                        sucessfulldefense = true;
                        break;
                    }


                    break;

                case 3:


                    if (defendingCard.getCardSuit() == gameRiverList[2].suit & defendingCard > gameRiverList[2] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameRiverList[2])
                    {
                        gameRiver.AddCardToRiver(defendingCard);
                        getHand().RemoveCardFromHand(defendingCard);
                        sucessfulldefense = true;
                        break;
                    }


                    break;


                case 5:


                    if (defendingCard.getCardSuit() == gameRiverList[4].suit & defendingCard > gameRiverList[4] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameRiverList[4])
                    {
                        gameRiver.AddCardToRiver(defendingCard);
                        getHand().RemoveCardFromHand(defendingCard);
                        sucessfulldefense = true;
                        break;
                    }


                    break;

                case 7:


                    if (defendingCard.getCardSuit() == gameRiverList[6].suit & defendingCard > gameRiverList[6] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameRiverList[6])
                    {
                        gameRiver.AddCardToRiver(defendingCard);
                        getHand().RemoveCardFromHand(defendingCard);
                        sucessfulldefense = true;
                        break;
                    }


                    break;


            }



            //if (sucessfulldefense == false)
            //{
            //    setIsDefending(false);
            //}


        }





        //public virtual void DefendingPhase(GameRiver river, int userInput)
        //{


        //    if (isDefending == true)
        //    {
        //        Card defendingCard;

        //        defendingCard = hand.ChooseCardFromHand(userInput);
        //        river.AddCardToRiver(defendingCard);

        //        if (river.cardRiverComparison() == true)
        //        {
        //            isDefending = false;
        //            hand.RemoveCardFromHand(defendingCard);
        //        }
        //        else
        //        {
        //            river.RemoveCardFromRiver(defendingCard);               
        //        }

        //    }

        //}

        //attacking/defense phase method
        //public virtual void AttackingPhase(GameRiver river, int userInput)
        //{
        //    //if (isAttacking == true)
        //    //{
        //    Card attackingCard;
        //    attackingCard = hand.ChooseCardFromHand(userInput);
        //    river.AddCardToRiver(attackingCard);
        //    hand.RemoveCardFromHand(attackingCard);
        //    //}
        //}

        //повертає рядок із інформацією про гравця
        public String ToStringPlayerInfo()
        {
            String playerInfoString = "";

            playerInfoString += "\n" + getName() + " " + getHand().ToString(getHand(), getName()) +
                "\nАтака: " + getIsAttacking() + "\nЗахист: " + getIsDefending();

            return playerInfoString;


        }


        //повторно наповнює руку гравця
        public void RefillHand(GameDeck deck)
        {

            CardList cards = deck.DrawCards(6 - hand.length());
            hand.AddCardsToHand(cards);

        }




        //геттери та сеттери
        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public PlayerHand getHand()
        {
            return hand;
        }

        public void setHand(PlayerHand hand)
        {
            this.hand = hand;
        }

        public bool getIsAttacking()
        {
            return isAttacking;
        }

        public void setIsAttacking(bool isAttacking)
        {
            this.isAttacking = isAttacking;
        }

        public bool getIsDefending()
        {
            return isDefending;
        }

        public void setIsDefending(bool isDefending)
        {
            this.isDefending = isDefending;
        }

        public void DefendingPhase(GameRiver myRiver, int userInput)
        {
            throw new NotImplementedException();
        }

        public void AttackingPhase(GameRiver myRiver, int userInput)
        {
            throw new NotImplementedException();
        }
    }
}