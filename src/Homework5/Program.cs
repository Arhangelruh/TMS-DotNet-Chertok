
using Homework5.Logic;
using System;

namespace Homework5
{
    
    class Program
    {
        public static Bankomat bankomat = new Bankomat();
        static void Main(string[] args)
        {
            AddClientsBank();
            bankomat.Notify += Message;
            while (true) {                
                Console.WriteLine("Enter your card:");
                string card = Console.ReadLine();
                Console.WriteLine("Enter your pin code:");
                string pincode = Console.ReadLine();
                bool checkout=bankomat.Checkclient(card,pincode);
                if (checkout) {
                    while (true) {
                        ShowMessage();
                        bool exit = false;
                        int.TryParse(Console.ReadLine(), out int userInput);
                        switch (userInput) {
                            case 1: 
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter summ for put on your card");
                                        decimal money = Convert.ToDecimal(Console.ReadLine());
                                        bankomat.Put(card, money);
                                    }
                                    catch {
                                        Console.WriteLine("Incorrect summ");
                                    }
                                }
                                break;
                            case 2:
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter summ for put on your card");
                                        decimal money = Convert.ToDecimal(Console.ReadLine());
                                        bankomat.Take(card, money);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Incorrect summ");
                                    }
                                }
                                break;
                            case 3:
                                {
                                    bankomat.GetClienBalance(card);
                                }
                                break;
                            case 4:
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter card for transfer:");
                                        string cardfromtransfer = Console.ReadLine();
                                        Console.WriteLine("Enter summ for transfer:");
                                        decimal money = Convert.ToDecimal(Console.ReadLine());
                                        bankomat.Moneytransfer(card, cardfromtransfer,money);
                                    }
                                    catch {
                                        Console.WriteLine("Incorrect summ");
                                    }
                                }
                                break;
                            case 5:
                                {
                                    exit = true;
                                }
                                break;
                            case 6:
                                {
                                    bankomat.GetInfoClients();
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Command not faund");
                                }
                                break;
                        }
                        if (exit) { break; } 
                    }
                }
            }
        }

        private static void Message(string message)
        {
            Console.WriteLine(message);
        }

        public static void AddClientsBank() {
            bankomat.Addcard("1234567890","1234","Петров Петр Петрович",0M);
            bankomat.Addcard("0987654321", "4321", "Иванов Петр Петрович",100M);
            bankomat.Addcard("1234509876", "1243", "Иванов Иван Петрович",200M);
            bankomat.Addcard("5432167890", "2134", "Петров Иван Петрович",300M);
            bankomat.Addcard("6789012345", "3412", "Иванов Иван Иванович",400M);
        }
        public static void ShowMessage() {
            Console.WriteLine("\nSelect an operation");
            Console.WriteLine("1:Put money on card");
            Console.WriteLine("2:Take money on card");
            Console.WriteLine("3:Get balance");
            Console.WriteLine("4:Money transfer");
            Console.WriteLine("5:Exit");
           // Console.WriteLine("PS:6:Getinfo all clients(from admin):)");
        }
    }
}
