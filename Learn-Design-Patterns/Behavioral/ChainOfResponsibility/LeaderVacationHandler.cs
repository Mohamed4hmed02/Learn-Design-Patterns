namespace Learn_Design_Patterns.Behavioral.ChainOfResponsibility
{
	public class LeaderVacationHandler(IVacationHandler nextHandler) : AbstractVacationHandler(nextHandler), IVacationHandler
	{
		public void Handle(VacationRequest request)
		{
			if (request.Employee == EmployeeType.Junior || request.Employee == EmployeeType.Senior)
				Console.WriteLine("Leader Handled The Request");
			else
				_nextHandler.Handle(request);
		}
	}
}
