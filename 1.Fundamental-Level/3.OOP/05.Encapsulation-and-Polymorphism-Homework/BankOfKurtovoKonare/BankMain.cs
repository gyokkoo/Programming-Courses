using System;
using BankOfKurtovoKonare.Models;

namespace BankOfKurtovoKonare
{
    public class BankMain
    {
        public static void Main()
        {
            Console.Title = "Problem 2.	Bank of Kurtovo Konare";

            Deposit goshoDeposit = new Deposit(Customer.Individuals, 1000m, 0.05m);
            goshoDeposit.DepositMoney(450);
            goshoDeposit.WithdrawMoney(400);
            Console.WriteLine(goshoDeposit + "Interest = " + goshoDeposit.CalculateInterest(10));
            Console.WriteLine();

            Loan carskiZaem = new Loan(Customer.Companies, 50000m, 0.1m);
            carskiZaem.DepositMoney(1);
            Console.WriteLine(carskiZaem + "Interest = " + carskiZaem.CalculateInterest(5));
            Console.WriteLine();

            Mortgage bmwPesho = new Mortgage(Customer.Individuals, 10000m, 0.01m);
            bmwPesho.DepositMoney(5000);
            Console.WriteLine(bmwPesho + "Interest = " + bmwPesho.CalculateInterest(30));
        }
    }
}
