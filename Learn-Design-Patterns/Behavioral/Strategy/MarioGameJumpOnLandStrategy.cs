namespace Learn_Design_Patterns.Behavioral.Strategy
{
	public class MarioGameJumpOnLandStrategy : MarioGameJumpStrategy
	{
		public override void Jump()
		{
			Console.WriteLine("Mario is jumping to air");
		}
	}
}
