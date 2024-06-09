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

            switch (product)
            {
                case "product1":
                    {
                        Console.Write("Enter the number of products: ");
                        string amountInput = Console.ReadLine();

                        if (!int.TryParse(amountInput, out int amountProduct1))
                            Console.Write("Try again.");
                        else
                        {
                            int amountProduct2 = 0;
                            Console.WriteLine($"Products: {product} x{amountProduct1}");
                            int OrderCostWithoutDiscount = costProduct1 * amountProduct1;
                            Console.WriteLine($"Cost without discount: {OrderCostWithoutDiscount}");

                            bool isDiscount5Percent = (amountProduct1 + amountProduct2) >= 10 || OrderCostWithoutDiscount >= 1000;
                            bool isDiscount10Percent = (amountProduct1 + amountProduct2) >= 10 && OrderCostWithoutDiscount >= 1000;

                            if (isDiscount5Percent && !isDiscount10Percent)
                                Console.WriteLine(Discount5Percent(amountProduct1, amountProduct2, OrderCostWithoutDiscount));
                            if (isDiscount10Percent)
                                Console.WriteLine(Discount10Percent(amountProduct1, amountProduct2, OrderCostWithoutDiscount));
                        }
                        break;
                    }
                case "product2":
                    {
                        Console.Write("Enter the number of products: ");
                        string amountInput = Console.ReadLine();

                        if (!int.TryParse(amountInput, out int amountProduct2))
                            Console.Write("Try again.");
                        else
                        {
                            int amountProduct1 = 0;
                            Console.WriteLine($"Products: {product} x{amountProduct2}");
                            int OrderCostWithoutDiscount = costProduct2 * amountProduct2;
                            Console.WriteLine($"Cost without discount: {OrderCostWithoutDiscount}");

                            bool isDiscount5Percent = (amountProduct1 + amountProduct2) >= 10 || OrderCostWithoutDiscount >= 1000;
                            bool isDiscount10Percent = (amountProduct1 + amountProduct2) >= 10 && OrderCostWithoutDiscount >= 1000;

                            if (isDiscount5Percent && !isDiscount10Percent)
                                Console.WriteLine(Discount5Percent(amountProduct1, amountProduct2, OrderCostWithoutDiscount));
                            if (isDiscount10Percent)
                                Console.WriteLine(Discount10Percent(amountProduct1, amountProduct2, OrderCostWithoutDiscount));
                        }
                        break;
                    }
                case "both products":
                    {
                        Console.Write("Enter the number of product1: ");
                        string amountProduct1Input = Console.ReadLine();

                        Console.Write("Enter the number of product2: ");
                        string amountProduct2Input = Console.ReadLine();

                        if (!int.TryParse(amountProduct1Input, out int amountProduct1) || !int.TryParse(amountProduct2Input, out int amountProduct2))
                            Console.Write("Try again.");
                        else
                        {
                            Console.WriteLine($"Products: product1 x{amountProduct1} {Environment.NewLine}\t  product2 x{amountProduct2}");
                            int OrderCostWithoutDiscount = (costProduct1 * amountProduct1) + (costProduct2 * amountProduct2);
                            Console.WriteLine($"Cost without discount: {OrderCostWithoutDiscount}");

                            bool isDiscount5Percent = (amountProduct1 + amountProduct2) >= 10 || OrderCostWithoutDiscount >= 1000;
                            bool isDiscount10Percent = (amountProduct1 + amountProduct2) >= 10 && OrderCostWithoutDiscount >= 1000;

                            if (isDiscount5Percent && !isDiscount10Percent)
                                Console.WriteLine(Discount5Percent(amountProduct1, amountProduct2, OrderCostWithoutDiscount));
                            if (isDiscount10Percent)
                                Console.WriteLine(Discount10Percent(amountProduct1, amountProduct2, OrderCostWithoutDiscount));
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Incorrect product.");
                    break;
            }
        }

        static String Discount5Percent(int amountProduct1, int amountProduct2, int OrderCostWithoutDiscount)
        {
            int OrderCostWitDiscount = OrderCostWithoutDiscount - OrderCostWithoutDiscount * 5 / 100;
            return $"Cost with discount 5%: {OrderCostWitDiscount}";
        }

        static String Discount10Percent(int amountProduct1, int amountProduct2, int OrderCostWithoutDiscount)
        { 
            int OrderCostWitDiscount = OrderCostWithoutDiscount - OrderCostWithoutDiscount * 10 / 100;
            return $"Cost with discount 10%: {OrderCostWitDiscount}";
        }
    }
}