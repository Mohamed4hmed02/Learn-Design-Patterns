using System.Text.Json;

namespace Learn_Design_Patterns.Stra.Adapter
{
	internal static class LegacySystem
	{
		/// <summary>
		/// Desrialize the card object based on LegacySystemCreditCard class
		/// </summary>
		/// <param name="card"></param>
		public static void ShowCreditCardDetails(string card)
		{
			var obj = JsonSerializer.Deserialize<LegacySystemCreditCard>(card);
			if (obj is not null)
				Console.WriteLine($"{obj.Card_Holder},{obj.Card_Number}");
		}
	}


	internal class LegacySystemCreditCard
	{
		public string Card_Number { get; set; } = "Not Matched";
		public string Card_Holder { get; set; } = "Not Matched";
	}
}
