using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.GetEncoding("utf-16");
            XDocument xDocument = new XDocument();
            Person p;
            string name;
            string street;
            string houseNumber;
            string flatNumber;
            string mobilePhone;
            string flatPhone;

            while (true)
            {
                Console.WriteLine("Введите имя");
                name = Console.ReadLine();
                Console.WriteLine("Введите улицу");
                street = Console.ReadLine();
                Console.WriteLine("Введите номер дома");
                houseNumber = Console.ReadLine();
                Console.WriteLine("Введите номер квартиры");
                flatNumber = Console.ReadLine();
                Console.WriteLine("Введите мобильный номер");
                mobilePhone = Console.ReadLine();
                Console.WriteLine("Введите домашний номер");
                flatPhone = Console.ReadLine();
                xDocument.Add(new Person(name, street, houseNumber, flatNumber, mobilePhone, flatPhone).SerializePerson());
                Console.WriteLine("Желаете продолжить? Y/N");
                char temp = Console.ReadKey().KeyChar;
                if (temp == 'n' || temp == 'N' || temp == 'т' || temp == 'Т')
                {
                    break;
                }
            }
            xDocument.Save("Book.xml");
            Console.ReadKey();
        }
    }
}
