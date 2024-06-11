using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ThePoint
{
    public class Card
    {
        public CardColor ColorOfCard { get; set; }
        public CardRank RankOfCard { get; set; }
        public Card()
        {
            ColorOfCard = CardColor.Red;
            RankOfCard = CardRank.One;
        }
        public Card(CardColor colorOfCard, CardRank rankOfCard)
        {
            ColorOfCard = colorOfCard;
            RankOfCard = rankOfCard;
        }
        public void GetCardType()
        {
            if (RankOfCard == CardRank.One || RankOfCard == CardRank.Two || RankOfCard == CardRank.Three
            || RankOfCard == CardRank.Four || RankOfCard == CardRank.Five || RankOfCard == CardRank.Six
            || RankOfCard == CardRank.Seven || RankOfCard == CardRank.Eight || RankOfCard == CardRank.Nine ||
            RankOfCard == CardRank.Ten){
                System.Console.WriteLine("This Card is a Number Card");
            } else {
                System.Console.WriteLine("This Card is a Symbol Card");
            }
        }

        public void GetCardName()
        {
            System.Console.WriteLine($"The {ColorOfCard} {RankOfCard}");
        }


    }
}