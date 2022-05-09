namespace JoiningDataLab {
    class Program
    {
        public static void Main()
        {
            Order Mouse = new Order("Acme Hardware", "Mouse", 25, 3);
            Order Keyboard = new Order("Acme Hardware", "Keyboard", 45, 2);
            Order Macbook = new Order("Falls Realty", "Macbook", 800, 2);
            Order iPad = new Order("Julie's Morning Diner", "iPad", 525, 1);
            Order CCReader = new Order("Julie's Morning Diner", "Credit Card Reader", 45, 1);
            Order Empty = new Order("Joe's Chicago Pizza", "", 0, 0);
            Order[] Orders = new Order[] { Mouse, Keyboard, Macbook, iPad, CCReader };
            string lastCustomer = "";
            decimal lastTotal = 0;
            for (int i = 0; i < Orders.Count(); i++)
            {
                Order o = Orders[i];
                string currentCustomer = o.CustomerName;
                decimal total = o.Price * o.Quantity;
               
                if (currentCustomer != lastCustomer)
                {
                    if (o.Item == "")
                    {
                        Console.WriteLine("**No Orders**");
                    }
                    if (currentCustomer == "Falls Realty")
                    {
                        o.PrintInfo(o, currentCustomer);
                        Console.WriteLine("Total: $" + total);
                        Console.WriteLine();
                        Console.WriteLine("Grand Total: $" + total + "\n");
                        Console.ReadKey();
                        

                        lastTotal = total;
                        lastCustomer = currentCustomer;
                    }
                    else
                    {
                        o.PrintInfo(o, currentCustomer);
                        Console.WriteLine("Total: $" + total);

                        lastTotal = total;
                        lastCustomer = currentCustomer;

                    }
                 
                }
                else
                {
                    Console.WriteLine($"{o.Item}/${o.Price}/{o.Quantity}");
                    Console.WriteLine($"Total: ${total}");
                    Console.WriteLine();
                    Console.WriteLine("Grand Total: $" + (total + lastTotal) + "\n");
                    Console.ReadKey();
                }





            }
        }
            public static string GetUserInput(string prompt)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                return input;
            }
        }
    }

