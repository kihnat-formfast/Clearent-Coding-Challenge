using System;
using System.Collections.Generic;
using System.Text;

namespace ClearentTestProject
{
    class Card
    {
        //This class holds a card and one of the properties is the interest calculation
        private NamedCardType _cardType;

        public NamedCardType CardType
        {
            get
            {
                return _cardType;
            }
        }

        public decimal Balance
        {
            get;
            set;
        }

        public decimal Interest
        {
            get
            {
                decimal ret = 0;
                ret = this.Balance * this.CardType.Interest;
                return ret;
                //I wrote this on three lines instead of one for debugging purposes.
            }
        }

        public Card(NamedCardType type, decimal balance)
        {
            _cardType = type;
            Balance = balance;
        }
    }
}
