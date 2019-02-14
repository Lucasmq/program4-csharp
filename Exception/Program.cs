using System;
using Exception.Entities.Exceptions;
using Exception.Entities;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double balanceInit = double.Parse(Console.ReadLine());

            Console.Write("Withdraw limit: ");
            double limite = double.Parse(Console.ReadLine());

            Account acc = new Account(number, holder, balanceInit, limite);

            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine());

            try
            {
                acc.WithDraw(withdraw);
                Console.WriteLine("New balance: " + acc.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
                
            }

        }
    }
}
