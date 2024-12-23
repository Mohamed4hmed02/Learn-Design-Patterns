using System.Text.Json;

namespace Learn_Design_Patterns.Stra.Adapter
{
	public static class MySystem
	{
		public static void ShowCardDetails(MySystemCreditCard card)
		{
			Console.WriteLine("Without Adapter");
			LegacySystem.ShowCreditCardDetails(JsonSerializer.Serialize(card));

			Console.WriteLine("With Adapter");
			LegacySystem.ShowCreditCardDetails(JsonSerializer.Serialize(new CreditCardLegacySystemAdapter(card)));
		}
	}

	public class MySystemCreditCard
	{
		public string CardNumber { get; set; } = string.Empty;
		public string CardHolder { get; set; } = string.Empty;
	}
}
