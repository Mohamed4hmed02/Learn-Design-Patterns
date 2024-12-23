namespace Learn_Design_Patterns.Behavioral.Strategy
{
	public class MarioGame
	{
		public void Jump(JumpScenarios scenario)
		{
			if (scenario == JumpScenarios.InWater)
				new MarioGameJumpInWaterStrategy().Jump();
			else if (scenario == JumpScenarios.OnLand)
				new MarioGameJumpOnLandStrategy().Jump();
			else
				new MarioGameJumpOnAirStrategy().Jump();
		}
	}
}
