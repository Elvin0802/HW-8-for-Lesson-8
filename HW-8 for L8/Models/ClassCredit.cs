namespace Lesson8.Models;

public class Credit
{
	public Guid Id { get; set; }
	public Client Client { get; set; }
    public double Amount { get; set; }
    public double Percent { get; set; }
    public DateTime Months { get; set; }

	public Credit(Client client, double amount, double percent, DateTime months)
	{
        Id = Guid.NewGuid();

        Client = client;
        Amount = amount;
        Percent = percent;
        Months = months;
    }



}
