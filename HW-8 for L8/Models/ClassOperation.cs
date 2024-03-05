namespace Lesson8.Models;

public class Operation
{
	public Guid Id { get; set; }

    public string ProcessName { get; set; }
	public DateTime ProcessDate { get; set; }
	public bool Status { get; set; }

    public Operation(string processName, DateTime processDate)
    {
		Id = Guid.NewGuid();

		ProcessName=processName;
		ProcessDate=processDate;
	}

	public override string ToString()
	{
		return $"ID : {Id.ToString()}\nProcess Name : {ProcessName}\nProcess Date : {ProcessDate.ToString()}";
	}

	public void ChangeStatus()
	{
		Status= (!Status);
	}

}
