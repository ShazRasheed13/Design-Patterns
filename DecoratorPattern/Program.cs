using DecoratorPattern;

ICoffee coffee = new SimpleCoffee();
Console.WriteLine($"Description: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

coffee= new MilkDecorator(coffee);
Console.WriteLine($"Description: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

coffee = new SugarDecorator(coffee);
Console.WriteLine($"Description: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");
