namespace Lesson8.Models;

public class Worker: Person
{

	public string Position { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

	private List<Operation> Operations { get; set; }
	
    public Worker(string name, string surname, int age, int salary, string position,TimeOnly startTime, TimeOnly endTime)
		: base(name, surname, age, salary)
	{
		Position=position;
		StartTime=startTime;
		EndTime=endTime;
		Operations=new();
	}

	public void AddOperation(Operation oper)
	{
		Operations.Add(oper);
	}
	public void DeleteOperationById(string Id)
	{
		foreach (Operation op in Operations) 
		{
			if(op.Id.ToString()==Id)
			{
				Operations.Remove(op);
				break;
			}
		}
	}

	public override string ToString()
	{
		return (base.ToString() + $"Position : {Position}\nJob Start Time : {StartTime.ToString()}\n\nJob End Time : {EndTime.ToString()}\n");
	}

}
