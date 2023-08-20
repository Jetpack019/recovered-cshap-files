using System;
using System.Collections.Generic;

namespace SocialMediaApp {
    class Program {
        static void Main(string[] args) {
            List<User> users = new List<User>();

            User user1 = new User { Username = "Alice" };
            User user2 = new User { Username = "Bob" };

            user1.Posts.Add(new Post { Content = "Hello, world!" });
            user2.Posts.Add(new Post { Content = "Enjoying a sunny day." });
            user2.Posts.Add(new Post { Content = "Just finished reading a great book." });

            users.Add(user1);
            users.Add(user2);

            Console.WriteLine("Social Media Users and Posts:");
            foreach (User user in users) {
                Console.WriteLine(user);
                foreach (Post post in user.Posts) {
                    Console.WriteLine("  - " + post);
                }
            }
        }
    }
}
