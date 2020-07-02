using Homework5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

namespace Homework5.Logic
{
    class Bankomat {
        public delegate void Message(string message);
        public event Message Notify;
    
        private List<Card> cards = new List<Card>();

        public void Addcard(string numbercard, string pin,string fullname, decimal balance) {
            Card card = new Card(numbercard,pin,fullname,balance);
            cards.Add(card);
        }
        public void Take(string numbercard, decimal money)
        {
            Card card = cards.SingleOrDefault(c => c.NumberCard == numbercard);
            if (card != null)
            {
                decimal clientBalance = card.GetBalance();
                if (clientBalance > money)
                {
                    card.UpdateBalance(-money);
                    Notify?.Invoke($"{money} take off with your card");
                }
                else
                {
                    Notify?.Invoke("Not enough money on your card");
                }
            }
        }
        public void Put(string numbercard,decimal money) {
            Card card = cards.SingleOrDefault(c=> c.NumberCard==numbercard);
            if (card!= null) {
                card.UpdateBalance(money);
                Notify?.Invoke($"{money} putt on your card");
            }
        }

        public bool Checkclient(string numbercard,string pincode) {
            bool cheking = false;

            Card card = cards.SingleOrDefault(c => c.NumberCard == numbercard);
            if (card != null)
            {
                if (pincode == card.Pin)
                {
                    string name = card.GetClientFullName();
                    Console.WriteLine($"{name} welcom in the bankomat YetiBank");
                    cheking = true;
                }
                else
                {
                    Console.WriteLine("pincod incorrect");
                    cheking = false;
                }
            }
            else {
                Console.WriteLine("Card not found");
            }
            return cheking;
        }
        public void GetClienBalance(string numbercard) {
            Card card = cards.SingleOrDefault(c => c.NumberCard == numbercard);
            if (card != null)
            {
                Console.WriteLine(card.GetBalance());
                
            }
        }
        public void Moneytransfer(string numbercardclient, string numbercardtransfer,decimal money) {
            Card card = cards.SingleOrDefault(c => c.NumberCard == numbercardclient);
            if (card != null)
            {
                Card cardtransfer = cards.SingleOrDefault(c => c.NumberCard == numbercardtransfer);
                if (card != null)
                {
                    decimal clientBalance = card.GetBalance();
                    if (clientBalance > money)
                    {
                        card.UpdateBalance(-money);
                        cardtransfer.UpdateBalance(money);
                        Notify?.Invoke("Transfert conselled correctly");
                    }
                    else
                    {
                        Notify?.Invoke("Not enough money on your card");
                    }
                }
                else {
                    Notify?.Invoke("Card from transfer not found");
                }
            }
        }
        public void GetInfoClients() {
            foreach (var card in cards) {
                card.Getinfo();
            }
        }
    }
}
