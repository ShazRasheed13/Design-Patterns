using BuilderPattern;

IComputerBuilder gamingBuilder = new GamingComputerBuilder();

ComputerDirector director = new ComputerDirector(gamingBuilder);

director.BuildComputer();

Computer gamingComputer = gamingBuilder.GetComputer();

gamingComputer.DisplayConfiguration();
