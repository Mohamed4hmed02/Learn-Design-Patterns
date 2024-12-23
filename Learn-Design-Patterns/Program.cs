#region Singleton
//using Learn_Design_Patterns.Creational.Singleton;
//var singletonInstance = Singleton.Instance;
//singletonInstance.DoSomeThing();
#endregion

//*****************************************************************************

#region Builder
//using Learn_Design_Patterns.Creational.Builder;
//using System.Text.Json;
//var homeBuilder = new Home.HomeBuilder();
//var home = homeBuilder.AddWalls(3).AddRooms(3).AddWalls(3).Build();
//Console.WriteLine(JsonSerializer.Serialize(home));
#endregion

//*****************************************************************************

#region Factory
//using Learn_Design_Patterns.Creational.Factory;
//var pc = ComputerAbstractFactory.GetComputer(ComputerType.PC, "Core i3 3700", "8G DDR3");
//var server = ComputerAbstractFactory.GetComputer(ComputerType.Server, "Core i9 13600", "128G DDR5");
//pc.ShowCPU();
//server.ShowCPU();
#endregion

//*****************************************************************************

#region AbstractFactory
//using Learn_Design_Patterns.Creational.AbstractFactory;
//var pc = ComputerFactory.GetComputer(new PCFactory("8G DDR3", "Core i3 3700"));
//var server = ComputerFactory.GetComputer(new ServerFactory("128G DDR5", "Core i9 13600"));
//pc.ShowRAM();
//server.ShowRAM();
#endregion

//*****************************************************************************

#region Chain of responsibility
//using Learn_Design_Patterns.Behavioral.ChainOfResponsibility;
//
//var finalHandler = new FinalVacationHAndler();
//var CEOHandler = new CEOVacationHandler(finalHandler);
//var leaderHandler = new LeaderVacationHandler(CEOHandler);
//var seniorHandler = new SeniorVacationHandler(leaderHandler);
//
//var vacationRequest = new VacationRequest(EmployeeType.CEO);
//
//seniorHandler.Handle(vacationRequest);
#endregion

//*****************************************************************************

#region Adapter
//using Learn_Design_Patterns.Stra.Adapter;
//var card = new MySystemCreditCard
//{
//	CardHolder = "Mohamed",
//	CardNumber = "1234"
//};
//MySystem.ShowCardDetails(card);
#endregion

//*****************************************************************************

#region Strategy
//using Learn_Design_Patterns.Behavioral.Strategy;
//var game = new MarioGame();
//game.Jump(JumpScenarios.InWater);
//game.Jump(JumpScenarios.OnLand);
#endregion

