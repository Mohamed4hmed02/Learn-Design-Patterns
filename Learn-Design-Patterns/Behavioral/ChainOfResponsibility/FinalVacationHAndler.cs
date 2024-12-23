namespace Learn_Design_Patterns.Behavioral.ChainOfResponsibility
{
	public class FinalVacationHAndler : IVacationHandler
	{
		public void Handle(VacationRequest request)
		{
			Console.WriteLine("Request Can't Be Handled");
		}
	}
}
