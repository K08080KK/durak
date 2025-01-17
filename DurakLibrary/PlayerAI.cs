﻿/*
 
 Опис: Клас PlayerAI, створює всю функціональність для комп'ютерного гравця - штучного інтелекту
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakLibrary
{
    public class PlayerAI : Player
    {
        //конструктор за замовчуванням
        public PlayerAI()
        {

        }

        //параметризований конструктор для гравця-ШІ
        public PlayerAI(String name, PlayerHand hand, bool isAttacking, bool isDefending)
        {
            setName(name);
            setHand(hand);
            setIsAttacking(isAttacking);
            setIsDefending(isDefending);
        }

        //метод фази атаки комп'ютера, керує штучним інтелектом під час атаки
        public void AttackingPhase(GameRiver gameRiver)
        {

            Card attackingCard = new Card();

            CardList gameRiverList = new CardList();

            bool sucessfullattack = false;

            for (int i = 0; i < gameRiver.length(); i++)
            {
                gameRiverList.Add(gameRiver.GetCard(i));
            }


            switch (gameRiver.length())
            {
                case 0:
                    //ШІ вибирає карту
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        gameRiver.AddCardToRiver(attackingCard);
                        getHand().RemoveCardFromHand(attackingCard);
                        sucessfullattack = true;
                        break;
                    }
                    break;

                case 2:
                    //ШІ вибирає карту
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        if (attackingCard.getCardRank() == gameRiverList[0].rank | attackingCard.getCardRank() == gameRiverList[1].rank)
                        {
                            gameRiver.AddCardToRiver(attackingCard);
                            getHand().RemoveCardFromHand(attackingCard);
                            sucessfullattack = true;
                            break;
                        }
                    }
                    break;

                case 4:
                    //ШІ вибирає карту
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        if (attackingCard.getCardRank() == gameRiverList[0].rank | attackingCard.getCardRank() == gameRiverList[1].rank | attackingCard.getCardRank() == gameRiverList[2].rank | attackingCard.getCardRank() == gameRiverList[3].rank)
                        {
                            gameRiver.AddCardToRiver(attackingCard);
                            getHand().RemoveCardFromHand(attackingCard);
                            sucessfullattack = true;
                            break;
                        }
                    }
                    break;

                case 6:
                    //ШІ вибирає карту
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        if (attackingCard.getCardRank() == gameRiverList[0].rank | attackingCard.getCardRank() == gameRiverList[1].rank | attackingCard.getCardRank() == gameRiverList[2].rank | attackingCard.getCardRank() == gameRiverList[3].rank | attackingCard.getCardRank() == gameRiverList[4].rank | attackingCard.getCardRank() == gameRiverList[5].rank)
                        {
                            gameRiver.AddCardToRiver(attackingCard);
                            getHand().RemoveCardFromHand(attackingCard);
                            sucessfullattack = true;
                            break;
                        }
                    }
                    break;

                case 8:
                    //ШІ вибирає карту
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        attackingCard = getHand().ChooseCardFromHand(i);

                        if (attackingCard.getCardRank() == gameRiverList[0].rank | attackingCard.getCardRank() == gameRiverList[1].rank | attackingCard.getCardRank() == gameRiverList[2].rank | attackingCard.getCardRank() == gameRiverList[3].rank | attackingCard.getCardRank() == gameRiverList[4].rank | attackingCard.getCardRank() == gameRiverList[5].rank)
                        {
                            gameRiver.AddCardToRiver(attackingCard);
                            getHand().RemoveCardFromHand(attackingCard);
                            sucessfullattack = true;
                            break;
                        }
                    }
                    break;
            }


            if (sucessfullattack == false && gameRiver.length() == 0 | gameRiver.length() == 2 | gameRiver.length() == 4 | gameRiver.length() == 6 | gameRiver.length() == 8)
            {
                setIsDefending(true);
            }


        }


        //метод фази захисту комп'ютера, керує штучним інтелектом під час захисту
        public void DefendingPhase(GameRiver gameRiver, Card trumpCard)
        {
            Card defendingCard = new Card();
            CardList gameRiverList = new CardList();
            bool sucessfulldefense = false;

            //int computerInput = 0;

            for (int i = 0; i < gameRiver.length(); i++)
            {
                gameRiverList.Add(gameRiver.GetCard(i));
            }

            switch (gameRiver.length())
            {
                case 1:
                    //ШІ вибирає карту 
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        defendingCard = getHand().ChooseCardFromHand(i);

                        if (defendingCard.getCardSuit() == gameRiverList[0].suit & defendingCard > gameRiverList[0] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameRiverList[0])
                        {
                            gameRiver.AddCardToRiver(defendingCard);
                            getHand().RemoveCardFromHand(defendingCard);
                            sucessfulldefense = true;
                            break;
                        }

                    }
                    break;

                case 3:
                    //ШІ вибирає карту
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        defendingCard = getHand().ChooseCardFromHand(i);

                        if (defendingCard.getCardSuit() == gameRiverList[2].suit & defendingCard > gameRiverList[2] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameRiverList[2])
                        {
                            gameRiver.AddCardToRiver(defendingCard);
                            getHand().RemoveCardFromHand(defendingCard);
                            sucessfulldefense = true;
                            break;
                        }

                    }
                    break;


                case 5:
                    //ШІ вибирає карту 
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        defendingCard = getHand().ChooseCardFromHand(i);

                        if (defendingCard.getCardSuit() == gameRiverList[4].suit & defendingCard > gameRiverList[4] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameRiverList[4])
                        {
                            gameRiver.AddCardToRiver(defendingCard);
                            getHand().RemoveCardFromHand(defendingCard);
                            sucessfulldefense = true;
                            break;
                        }

                    }
                    break;

                case 7:
                    //ШІ вибирає карту
                    for (int i = 0; i < getHand().length(); i++)
                    {
                        defendingCard = getHand().ChooseCardFromHand(i);

                        if (defendingCard.getCardSuit() == gameRiverList[6].suit & defendingCard > gameRiverList[6] | defendingCard.getCardSuit() == trumpCard.getCardSuit() & defendingCard > gameRiverList[6])
                        {
                            gameRiver.AddCardToRiver(defendingCard);
                            getHand().RemoveCardFromHand(defendingCard);
                            sucessfulldefense = true;
                            break;
                        }

                    }
                    break;


            }

            if (sucessfulldefense == false && gameRiver.length() == 1 | gameRiver.length() == 3 | gameRiver.length() == 5 | gameRiver.length() == 7)
            {
                setIsDefending(false);
            }


        }




        public void ChooseDefendingCard()
        {

        }


        ////метод фази захисту комп'ютера, керує штучним інтелектом під час захисту
        //public void DefendingPhase(GameRiver gameRiver)
        //{
        //    if (getIsDefending() == true)
        //    {
        //        Card defendingCard;

        //        defendingCard = getHand().ChooseCardFromHand(1);
        //        gameRiver.AddCardToRiver(defendingCard);

        //        if (gameRiver.cardRiverComparison() == true)
        //        {
        //            setIsDefending(false);
        //            getHand().RemoveCardFromHand(defendingCard);
        //        }
        //        else
        //        {
        //            gameRiver.RemoveCardFromRiver(defendingCard);
        //        }

        //    }
        //}








    }
}