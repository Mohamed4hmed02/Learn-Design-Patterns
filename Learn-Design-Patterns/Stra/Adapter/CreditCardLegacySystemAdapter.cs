namespace Learn_Design_Patterns.Stra.Adapter
{
	internal class CreditCardLegacySystemAdapter(MySystemCreditCard card)
	{
		public string Card_Number => card.CardNumber;
		public string Card_Holder => card.CardHolder;
	}
}
