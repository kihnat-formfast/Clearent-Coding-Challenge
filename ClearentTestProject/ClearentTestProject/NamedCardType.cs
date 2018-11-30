using System;
using System.Collections.Generic;
using System.Text;

namespace ClearentTestProject
{
    class NamedCardType
    {
        //This is a class for the purposes of enumerating the different card types and their interest.
        private readonly decimal _interest;
        public decimal Interest
        {
            get { return _interest; }
        }

        private readonly string _displayName;
        public string DisplayName
        {
            get { return _displayName; }
        }

        public static readonly NamedCardType Visa
            = new NamedCardType(0.10m, "Visa");
        public static readonly NamedCardType MasterCard
            = new NamedCardType(0.05m, "Master Card");
        public static readonly NamedCardType Discover
            = new NamedCardType(0.01m, "Discover");

        private NamedCardType() { }
        private NamedCardType(decimal interest, string displayName)
        {
            _interest = interest;
            _displayName = displayName;
        }
    }
}
