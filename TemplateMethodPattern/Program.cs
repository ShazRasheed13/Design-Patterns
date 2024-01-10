using TemplateMethodPattern;

Console.WriteLine("Preparing Coffee:");
HotBeverage coffee = new Coffee();
coffee.PrepareBeverage();

Console.WriteLine("\nPreparing Tea:");
HotBeverage tea = new Tea();
tea.PrepareBeverage();
