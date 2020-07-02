using System;

namespace Homework5.Models
{
    public class Card {
        public string NumberCard;
        public string Pin;
        private string _fullName;
        private decimal _balance;
        

        public Card()
        {
            
        }

        public Card(string numbercard, string pin)
        {
            NumberCard = numbercard;
            Pin = pin;
        }

        public Card(string numbercard, string pin, string fullname)
        {
            NumberCard = numbercard;
             Pin = pin;
            _fullName = fullname;
        }

        public Card(string numbercard, string pin, string fullName, decimal balance)
        {
            NumberCard = numbercard;
            Pin = pin;
            _balance = balance;
            _fullName = fullName;
        }

        public decimal GetBalance()
        {
            return _balance;
        }
        public string GetClientFullName() {
            return _fullName;
        }

        public void UpdateBalance(decimal money) {
            _balance += money;
        }
        public void Getinfo()
        {
            Console.WriteLine($"Number card: {NumberCard}");
            Console.WriteLine($"Full name: {_fullName}");
            Console.WriteLine($"Balance: {_balance}");
        }
    }
}
