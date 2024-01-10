using CompositePattern;

IGraphic circle = new Circle();
IGraphic square = new Square();

CompositeGraphic group = new CompositeGraphic();
group.Add(circle);
group.Add(square);
group.Add(circle);

Console.WriteLine("Drawing Individual Shapes:");
circle.Draw();
square.Draw();

Console.WriteLine("\nDrawing Group of Shapes:");
group.Draw();