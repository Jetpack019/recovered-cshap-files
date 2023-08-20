using System.Collections.Generic;

namespace SocialMediaApp {
    public class User {
        public string Username { get; set; }
        public List<Post> Posts { get; set; }

        public User() {
            Posts = new List<Post>();
        }

        public override string ToString() {
            return $"User: {Username}, Posts: {Posts.Count}";
        }
    }
}
