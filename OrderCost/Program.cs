using System;

namespace OrderCost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What products do you want to buy?");
            Console.WriteLine("Products: product1, product2 or both products.");
            Console.WriteLine("Enter: ");
            string product = Console.ReadLine();

            int costProduct1 = 100;
            int costProduct2 = 200;

            int OrderCostWithoutDiscount = 0;
            int amountProduct1 = 0;
            int amountProduct2 = 0;



            switch (product)
            {
                case "product1":
                    {
                        Console.Write("Enter the number of products: ");
                        string amountInput = Console.ReadLine();

                        if (!int.TryParse(amountInput, out amountProduct1))
                            Console.Write("Try again.");
                        else
                        {
                            Console.WriteLine($"Products: {product} x{amountProduct1}");
                        }
                        break;
                    }
                case "product2":
                    {
                        Console.Write("Enter the number of products: ");
                        string amountInput = Console.ReadLine();

                        if (!int.TryParse(amountInput, out amountProduct2))
                            Console.Write("Try again.");
                        else
                        {
                            Console.WriteLine($"Products: {product} x{amountProduct2}");
                        }
                        break;
                    }
                case "both products":
                    {
                        Console.Write("Enter the number of product1: ");
                        string amountProduct1Input = Console.ReadLine();

                        Console.Write("Enter the number of product2: ");
                        string amountProduct2Input = Console.ReadLine();

                        if (!int.TryParse(amountProduct1Input, out amountProduct1) || !int.TryParse(amountProduct2Input, out amountProduct2))
                            Console.Write("Try again.");
                        else
                        {
                            Console.WriteLine($"Products: product1 x{amountProduct1} {Environment.NewLine}\t  product2 x{amountProduct2}");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Incorrect product.");
                    break;
            }
            OrderCostWithoutDiscount = (costProduct1 * amountProduct1) + (costProduct2 * amountProduct2);
            string discount = Discount(amountProduct1, amountProduct2, OrderCostWithoutDiscount);

            Console.WriteLine($"Cost without discount: {OrderCostWithoutDiscount}");
            Console.WriteLine(discount);
        }

        static String Discount(int amountProduct1, int amountProduct2, int OrderCostWithoutDiscount)
        {
            if ((amountProduct1 + amountProduct2) >= 10 && OrderCostWithoutDiscount >= 1000)
	        {
                int OrderCostWitDiscount = OrderCostWithoutDiscount - OrderCostWithoutDiscount * 10 / 100;
                return $"Cost with discount 10%: {OrderCostWitDiscount}";
            }
            if ((amountProduct1 + amountProduct2) >= 10 || OrderCostWithoutDiscount >= 1000)
            {
                int OrderCostWitDiscount = OrderCostWithoutDiscount - OrderCostWithoutDiscount * 5 / 100;
                return $"Cost with discount 5%: {OrderCostWitDiscount}";
            }
            else
                return "No Discount";
        }
    }
}