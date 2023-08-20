using System;
using System.Collections.Generic;

namespace CRMApp {
    public class Customer1 {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public List<Sale> Sales { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Customer1() {
            Sales = new List<Sale>();
            Tickets = new List<Ticket>();
        }

        public override string ToString() {
            return $"{FirstName} {LastName} (Customer ID: {CustomerId})";
        }
    }
}
