namespace Lesson8.Models;

public class Client : Person
{
	public string LiveAddress { get; set; }
	public string WorkAddress { get; set; }

	public Client(string name, string surname, int age, double salary, string liveAddress, string workAddress)
		: base(name, surname, age, salary)
	{
		LiveAddress = liveAddress;
		WorkAddress = workAddress;
	}

	public override string ToString()
	{
		return (base.ToString() + $"Live Address : {LiveAddress}\nWork Address : {WorkAddress}\n");
	}

}
