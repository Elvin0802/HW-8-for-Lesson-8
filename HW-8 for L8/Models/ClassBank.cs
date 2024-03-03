namespace Lesson8.Models;

public class Bank
{
    public string Name { get; set; }
    public double Budget { get; set; }
    public double Profit { get; set; }
    public CEO BankCeo { get; set; }
    public List<Worker> Workers { get; set; }
    public List<Manager> Managers { get; set; }
    public List<Client> Clients { get; set; }


    public Bank(string name,double budget,CEO ceo)
    {
        Name=name;
        Budget=budget;
        Profit=0;
        BankCeo=ceo;
        Workers = new List<Worker>();
		Managers = new List<Manager>();
		Clients = new List<Client>();
    }

}
