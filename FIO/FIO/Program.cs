using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FIO
{
    internal class Program
    {
        public static string IsValid(string pattern)
        {
            string data = "";
            Regex regex = new Regex(pattern);
            bool isCorrect = false;
            while(isCorrect) { 
                data = Console.ReadLine();
                if(regex.IsMatch(data))
                {
                   isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Данные введены некорректно");
                }
            }
            return data;

        }
        static void Main(string[] args)
        {

            string fioPattern = @"^[а-яА-Яa-zA-Z]{2,30}( [а-яА-Яa-zA-Z]{2,30}){2}$";
            string agePattern = @"^(?:[1-9]|[1-9][0-9]|1[0-2][0-9]|130)$";
            string emailPattern = @"^[a-zA-Z0-9_.+-]{2,}@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            string gitPattern = @"^https:\/\/github\.com\/[a-zA-Z0-9_-]{2,30}$";

            Console.WriteLine("Введите ваше ФИО:");
            string fio = IsValid(fioPattern).Replace(" ", Environment.NewLine);

            Console.WriteLine("Введите ваш возраст:");
            string age = IsValid(agePattern);

            Console.WriteLine("Введите ваш email(**@****.**):");
            string email = IsValid(emailPattern);

            Console.WriteLine("Введите ссылку на ваш github:");
            string github = IsValid(gitPattern);

            Console.WriteLine($"\nВаши данные:\nВаше ФИО:\n{fio}\nВаш возраст:\n{age}\nВаш email:\n{email}\nВаш github:\n{github}");
            Console.ReadLine();
        }
    }
}
