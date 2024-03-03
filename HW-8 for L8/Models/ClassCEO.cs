namespace Lesson8.Models;

public class CEO: Person
{
    public string Position{ get; set; }

    public CEO(string name, string surname, int age, int salary,string position)
        : base(name,surname,age,salary)
    {
        Position=position;    
    }

	public override string ToString()
	{
		return (base.ToString() + $"Position : {Position}\n");
	}
}
