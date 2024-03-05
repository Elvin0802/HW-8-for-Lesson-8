using Lesson8.Interfaces;

namespace Lesson8.Models;

public class Manager: Person,IOrganization
{
	public string Position { get; set; }

	public Manager(string name, string surname, int age, double salary, string position)
		: base(name, surname, age, salary)
	{
		Position=position;
	}


	public override string ToString()
	{
		return (base.ToString() + $"Position : {Position}\n");
	}

	public void organize()
	{
        Console.WriteLine("Manager Organize Method.");
    }
	public void calculateSalaries()
	{
        Console.WriteLine("Manager Calculate Salaries for Bank.");
    }
}
