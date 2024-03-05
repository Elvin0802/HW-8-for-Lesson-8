using Lesson8.Interfaces;

namespace Lesson8.Models;

public class Worker: Person,IAdding<Operation>
{

	public string Position { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

	private List<Operation> Operations { get; set; }
	
    public Worker(string name, string surname, int age, double salary, string position,TimeOnly startTime, TimeOnly endTime)
		: base(name, surname, age, salary)
	{
		Position=position;
		StartTime=startTime;
		EndTime=endTime;
		Operations=new();
	}

	public void Add(Operation oper)
	{
		Operations.Add(oper);
	}
	
	public override string ToString()
	{
		return (base.ToString() + $"Position : {Position}\nJob Start Time : {StartTime.ToString()}\n\nJob End Time : {EndTime.ToString()}\n");
	}

	public bool DeleteOperationById(string ID)
	{
		foreach (Operation op in Operations)
			if (op.Id.ToString()==ID)
				return Operations.Remove(op);

		return false;
	}

	public Operation? GetOperationById(string ID)
	{
		foreach (Operation op in Operations)
			if (op.Id.ToString()==ID)
				return op;

		return null;
	}
}
