namespace Learn_Design_Patterns.Behavioral.ChainOfResponsibility
{
	public class CEOVacationHandler(IVacationHandler nextHandler) : AbstractVacationHandler(nextHandler), IVacationHandler
	{
		public void Handle(VacationRequest request)
		{
			if (request.Employee != EmployeeType.CEO)
				Console.WriteLine("CEO Handled The Request");
			else
				_nextHandler.Handle(request);
		}
	}
}
