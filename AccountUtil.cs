﻿using System.Threading.Channels;
using Task_4_;

public static class AccountUtil
{
    // Utility helper functions for Account class

    public static void Display(List<Account> accounts)
    {
        Console.WriteLine("\n=== Accounts ==========================================");
        foreach (var acc in accounts)
        {
            Console.WriteLine(acc.name);
        }
    }

    public static void Deposit(List<Account> accounts, double amount)
    {
        Console.WriteLine("\n=== Depositing to Accounts =================================");
        foreach (var acc in accounts)
        {
            if (acc.Deposit(amount))
                Console.WriteLine($"Deposited {amount} to {acc.name}");
            else
                Console.WriteLine($"Failed Deposit of {amount} to {acc.name}");
        }
    }

    public static void Withdraw(List<Account> accounts, double amount)
    {
        Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
        foreach (var acc in accounts)
        {
            if (acc.Withdraw(amount))
                Console.WriteLine($"Withdrew {amount} from {acc.name}");
            else
                Console.WriteLine($"Failed Withdrawal of {amount} from {acc.name}");
        }
    }
}
