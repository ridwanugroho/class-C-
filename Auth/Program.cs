using System;
using System.Collections.Generic;
using SysAuth;

namespace AuthProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Auth user1 = new Auth(username: "user1", pass: "pass1", id: "user001");
            Auth user2 = new Auth(username: "user2", pass: "pass2", id: "user002");
            Auth user3 = new Auth(username: "user3", pass: "pass3", id: "user003");

            user1.user();
            user2.user();
            user3.user();
            Console.WriteLine("======== user1 login ========");
            user1.login("user1", "pass1");
            user1.user();
            Console.WriteLine("======== user2 login ========");
            user2.login("user2", "pass2");
            user2.user();
            Console.WriteLine("======== user3 login ========");
            user3.login("user3", "pass3");
            user3.user();

            Console.WriteLine("======== user1 logout ========");
            user1.logout();
            user1.user();
        }
    }
}
