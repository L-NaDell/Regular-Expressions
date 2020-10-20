using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a valid name: ");
            string name = Console.ReadLine();
            Console.WriteLine("\n" + validateName(name));

            Console.Write("\n Please enter a valid email: ");
            string email = Console.ReadLine();
            Console.WriteLine("\n" + validateEmail(email));

            Console.Write("\n Please enter a valid phone number: ");
            string phoneNum = Console.ReadLine();
            Console.WriteLine("\n" + validatePhoneNumber(phoneNum));

            Console.Write("\n Please enter a valid date: ");
            string date = Console.ReadLine();
            Console.WriteLine("\n" + validateDate(date));

            Console.Write("\t Please enter a valid HTML element: ");
            string html = Console.ReadLine();
            Console.WriteLine("\n" + validateHtml(html));
        }

        //name, max length of 30
        public static string validateName(string name)
        {
            Regex rg = new Regex("^[A-Z]{1}[a-z]{1,29}$");

            if (rg.Match(name).Success)
            {
                return $"Thank you, {name} is valid!";
            }
            else
                return $"Sorry, {name} is not valid.";
        }

        //email
        public static string validateEmail(string email)
        {
            Regex rg = new Regex("^[A-Za-z0-9]{5,30}[@][A-Za-z0-9]{5,10}[.][A-Za-z0-9]{2,3}$");

            if (rg.Match(email).Success)
            {
                return $"Thank you, {email} is valid!";
            }
            else
                return $"Sorry, {email} is not valid.";
        }

        //{3 digits}-{3 digits}-{4 digits}
        public static string validatePhoneNumber(string phoneNum)
        {
            Regex rg = new Regex("^[2-9]{3}[-][0-9]{3}[-][0-9]{4}$");

            if (rg.Match(phoneNum).Success)
            {
                return $"Thank you, {phoneNum} is valid!";
            }
            else
                return $"Sorry, {phoneNum} is not valid.";
        }

        //(dd/mm/yyyy)
        public static string validateDate(string date)
        {
            Regex rg = new Regex("^(0[1-9]|[12][0-9]|3[01])(\\-|\\/)(0[1-9]|1[0-2])(\\-|\\/)(19|20)[0-9]{2}$");

            if (rg.Match(date).Success)
            {
                return $"Thank you, {date} is valid!";
            }
            else
                return $"Sorry, {date} is not valid.";
        }

        //HTML Test <p>..<p>
        public static string validateHtml(string html)
        {
            Regex rg = new Regex("<\\s*([^ >]+)[^>]*>.*?<\\s*\\s*\\1\\s*>$");

            if (rg.Match(html).Success)
            {
                return $"Thank you, your HTML is valid!";
            }
            else
                return $"Sorry, that is not valid HTML.";
        }
    }
}
