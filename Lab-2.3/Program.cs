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
                    Console.Write("Please enter first and last name: ");

                    string name = Console.ReadLine();
                    string pattern = @"^([A-z'-]+\s+){1,2}[A-z'-]+$";

                    bool validate = RegexValidate(name, pattern);
                    Console.WriteLine(validate);


                    Console.Write("Please enter email address: ");

                    string email = Console.ReadLine();
                    pattern = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";

                    validate = RegexValidate(email, pattern);
                    Console.WriteLine(validate);


                    Console.Write("Please enter phone number: ");

                    string phoneNumber = Console.ReadLine();
                    pattern = @"^\s*(?:\+?(\d{1,3}))?([-. (]*(\d{3})[-. )]*)?((\d{3})[-. ]*(\d{2,4})(?:[-.x ]*(\d+))?)\s*$";

                    validate = RegexValidate(phoneNumber, pattern);
                    Console.WriteLine(validate);


                    Console.Write("Please enter date: ");

                    string date = Console.ReadLine();
                    pattern = @"^(((0[1-9]|[12][0-9]|3[01])[- /.](0[13578]|1[02])|(0[1-9]|[12][0-9]|30)[- /.](0[469]|11)|(0[1-9]|1\d|2[0-8])[- /.]02)[- /.]\d{4}|29[- /.]02[- /.](\d{2}(0[48]|[2468][048]|[13579][26])|([02468][048]|[1359][26])00))$";

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
