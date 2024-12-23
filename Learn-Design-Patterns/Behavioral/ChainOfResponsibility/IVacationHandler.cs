namespace Learn_Design_Patterns.Behavioral.ChainOfResponsibility
{
	public interface IVacationHandler
	{
		void Handle(VacationRequest request);
	}

	public abstract class AbstractVacationHandler(IVacationHandler nextHandler)
	{
		protected readonly IVacationHandler _nextHandler = nextHandler;
	}

	public record VacationRequest(EmployeeType Employee);

	public enum EmployeeType
	{
		CEO,
		Leader,
		Senior,
		Junior
	}
}
