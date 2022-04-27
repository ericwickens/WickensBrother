using System;

public class BankTest
{
    public static void Main()
    {
        Bank myBank = new Bank();

        //create 2d array and pass the array through the parameters

        double[,] acctArry1 = new double[,] { { 200.99, 95.68, 77.27, 99.50 },
                                { 35.25, 900.25, 700.99, 80.36 },
                                { 100.25, 450.55, 200.55, 879.95 } };

        Account acct1 = new Account("100", "Charles Driver", acctArry1);

        Console.WriteLine(myBank.AddAccount(acct1));

        Account acct2 = new Account("101", "Rick Driver", acctArry1);

        Console.WriteLine(myBank.AddAccount(acct2));

        Account acct3 = new Account("102", "Wes Beddow", acctArry1);

        Console.WriteLine(myBank.AddAccount(acct3));

        Account acct4 = new Account("103", "Charles Driver", acctArry1);

        Console.WriteLine(myBank.AddAccount(acct4));

        Account acct5 = new Account("104", "Rick Driver", acctArry1);

        Console.WriteLine(myBank.AddAccount(acct5));

        Account acct6 = new Account("105", "Wes Beddow", acctArry1);

        Console.WriteLine(myBank.AddAccount(acct6));

        Account acct7 = new Account("106", "Charles Driver", acctArry1);

        Console.WriteLine(myBank.AddAccount(acct7));

        Account acct8 = new Account("107", "Rick Driver", acctArry1);

        Console.WriteLine(myBank.AddAccount(acct8));

        Account acct9 = new Account("108", "Wes Beddow", acctArry1);

        Console.WriteLine(myBank.AddAccount(acct9));

        Account acct10 = new Account("109", "Wes Beddow", acctArry1);

        Console.WriteLine(myBank.AddAccount(acct10));

        Console.WriteLine(myBank);

    }



}