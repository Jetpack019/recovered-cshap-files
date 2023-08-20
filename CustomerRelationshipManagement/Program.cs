using System;
using System.Collections.Generic;

namespace CRMApp {
    class Program {
        static void Main(string[] args) {
            List<Customer1> customers = new List<Customer1>();

            Customer1 customer1 = new Customer1 { CustomerId = 1, FirstName = "Alice", LastName = "Johnson", DateOfBirth = new DateTime(1985, 5, 10), Email = "alice@example.com" };
            Customer1 customer2 = new Customer1 { CustomerId = 2, FirstName = "Bob", LastName = "Smith", DateOfBirth = new DateTime(1990, 8, 15), Email = "bob@example.com" };

            Sale sale1 = new Sale { SaleId = 1, ProductName = "Laptop", Amount = 999.99M };
            Sale sale2 = new Sale { SaleId = 2, ProductName = "Smartphone", Amount = 599.99M };

            Ticket ticket1 = new Ticket { TicketId = 1, Subject = "Technical Support", Description = "Having trouble with laptop.", IsResolved = false };
            Ticket ticket2 = new Ticket { TicketId = 2, Subject = "Product Inquiry", Description = "Interested in smartphone features.", IsResolved = true };

            customer1.Sales.Add(sale1);
            customer2.Sales.Add(sale2);

            customer1.Tickets.Add(ticket1);
            customer2.Tickets.Add(ticket2);

            customers.Add(customer1);
            customers.Add(customer2);

            Console.WriteLine("CRM System:");
            foreach (Customer1 customer in customers) {
                Console.WriteLine(customer);
                Console.WriteLine("Sales:");
                foreach (Sale sale in customer.Sales) {
                    Console.WriteLine($"  - {sale.ProductName} - {sale.Amount:C}");
                }
                Console.WriteLine("Tickets:");
                foreach (Ticket ticket in customer.Tickets) {
                    Console.WriteLine($"  - {ticket.Subject} - {(ticket.IsResolved ? "Resolved" : "Pending")}");
                }
            }
        }
    }
}
