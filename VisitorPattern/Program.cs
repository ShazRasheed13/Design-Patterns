using System.Reflection.Metadata;
using VisitorPattern;

Documents documents = new Documents();
documents.AddElement(new Paragraph());
documents.AddElement(new Heading());
documents.AddElement(new Image());

Console.WriteLine("Rendering Document:");
documents.Accept(new RenderingVisitor());
Console.WriteLine("\nSpell Checking Document:");
documents.Accept(new SpellCheckingVisitor());
//New operation added
Console.WriteLine("\nLength/Size Document:");
documents.Accept(new Trial());