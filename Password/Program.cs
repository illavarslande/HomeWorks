using System;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "LagertaSuperCat!";
            string passwordInput = Console.ReadLine();
            int numberCharactersInPassword = password.Length;
            int numberCharactersInPasswordInput = passwordInput.Length;
            if (password.Equals(passwordInput))
            {
                Console.WriteLine("Пароль верный!");
            }
            else if (numberCharactersInPassword > numberCharactersInPasswordInput)
            {
                Console.WriteLine("Пароль неверный! Строка слишком короткая.");
            }
            else if (numberCharactersInPassword < numberCharactersInPasswordInput)
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
