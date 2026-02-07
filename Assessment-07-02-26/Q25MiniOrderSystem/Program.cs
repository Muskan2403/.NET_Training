using System;
using System.Collections.Generic;


namespace MiniOrderSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var products = new List<Product>
                {
                    new Product(101, "Laptop", 500000m, 5),
                    new Product(102, "Mouse", 50000m, 10),
                    new Product(103, "Keyboard", 80000m, 7),
                    new Product(104, "Monitor", 150000m, 3),
                    new Product(105, "Printer", 120000m, 4)
                };

                var customer = new Customer(1, "Muskan");
                var order = new Order(new List<OrderItem>());

                while (true)
                {
                    Console.WriteLine("\n========== Mini Order System ==========");
                    Console.WriteLine("1. Add to Cart");
                    Console.WriteLine("2. Place Order");
                    Console.WriteLine("3. Exit");

                    Console.Write("Select option: ");
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            ShowProducts(products);
                            Console.Write("Enter Product ID: ");
                            int pid = int.Parse(Console.ReadLine());

                            Product selectedProduct = products.Find(p => p.Id == pid);
                            if (selectedProduct == null)
                            {
                                Console.WriteLine("Invalid product");
                                break;
                            }

                            Console.Write("Enter quantity: ");
                            int qty = int.Parse(Console.ReadLine());

                            order.AddToCart(selectedProduct, qty);
                            Console.WriteLine("Item added to cart");
                            break;

                        case 2:
                            var coupon = new Coupon("NEW10", 10000m, DateTime.Now.AddDays(30));

                            order.PlaceOrder(coupon);

                            var payment = new Payment(order.TotalAmount, "Credit Card");
                            payment.Process(order.TotalAmount);

                            Console.WriteLine("\nOrder placed successfully 🎉");
                            Console.WriteLine($"Invoice: {order.InvoiceNumber}");
                            Console.WriteLine($"Total: ₹{order.TotalAmount}");
                            break;

                        case 3:
                            Console.WriteLine("Thank you");
                            return;

                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Order failed: {ex.Message}");
            }
        }

        static void ShowProducts(List<Product> products)
        {
            Console.WriteLine("\nAvailable Products:");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id} - {p.Name} | ₹{p.Price} | Stock: {p.Stock}");
            }
        }
    }
}
