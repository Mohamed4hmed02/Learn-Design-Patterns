namespace Learn_Design_Patterns.Creational.Builder
{
	public class Home : HomeBase
	{
		private Home(int walls, int rooms, int furniture)
		{
			Walls = walls;
			Rooms = rooms;
			Furniture = furniture;
		}

		public class HomeBuilder : HomeBase
		{
			public HomeBuilder AddWalls(int count)
			{
				Walls += count;
				return this;
			}
			public HomeBuilder AddRooms(int count)
			{
				Rooms += count;
				return this;
			}
			public HomeBuilder AddFurniture(int count)
			{
				Furniture += count;
				return this;
			}
			public Home Build()
			{
				return new Home(Walls, Rooms, Furniture);
			}
		}
	}
}
