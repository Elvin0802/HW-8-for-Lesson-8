
namespace Lesson8.Models;

public abstract class Person
{
	string _name;
	string _surname;
	int _age;
	double _salary;

	public Guid Id { get; set; }
    public string Name {
		get { return _name; }
		set
		{
			if (value.Length<3)
				throw new Exception("Ad Qisadir !");
			else
				_name = value;
		}
    }
    public string Surname
	{
		get { return _surname; }
		set
		{
			if (value.Length<3)
				throw new Exception("Soyad Qisadir !");
			else
			_surname= value;
		}
	}
	public int Age
	{
		get { return _age; }
		set
		{
			if (value<10)
			{
				throw new Exception("Yas 10 dan Boyuk Olamlidir !");
			}
			else
			{
				_age=value;
			}
		}
	}
	public double Salary
	{
		get { return _salary; }
		set
		{
			if (value<0)
			{
				throw new Exception("Maash 0 dan Boyuk Olamlidir !");
			}
			else
			{
				_salary=value;
			}
		}
	}

	public Person(string name, string surname, int age, double salary)
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
