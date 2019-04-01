using System;

namespace Anghami
{
    public class FreeUser : Account
    {
        private int _songlimit = 100;

        public FreeUser(int id, string username, string password) : base(id, username, password)
        {
        }

        override public void PlayTrack(Track Track)
        {
            //TODO
        }
    }
}
