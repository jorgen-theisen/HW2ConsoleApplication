using System;
using TransactionTypeDefinition;

namespace ConsoleApplication {
    class Program {
        static void Main(string[] args)
        {
            // Variable declaration
            double currentValue;
            int nominal;
            double priceTrade, priceOriginal;
            TransactionType transactionType;

            Console.WriteLine("Input the nominal of the trade:");
            var userInput = Console.ReadLine();
            nominal = int.Parse(userInput);

            Console.WriteLine("Enter the traded asset price:");
            userInput = Console.ReadLine();
            priceTrade = double.Parse(userInput);

            Console.WriteLine("Enter the original asset price:");
            userInput = Console.ReadLine();
            priceOriginal = double.Parse(userInput);

            Console.WriteLine("Input transaction type (Buy/Sell):");
            userInput = Console.ReadLine();
            transactionType = (TransactionType) Enum.Parse(typeof(TransactionType), userInput,true);

            currentValue = (transactionType == TransactionType.Buy ? 1 : -1) * nominal * priceTrade;
            Console.WriteLine($"The current value of the trade is {currentValue}.");

            double profitOrLossFigure = (priceTrade - priceOriginal) * nominal * (transactionType == TransactionType.Sell ? 1 : 0 ); 

            if (transactionType == TransactionType.Sell)
            {
                if (profitOrLossFigure > 0)
                {
                    Console.WriteLine($"Profit for this trade: {profitOrLossFigure}");
                }
                else if (profitOrLossFigure < 0)
                {
                    Console.WriteLine($"Loss for this trade: {profitOrLossFigure}");
                }
                else
                {
                    Console.WriteLine($"Profit/loss for this trade: {profitOrLossFigure}");
                }
            }
            else
            {
                Console.WriteLine("Profit/loss figures only available for sell transactions.");
            }


        }
    }
}
