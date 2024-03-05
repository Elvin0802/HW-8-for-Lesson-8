using Lesson8.Models;
using Lesson8.Interfaces;

namespace Lesson8;

public class Program
{
	static void Main(string[] args)
	{
		try
		{
			CEO ceo = new CEO("ABB CEO", "CEO zade", 46, 19500, "CEO");
			Bank bank = new Bank("ABB BANK", 1000000, ceo);

			Client client1 = new Client("Client1", "Clientov", 39, 4100, "Azerbaycan", "Baku");
			Client client2 = new Client("Client2", "Clientzade", 58, 3600, "Azerbaycan", "Baku");
			Client client3 = new Client("Client3", "Clientli", 45, 1800, "Azerbaycan", "Baku");

			DateTime dt1 = DateTime.Now;
			dt1.AddMonths(36);

			Credit credit1 = new Credit(client1, 35000, 21, dt1);
			Credit credit2 = new Credit(client2, 28000, 24, dt1);
			Credit credit3 = new Credit(client3, 16000, 29, dt1);

			bank.Credits.Add(credit1);
			bank.Credits.Add(credit2);
			bank.Credits.Add(credit3);

			Manager manager = new Manager("Manager1", "Managerli", 41, 3700, "Manager");

			bank.Managers.Add(manager);

			TimeOnly tm1 = new();
			TimeOnly tm2 = new();
			tm1.AddHours(9);
			tm2.AddHours(18);

			Worker worker = new Worker("Worker1", "Workerzade", 25, 5300, "Worker", tm1, tm2);

			bank.Workers.Add(worker);

			bank.ShowClientCredit(client1.Name);

			bank.PayCredit(credit1, 8000);
			Console.WriteLine();

			bank.ShowClientCredit(client1.Name);

			Console.WriteLine();
			Console.WriteLine(bank.CalculateProfit());

			Console.WriteLine();
			bank.ShowAllCredits();
		}
		catch(Exception ex)
		{
            Console.WriteLine($"\n{ex.Message}\n");
        }


	}
}
