using System;
using System.Collections.Generic;

namespace Anghami
{
    abstract public class Account
    {
        private int _sessionID { get; set; }
        private string _username { get; set; }
        private string _password { get; set; }
        private string _userType { get; set; }

        public Account( int sessionID,string username, string password )
        {
            _username = username;
            _password = password;
            _sessionID = sessionID;
        }

        public List<Track> SearchMusic<T>(T Keyword)
        {
            //TODO
            return new List<Track>();
        }

        virtual public void PlayTrack (Track Track)
        {
            //TODO
        }


    }
}
