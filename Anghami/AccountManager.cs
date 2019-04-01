using System;

namespace Anghami
{

    // Singleton Class
    public sealed class AccountManager
    {
        /////-------Ensuring that the class only has a single instance per application -------/////

        private static AccountManager instance;

        //The constructor is private to ensure that it doesn't get called outside the class
        private AccountManager()
        {
        }

        //Ensuring that we only have one instance availble at all times, if none then we create a new one
        public static AccountManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountManager();
                }
                return instance;
            }
        }

        /////-------Data Members -------/////

        //ID for the program instance per each user
        static int SessionID = 0;


        /////-------Methods-------/////

        public Account SignUp( string username, string password)
        {
            ///TODO
            return new FreeUser(SessionID++, username, password);
        }

        public Account LogIn (string username, string password)
        {
            string[] TempAccount = AccountDataManager.GetAccount(username, password);
            if (TempAccount==null)
            {
                throw new Exception("Username or Password Incorrect");
            }
            /////-------If Type == Free, return Free user object. Otherwise, return paid user object-------/////
            ///TODO
            return new FreeUser(SessionID++, username, password);               
        }


        public void LogOut()
        {
            ///TODO
        }

        public void SubscribeToPremium()
        {
            ///TODO
        }

        public void UnsubscribeFromPremium()
        {
            ///TODO
        }
    }
}
