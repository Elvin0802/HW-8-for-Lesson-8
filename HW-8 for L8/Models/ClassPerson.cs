namespace Lesson8.Models;

public abstract class Person
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    public Person(string name, string surname, int age, int salary)
	{
        Id = Guid.NewGuid();

        Name = name;
        Surname = surname;
        Age = age;
        Salary = salary;
    }

	public override string ToString()
	{
        return $"Id : {Id.ToString()}\nName : {Name}\nSurname : {Surname}\nAge : {Age}\nSalary : {Salary}\n";
	}
}
