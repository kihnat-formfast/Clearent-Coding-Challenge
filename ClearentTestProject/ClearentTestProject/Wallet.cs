using System;
using System.Collections.Generic;
using System.Text;

namespace ClearentTestProject
{
    class Wallet
    {
        //This class contains Cards and the interest information about the sum of said cards
        private List<Card> _walletContents;
        public List<Card> WalletContents
        {
            get
            {
                return _walletContents;
            }
        }

        public void Add(Card card)
        {
            _walletContents.Add(card);
        }

        public Wallet()
        {
            _walletContents = new List<Card> { };
        }

        public decimal Interest
        {
            get
            {
                var ret = 0m;
                foreach (var card in _walletContents)
                {
                    ret += card.Interest;
                }
                return ret;
            }
        }
    }
}
