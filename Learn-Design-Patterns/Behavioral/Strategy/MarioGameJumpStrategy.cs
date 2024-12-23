namespace Learn_Design_Patterns.Behavioral.Strategy
{
	public abstract class MarioGameJumpStrategy
	{
		public abstract void Jump();
	}
	public enum JumpScenarios
	{
		OnLand,
		OnAir,
		InWater
	}
}
