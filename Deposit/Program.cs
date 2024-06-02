using System;

namespace Deposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the annual percentage: ");
            string percentInput = Console.ReadLine();

            if (!double.TryParse(percentInput, out double percent) || percent <= 0)
            {
                Console.WriteLine("Enter the correct percentage value.");
                return;
            }

            Console.Write("Enter the deposit period (months): ");
            string periodInput = Console.ReadLine();

            if (!int.TryParse(periodInput, out int period) || period < 1)
            {
                Console.WriteLine("Enter the correct value for the deposit period.");
                return;
            }

            Console.Write("Enter the deposit amount: ");
            string depositInput = Console.ReadLine();

            if (!double.TryParse(depositInput, out double deposit) || deposit < 0)
            {
                Console.WriteLine("Enter the correct deposit value.");
                return;
            }

            Console.WriteLine("Enter the year and month when you plan to make a deposit.");
            Console.Write("Year: ");
            string yearInput = Console.ReadLine();
            if (!int.TryParse(yearInput, out int year))
            {
                Console.WriteLine("You have entered the letters.");
                return;
            }
            if (year < 0)
            {
                Console.WriteLine("You have entered a negative value.");
                return;
            }

            Console.Write("Month: ");
            string monthInput = Console.ReadLine();
            if (!int.TryParse(monthInput, out int month))
            {
                Console.WriteLine("You have entered the letters.");
                return;
            }
            if (month < 0 || month > 12)
            {
                Console.WriteLine("You have entered a negative value.");
                return;
            }

            Console.WriteLine();

            int allMonthes = 12;

            double monthlyRate = (percent / 100) / allMonthes;
            Console.WriteLine($"Effective rate: {monthlyRate}");
            Console.WriteLine();

            double depositTemp = deposit;

            for (int i = 1; i <= period; i++)
            {
                int daysInMonth = GetDays(IsLeapYear(year), month);

                int daysInYear;
                if (IsLeapYear(year))
                {
                    daysInYear = 366;
                }
                else
                {
                    daysInYear = 365;
                }

                double profit = (depositTemp * monthlyRate * daysInMonth) / daysInYear;
                depositTemp += profit;
                Console.WriteLine($"Profit for {month} month is {profit}");
                Console.WriteLine();
                month++;
                if (month == 13)
                {
                    year++;
                    month = 1;
                }
            }

            double finalProfit = depositTemp - deposit;
            Console.WriteLine($"After the end of the deposit period, you will receive: {finalProfit}");
            Console.WriteLine();
        }

        static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int GetDays(bool IsLeapYear, int month)
        {
            int daysInMonth;

            if (month == 2)
            {
                daysInMonth = IsLeapYear ? 29 : 28;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                daysInMonth = 30;
            }
            else
            {
                daysInMonth = 31;
            }

            return daysInMonth;
        }
    }
}
