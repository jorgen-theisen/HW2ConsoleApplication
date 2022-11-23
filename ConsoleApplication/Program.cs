using System;
using TransactionTypeDefinition;

namespace ConsoleApplication {
    class Program {
        static void Main(string[] args)
        {
            // Variable declaration
            double currentValue;
            int nominal;
            double price;
            TransactionType transactionType;

            Console.WriteLine("Input the nominal of the trade: ");
            var userInput = Console.ReadLine();
            nominal = int.Parse(userInput);

            Console.WriteLine("Enter price of the asset: ");
            userInput = Console.ReadLine();
            price = double.Parse(userInput);

            Console.WriteLine("Input transaction type (Buy/Sell): ");
            userInput = Console.ReadLine();
            transactionType = (TransactionType) Enum.Parse(typeof(TransactionType), userInput,true);

            currentValue = (transactionType == TransactionType.Buy ? 1 : -1) * nominal * price;

            Console.WriteLine($"The current value of the trade is {currentValue}.");


        }
    }
}
