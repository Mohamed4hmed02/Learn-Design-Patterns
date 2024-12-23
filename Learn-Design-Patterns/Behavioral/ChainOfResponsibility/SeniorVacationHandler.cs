namespace Learn_Design_Patterns.Behavioral.ChainOfResponsibility
{
	public class SeniorVacationHandler(IVacationHandler nextHandler) : AbstractVacationHandler(nextHandler), IVacationHandler
	{
		public void Handle(VacationRequest request)
		{
			if (request.Employee == EmployeeType.Junior)
				Console.WriteLine("Senior Handled The Request");
			else
				_nextHandler.Handle(request);
		}
	}
}
