using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    class Program
    {
        public const string DBconnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\C#\Clients\Clients\Shop.mdf;Integrated Security=True";

        private static void Main(string[] args)
        {
            //Client newClient = new Client("Martin", "Fourcade", "M", new DateTime(1990,3,1));
            //newClient.Bying("Overwatch", 1999);
            //PrefferedClient c1 = new PrefferedClient(newClient,);
            Interaction();
        }

        private static void Interaction()
        {
            while (true)
            {
                Console.WriteLine("Выберете, что хотите сделать: ");
                Console.WriteLine("1 - Добавить клиента");
                Console.WriteLine("2 - Добавить покупку(клиент, ее осущетсвивший, должен быть в базе, и необходимо знать его ID)");
                Console.WriteLine("3 - Повысить существующего клиента до постоянного\n");
                Console.WriteLine("4 - Вывести всех клиентов");
                Console.WriteLine("5 - Вывести все покупки");
                Console.WriteLine("6 - Выход");
                int choice;
                Int32.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        AddClient();
                        break;
                    case 2:
                        Console.WriteLine(2);
                        break;
                    case 3:
                        Console.WriteLine(3);
                        break;
                    case 4:
                        Console.WriteLine(3);
                        break;
                    case 5:
                        Console.WriteLine(3);
                        break;
                    case 6:
                        Console.WriteLine(3);
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
                Console.WriteLine("\n\n");
            }
        }

        private static void AddClient()
        {
            //TODO check to valid input
            Console.Write("Имя: ");
            var name = Console.ReadLine();
            Console.Write("Фамилия: ");
            var lastName = Console.ReadLine();
            Console.Write("Пол: ");
            var sex = Console.ReadLine();
            Console.Write("День рождения(YYYY.MM.DD): ");
            var bday = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, lastName, sex, bday);

        }
        PrefferedClient PromoteToPreffered(Client subj)
        {
            throw new NotImplementedException();
        }


    }
}
