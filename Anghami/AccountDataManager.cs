using System;
using System.Collections.Generic;

namespace Anghami
{
    public static class AccountDataManager
    {
        static public String[] GetAccount(string username, string password){

            String[] FoundAccount;
            FoundAccount = TestData.DbAccounts.Find(x => (x[1].Equals(username.ToLower())) && (x[2].Equals(password)));
            return FoundAccount;

        }

        static public void AddAccount (string username, string password){
            ///TODO

        }

        static public bool IsUsernameUnique (string username){
            ///TODO
            return true;
        }

        static public void ChangeUserTypeToPremium(string username)
        {
            ///TODO
        }

        static public void ChangeUserTypeToFree(string username)
        {
            ///TODO
        }
    }
}
