using NUnit.Framework;
using ClearentTestProject;

namespace Tests
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {

        }

        //This is the first test that I wrote for developing the card class
        
        [Test]
        public void CardTest()
        {
            var testCard = new Card(NamedCardType.Visa, 100);
            Assert.AreEqual(10, testCard.Interest);
        }

        //This is the first case from the coding challenge.  
        //1 person has 1 wallet and 3 cards (1 Visa, 1 MC, 1 Discover) – Each Card has a balance of $100 – calculate the total interest (simple interest) for this person and per card.
        [Test]
        public void TestCase1()
        {
            //Making all the card objects
            var card1 = new Card(NamedCardType.Visa, 100);
            var card2 = new Card(NamedCardType.MasterCard, 100);
            var card3 = new Card(NamedCardType.Discover, 100);

            //Putting the cards into a wallet
            var wallet1 = new Wallet();
            wallet1.Add(card1);
            wallet1.Add(card2);
            wallet1.Add(card3);

            //Giving the wallet to person
            var person1 = new Person();
            person1.Add(wallet1);         
            
            //Testing the Interest
            Assert.AreEqual(16, person1.Interest);
            Assert.AreEqual(10, card1.Interest);
            Assert.AreEqual(5, card2.Interest);
            Assert.AreEqual(1, card3.Interest);
        }

        //This is the second case from the coding challenge. 
        //1 person has 2 wallets Wallet 1 has a Visa and Discover , wallet 2 a MC - each card has $100 balance - calculate the total interest(simple interest) for this person and interest per wallet
        [Test]
        public void TestCase2()
        {
            //Making all the card objects
            var card1 = new Card(NamedCardType.Visa, 100);
            var card2 = new Card(NamedCardType.Discover, 100);

            var card3 = new Card(NamedCardType.MasterCard, 100);

            //Putting the cards into the appropriate wallet
            var wallet1 = new Wallet();
            wallet1.Add(card1);
            wallet1.Add(card2);

            var wallet2 = new Wallet();
            wallet2.Add(card3);

            //Giving the wallets to person
            var person1 = new Person();
            person1.Add(wallet1);
            person1.Add(wallet2);

            //Testing the Interest
            Assert.AreEqual(16, person1.Interest);
            Assert.AreEqual(10, card1.Interest);
            Assert.AreEqual(1, card2.Interest);
            Assert.AreEqual(5, card3.Interest);
        }

        //This is the third case from the coding challenge. 
        //2 people have 1 wallet each, person 1 has 1 wallet with 3 cards (1 MC, 1 Visa, 1 Discover), person 2 has 1 wallet with 2 cards (1 Visa, 1 MC) all cards in all wallets for both people have a $100 balance - calculate the total interest(simple interest) for each person and interest per wallet
        //I wasn't sure if I should have broken them up into multiple tests.  This is really just two tests, one per person, but I decided that the question format indicated the testing format that you expected. 
        [Test]
        public void TestCase3()
        {
            //Making all the card objects
            var card1 = new Card(NamedCardType.Visa, 100);
            var card2 = new Card(NamedCardType.MasterCard, 100);
            var card3 = new Card(NamedCardType.Discover, 100);
            var card4 = new Card(NamedCardType.Visa, 100);
            var card5 = new Card(NamedCardType.MasterCard, 100);

            //Putting the cards into the appropriate wallet
            var wallet1 = new Wallet();
            wallet1.Add(card1);
            wallet1.Add(card2);
            wallet1.Add(card3);

            var wallet2 = new Wallet();
            wallet2.Add(card4);
            wallet2.Add(card5);

            //Giving the wallet to the appropriate people
            var person1 = new Person();
            person1.Add(wallet1);

            var person2 = new Person();
            person2.Add(wallet2);

            //Testing the Interest
            Assert.AreEqual(16, person1.Interest);
            Assert.AreEqual(10, card1.Interest);
            Assert.AreEqual(5, card2.Interest);
            Assert.AreEqual(1, card3.Interest);

            Assert.AreEqual(15, person2.Interest);
            Assert.AreEqual(10, card4.Interest);
            Assert.AreEqual(5, card5.Interest);
        }
    }
}