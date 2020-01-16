using System;
using System.Collections.Generic;

namespace SysAuth
{
    public class Auth
    {
        private bool _isLogin;
        private bool _isGuest;
        public string Username;
        private string _password;
        private string _userId;
        public string Password
        {set{_password = value;}}
        private string _lastLogin;

        public Auth(string username, string pass, string id)
        {
            Username = username;
            _password = pass;
            _userId = id;

        }

        public int login(string username, string pass)
        {
            if(validate(username, pass))
            {
                _isLogin = true;
                _isGuest = false;
                _lastLogin = DateTime.Now.ToString();
                return 200;
            }
            
            else
                return 403;
        }

        public bool validate(string username, string pass)
        {
            if(Username == username && pass == _password)
                return true;

            else
                return false;
        }

        public Dictionary<string, object> user()
        {
            Dictionary<string, object> ret = new Dictionary<string, object>();
            ret.Add("username", Username);
            ret.Add("password", _password);
            ret.Add("lastLogin", _lastLogin);
            ret.Add("user ID", _userId);
            if(_isLogin)
                ret.Add("user status", "Not Guest");
            
            else
                ret.Add("user status", "Guest");

            foreach (var d in ret)
            {
                Console.WriteLine("{0} : {1}", d.Key, d.Value);
            }
            
            Console.WriteLine();
            return ret;
        }

        public string id()
        {
            return _userId;
        }

        public string lastLogin()
        {
            return _lastLogin;
        }

        public int logout()
        {
            if(_isLogin)
            {
                _isLogin = false;
                _isGuest = true;
                return 200;
            }

            else
                return 403;
        }

        public bool check()
        {
            return _isLogin;
        }

        public bool guest()
        {
            return _isGuest;
        }
    }

}