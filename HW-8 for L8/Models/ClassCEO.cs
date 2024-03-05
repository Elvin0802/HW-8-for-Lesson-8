using Lesson8.Interfaces;

namespace Lesson8.Models;

public class CEO: Person,IControl,IOrganization
{
    public string Position{ get; set; }

    public CEO(string name, string surname, int age, double salary,string position)
        : base(name,surname,age,salary)
    {
        Position=position;    
    }

	public override string ToString()
	{
		return (base.ToString() + $"Position : {Position}\n");
	}

	public void organize()
	{
        Console.WriteLine("CEO Organize Method");
    }

	public void control()
	{
        Console.WriteLine("CEO Control Method");
	}
	public void makeMeeting()
	{
        Console.WriteLine("CEO Make Meeting with Employeers");
	}
	public void decreasePercentage(double percent)
	{
		Console.WriteLine($"CEO Decrease Credit Percentage by {percent} %");
	}
}
