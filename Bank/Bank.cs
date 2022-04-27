using System;

public class Bank
{

    private Account[] accountsArray = new Account[9];
    public bool AddAccount(Account acct)
    {
        bool acctAdded = false;

        for (int i = 0; i < accountsArray.Length; i++)
        {
            if (accountsArray[i] == null)
            {
                accountsArray[i] = acct;
                acctAdded = true;
                break;
            }
            else
            {
                acctAdded = false;
            }
        }

        return acctAdded;

    }


  
    public void ApplyDeposits()
    {
        for(int i = 0; i < accountsArray.Length; i++)
        {
            if (accountsArray[i] != null)
            {
                accountsArray[i].UpdateAcctBal();
            }
            else
                break;   
        }
    }




    public override string ToString()
    {
        string str = "";

        for(int i = 0; i < accountsArray.Length; i++)
        {
            if (accountsArray[i] != null )
            {
                str += accountsArray[i].ToString() + "\n\n";
            }
            else
            {
                str += $"No account found at index {i}\n\n";
            }

        }

        return str;
    }


}
