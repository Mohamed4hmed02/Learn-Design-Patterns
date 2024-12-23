namespace Learn_Design_Patterns.Behavioral.Strategy
{
	public class MarioGameJumpInWaterStrategy : MarioGameJumpStrategy
	{
		public override void Jump()
		{
			Console.WriteLine("Mario swim faster");
		}
	}
}
