using System;

namespace Deposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите годовой процент: ");
            string percentInput = Console.ReadLine();

            Console.Write("Введите срок вклада (мес): ");
            string periodInput = Console.ReadLine();

            Console.Write("Введите сумму вклада: ");
            string summOfDepositInput = Console.ReadLine();

            if (!double.TryParse(percentInput, out double percent) || percent <= 0 ||
                    !int.TryParse(periodInput, out int period) || period < 1 || period > 12 ||
                    !double.TryParse(summOfDepositInput, out double summOfDeposit) || summOfDeposit < 0)
            {
                Console.WriteLine("Вы ввели некоректные значения.");
            }
            else
            {
                int allMonthes = 12;
                int daysInMonth = 30;
                int daysInYear = 365;

                double monthlyRate = (percent / 100) / allMonthes; 
                Console.WriteLine($"Эффективная ставка: {monthlyRate}");

                double summOfDepositTemp = summOfDeposit;

                for (int i = 1; i <= period; i++)
                {
                    double award = (summOfDepositTemp * monthlyRate * daysInMonth) / daysInYear;
                    summOfDepositTemp += award;
                }

                double finalAward = summOfDepositTemp - summOfDeposit;
                Console.Write($"После окончания срока депозита вы получите: {finalAward}");
            }
        }
    }
}
