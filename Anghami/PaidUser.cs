using System;
namespace Anghami
{
    public class PaidUser : Account
    {
        private DateTime _subscriptionDate;
        public PaidUser(int id, string username, string password) : base(id, username, password)
        {
            
        }
        public bool IsSubscriptionExpired()
        {
            //TODO
            return true;
        }

        public void DownloadMusic(Track Track)
        {
            //TODO
        }

        public void ShowLyrics(Track Track)
        {
            //TODO
        }

    }
}
