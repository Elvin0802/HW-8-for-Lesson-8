using Lesson8.Interfaces;
using System.Xml.Linq;

namespace Lesson8.Models;

public class Bank
{
	string _name;
	double _budget;
	CEO _ceo;

	public string Name
	{
		get { return _name; }
		set
		{
			if (value.Length<3)
				throw new Exception("Ad Qisadir !");
			else
				_name = value;
		}
	}

	public double Budget
	{
		get { return _budget; }
		set
		{
			if (value<0)
				throw new Exception("Budce 0 dan kicik ola bilmez !!");
			else
				_budget = value;
		}
	}
	public double Profit { get; set; }
	public CEO BankCeo
	{
		get { return _ceo; }
		set
		{
			if (value is null) { throw new Exception("Ceo is NUll !"); }
			else { _ceo=value; }
		}
	}
	public List<Worker> Workers { get; set; }
	public List<Manager> Managers { get; set; }
	public List<Client> Clients { get; set; }
	public List<Credit> Credits { get; set; }


	public Bank(string name, double budget, CEO ceo)
	{
		Name=name;
		Budget=budget;
		Profit=0;
		BankCeo=ceo;
		Workers = new List<Worker>();
		Managers = new List<Manager>();
		Clients = new List<Client>();
		Credits = new List<Credit>();
	}

	public double CalculateProfit()
	{
		foreach (var cr in Credits)
			Profit += cr.calculatePercent();

		return Profit;
	}

	public void ShowClientCredit(string name)
	{
		foreach (var cr in Credits)
		{
			if (cr.Client.Name==name)
			{
				Console.WriteLine(cr.ToString());
				return;
			}
		}
	}

	public bool PayCredit(Credit credit, double money)
	{
		foreach (var cr in Credits)
		{
			if (cr.Id == credit.Id)
			{
				cr.payment(money);
				Console.WriteLine($"Payment To Credit for {credit.Client.Name} {credit.Client.Surname}");
				return true;
			}
		}
		return false;
	}
	public void ShowAllCredits()
	{
		Console.WriteLine("\n\t\tCredits \n");
		foreach (var cr in Credits)
		{
			Console.WriteLine("---------------------------------------------");
			Console.WriteLine(cr.ToString());
		}
	}

	public Worker? GetWorkerById(string ID)
	{
		foreach (var w in Workers)
			if (w.Id.ToString()==ID)
				return w;

		return null;
	}

	public Manager? GetManagerById(string ID)
	{
		foreach (Manager m in Managers)
			if (m.Id.ToString()==ID)
				return m;

		return null;
	}


	public Client? GetClientById(string ID)
	{
		foreach (Client c in Clients)
			if (c.Id.ToString()==ID)
				return c;

		return null;
	}

	public Credit? GetCreditById(string ID)
	{
		foreach (Credit c in Credits)
			if (c.Id.ToString()==ID)
				return c;

		return null;
	}

}
