using System;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "LagertaSuperCat!";
            string passwordInput = Console.ReadLine();
            if (password.Length == passwordInput.Length)
            {
                Console.WriteLine("Пароль верный!");
            }
            else if (password.Length > passwordInput.Length)
            {
                Console.WriteLine("Пароль неверный! Строка слишком короткая.");
            }
            else if (password.Length < passwordInput.Length)
            {
                Console.WriteLine("Пароль неверный! Строка слишком длинная.");
            }
            else
            {
                Console.WriteLine("Пароль неверный!");
            }
        }
    }
}
