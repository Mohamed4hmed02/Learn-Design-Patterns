namespace Learn_Design_Patterns.Behavioral.Strategy
{
	public class MarioGameJumpOnAirStrategy : MarioGameJumpStrategy
	{
		public override void Jump()
		{
			Console.WriteLine("Mario can't jump");
		}
	}
}
