using System;

public class Account
{

    public string AccountID { set; get; }

    public string AccountName { set; get; }

    double[,] Deposits;

    private double Balance;


    public Account(string acctID, string acctName, double[,] deposits)
    {
        AccountID = acctID;
        AccountName = acctName;
        Deposits = deposits;
    }
    public Account(Account acct) : this(acct.AccountID, acct.AccountName, acct.Deposits)
    {

    }
    public void UpdateAcctBal()
    {

        for (int i = 0; i < Deposits.GetLength(0); i++)
        {

            for (int j = 0; j < Deposits.GetLength(1); j++)
            {
                if (Deposits[i, j] != 0)
                {
                    Balance = Deposits[i, j] + Balance;

                    Console.Write($"{i},{j} ");

                    break;
                }
            }

        }

    }


    public override string ToString()
    {
        string printDeposits;
        //string str = ($"\nID: {AccountID} \n\nName: {AccountName}\n\nDepostits: \n\nBalance: {Balance} ");

        for (int i = 0; i < Deposits.GetLength(0); i++)
        {
            for (int j = 0; j < Deposits.GetLength(1); j++)
            {
                printDeposits = $"{i},{j} {Deposits[i, j]}";
            }
        }

        //string str = ($"\nID: {AccountID} \n\nName: {AccountName}\n\nDepostits:  \n\nBalance: {Balance} ");

        string str = ($"\nID: {AccountID} \n\nName: {AccountName}\n\nDepostits: {Deposits}\n\nBalance: {Balance} ");



       // string str = String.Format("ID: {1} \n\nName: {2} \n\nDeposits: {3} \n\nBalance: {4}\n\n ",
       // AccountID,
       // AccountName,
       // Deposits,
       // Balance);

        return str;
    }




}
