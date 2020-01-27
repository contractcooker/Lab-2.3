using System;
using System.Text.RegularExpressions;

namespace Lab_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Write a method that will validate names.Names can only have
                //alphabets, they should start with a capital letter, and they
                //have a maximum length of 30.

                {
                    Console.Write("Please enter first name: ");

                    string name = Console.ReadLine();
                    string pattern = @"^[A-Z]{1}[A-z'-]{1,29}$";

                    bool validate = RegexValidate(name, pattern);
                    Console.WriteLine(validate);


                    Console.Write("Please enter email address: ");

                    string email = Console.ReadLine();
                    pattern = @"^([A-z]{5,30}\@)[A-z]{5,10}(\.\w{2,3})$";

                    validate = RegexValidate(email, pattern);
                    Console.WriteLine(validate);


                    Console.Write("Please enter phone number: ");

                    string phoneNumber = Console.ReadLine();
                    pattern = @"^\d{3}(\s?-?\s?)\d{3}(\s?-?\s?)\d{4}$";

                    validate = RegexValidate(phoneNumber, pattern);
                    Console.WriteLine(validate);


                    Console.Write("Please enter date: ");

                    string date = Console.ReadLine();
                    pattern = @"^\d{2}\/\d{2}\/\d{4}$";

                    validate = RegexValidate(date, pattern);
                    Console.WriteLine(validate);
                }

            }
        }
        static bool RegexValidate(string data, string regex)
        {
            if (Regex.IsMatch(data, regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
