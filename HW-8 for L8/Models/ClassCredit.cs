namespace Lesson8.Models;

public class Credit
{
	double _amount;
	double _percent;

	public Guid Id { get; set; }
	public Client Client { get; set; }
	public double Amount
	{
		get { return _amount; }
		set
		{
			if (value <0)
				throw new Exception("Mebleg 0 dan Boyuk Olamlidir !");
			else
				_amount = value;
		}
	}
	public double Percent
	{
		get { return _percent; }
		set
		{
			if (value<0 || value>100)
				throw new Exception("Faiz 0 dan Boyuk, 100 den kicik Olamlidir !");
			else
				_percent = value;
		}
	}
	public DateTime Months { get; set; }

	public Credit(Client client, double amount, double percent, DateTime months)
	{
		Id = Guid.NewGuid();

		Client = client;
		Amount = amount;
		Percent = percent;
		Months = months;
	}

	public double calculatePercent()
	{
		return ((Amount*Percent)/100.0);
	}
	public void payment(double amount)
	{
		if (Amount>=amount)
			Amount-=amount;
		else
			Amount = 0;
	}

	public override string ToString()
	{
		return $"ID : {Id.ToString()}\nClient : {Client.Surname} {Client.Name}" +
		$" \nAmount : {Amount}\nPercent : {Percent}\nCredit Ending Time : {Months.Year}/{Months.Month}\n";
	}

}
