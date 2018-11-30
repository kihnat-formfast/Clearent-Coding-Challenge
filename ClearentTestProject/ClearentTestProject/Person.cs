using System;
using System.Collections.Generic;
using System.Text;

namespace ClearentTestProject
{
    class Person
    {
        //This class contains Wallets and the interest information about the sum of said wallets
        private List<Wallet> _personContents;
        public List<Wallet> PersonContents
        {
            get
            {
                return _personContents;
            }
        }

        public void Add(Wallet wallet)
        {
            _personContents.Add(wallet);
        }

        public Person()
        {
            _personContents = new List<Wallet> { };
        }

        public decimal Interest
        {
            get
            {
                var ret = 0m;
                foreach (var wallet in _personContents)
                {
                    ret += wallet.Interest;
                }
                return ret;
            }
        }
    }
}
